﻿using Microsoft.Extensions.Logging;
using Mtconnect;
using Mtconnect.AdapterInterface;
using Mtconnect.UPnP;
using Service.Configuration;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading;

namespace Service
{
    /// <summary>
    /// A factory that discovers and creates <see cref="AdapterInstance"/> from the <see cref="ServiceConfiguration"/>.
    /// </summary>
    public class AdapterFactory
    {
        private List<AdapterInstance> _adapters { get; set; } = new List<AdapterInstance>();
        internal ILogger<AdapterFactory> _logger { get; set; }

        public AdapterFactory(ILoggerFactory logFactory = default)
        {
            _logger = logFactory?.CreateLogger<AdapterFactory>();
        }

        /// <summary>
        /// Adds a <see cref="AdapterInstance"/> for the given <paramref name="adapter"/>.
        /// </summary>
        /// <param name="adapter">Instance of an <see cref="Adapter"/> to create and add an <see cref="AdapterInstance"/>.</param>
        public AdapterInstance Add(Adapter adapter)
        {
            if (adapter == null)
            {
                var nullEx = new ArgumentNullException(nameof(adapter));
                _logger?.LogError(nullEx, nullEx.Message);
                return null;
            }

            var result = new AdapterInstance(adapter);
            _adapters.Add(result);

            return result;
        }

        /// <summary>
        /// Adds the <paramref name="source"/> to each <see cref="Adapter"/> of type <paramref name="adapterType"/> that references the <see cref="IAdapterSource"/> in the <see cref="ServiceConfiguration"/>.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="adapterType"></param>
        public void Add(IAdapterSource source, Type adapterType)
        {
            if (source == null)
            {
                var nullEx = new ArgumentNullException(nameof(source));
                _logger?.LogError(nullEx, nullEx.Message);
                return;
            } else if (adapterType == null)
            {
                var nullEx = new ArgumentNullException(nameof(adapterType));
                _logger?.LogError(nullEx, nullEx.Message);
                return;
            }

            var adapters = _adapters.Where(o => o.Instance.GetType() == adapterType);

            if (!adapters.Any())
            {
                _logger?.LogWarning("No Adapter found of Type '{AdapterType}'", adapterType?.FullName);
                return;
            }

            foreach (var adapter in _adapters)
            {
                _logger?.LogInformation("Attaching {SourceType} to Adapter {AdapterType}", source.GetType().FullName, adapterType.FullName);
                adapter.Sources.Add(source);
            }
        }

        /// <summary>
        /// Starts all <see cref="Adapter"/>s.
        /// </summary>
        /// <param name="token">Reference to the upper-level cancellation token that can cancel the execution of each <see cref="Adapter"/>.</param>
        public void Start(CancellationToken token = default)
        {
            if (!_adapters.Any())
            {
                var ex = new InvalidOperationException("There are no Adapters to start");
                _logger?.LogWarning(ex, ex.Message);
                return;
            }

            foreach (var adapterInstance in _adapters)
            {
                var adapterType = adapterInstance.Instance.GetType();
                if (!adapterInstance.Sources.Any())
                {
                    var ex = new InvalidOperationException("There are no IAdapterSources to start");
                    _logger?.LogWarning(ex, ex.Message + " in Adapter type '{AdapterType}'", adapterType.FullName);
                    continue;
                }
                adapterInstance.Instance.OnStopped += Instance_OnStopped;
                adapterInstance.Instance.Start(adapterInstance.Sources, token: token);

                if (adapterInstance.Broadcaster != null) adapterInstance.Broadcaster.Start(token);

                _logger?.LogInformation("Started Adapter {AdapterType}", adapterType.FullName);
            }
        }

        private void Instance_OnStopped(Adapter sender, AdapterStoppedEventArgs e)
        {
            if (e.Exception != null)
            {
                _logger?.LogError(e.Exception, "Adapter Instance stopped due to error");
            } else if (e.WasCancelled)
            {
                _logger?.LogWarning("Adapter Instance was cancelled");
            } else
            {
                _logger?.LogInformation("Adapter Instance stopped");
            }
        }

        /// <summary>
        /// Stops all <see cref="Adapter"/>s.
        /// </summary>
        public void Stop()
        {
            if (!_adapters.Any())
            {
                var ex = new InvalidOperationException("There are no Adapters to stop");
                _logger?.LogWarning(ex, ex.Message);
                return;
            }

            foreach (var adapterInstance in _adapters)
            {
                var adapterType = adapterInstance.Instance.GetType();
                if (adapterInstance.Instance.State <= 0)
                {
                    var ex = new InvalidOperationException("Not necessary to stop an Adapter that is already stopped");
                    _logger?.LogWarning(ex, ex.Message + ". Adapter type '{AdapterType}' was '{AdapterState}'", adapterType, adapterInstance.Instance.State);
                    continue;
                }

                adapterInstance.Instance.Stop();
                adapterInstance.Instance.OnStopped -= Instance_OnStopped;

                if (adapterInstance.Broadcaster != null) adapterInstance.Broadcaster.Stop();
            }
        }

        /// <summary>
        /// Creates a new instance of <see cref="AdapterFactory"/> from the loaded assemblies imported from the <paramref name="config"/>.
        /// </summary>
        /// <param name="dlls">Reference to the list of imported assemblies.</param>
        /// <param name="config">Reference to the loaded <see cref="ServiceConfiguration"/>.</param>
        /// <param name="logger">Reference to the injected logger for the service.</param>
        /// <param name="adapterLogger">Reference to the injected logger for all Adapters.</param>
        /// <returns></returns>
        public static AdapterFactory CreateFromTypes(IEnumerable<Assembly> dlls, ServiceConfiguration config, ILoggerFactory logFactory = default)
        {
            var factory = new AdapterFactory(logFactory);

            foreach (var adapterConfig in config.Adapters)
            {
                var adapterType = dlls
                    .Select(o => o.GetType(adapterConfig.Adapter))
                    .Where(o => o != null)
                    .FirstOrDefault();

                if (adapterType == null)
                {
                    factory._logger?.LogError("Could not find Adapter type {AdapterType} from imported DLL(s)", adapterConfig.Adapter);
                    continue;
                }

                //AdapterOptions result, ILogger<Adapter> workerLogger = null
                var adapterCtors = adapterType.GetConstructors();
                bool constructedAdapter = false;
                foreach (var adapterCtor in adapterCtors)
                {
                    var optionsParam = adapterCtor.GetParameters().FirstOrDefault(o => o.ParameterType.IsSubclassOf(typeof(AdapterOptions)));
                    object? options = ReflectionExtensions.ConstructFromConfig(adapterConfig.Options, optionsParam?.ParameterType, factory._logger);

                    var adapter = adapterCtor.Invoke(new object?[] { options, logFactory }) as Adapter;
                    if (adapter == null)
                    {
                        factory._logger?.LogError(new InvalidCastException("Failed to construct Adapter"), "Failed to construct Adapter {AdapterType}", adapterType.FullName);
                        continue;
                    }

                    constructedAdapter = true;
                    var instance = factory.Add(adapter);

                    // If configuration indicates to broadcast
                    if (adapterConfig.UPnP != null)
                    {
                        // TODO: Find appropriate Broadcaster type
                        var broadcastType = dlls
                            .Select(o => o.GetType(adapterConfig.UPnP.Type))
                            .Where(o => o != null)
                            .FirstOrDefault();
                        if (broadcastType != null)
                        {
                            // Inject a reference to the Adapter and ILoggerFactory
                            if (!adapterConfig.UPnP.Options.ContainsKey("adapter")) adapterConfig.UPnP.Options.Add("adapter", instance.Instance);
                            if (!adapterConfig.UPnP.Options.ContainsKey("logFactory")) adapterConfig.UPnP.Options.Add("logFactory", logFactory);

                            var broadcaster = ReflectionExtensions.ConstructFromConfig(adapterConfig.UPnP.Options, broadcastType, factory._logger);
                            if (broadcaster != null)
                            {
                                instance.Broadcaster = broadcaster as IUPnPService;
                            }
                        }
                    }
                }

                if (constructedAdapter)
                {
                    factory._logger?.LogInformation("Constructed Adapter {AdapterType}", adapterConfig.Adapter);
                } else
                {
                    var ctorException = new MissingMethodException("Adapter missing constructor with AdapterOptions parameter");
                    factory._logger?.LogError(ctorException, "Adapter {AdapterType} missing constructor with AdapterOptions parameter and therefore could not be constructed", adapterConfig.Adapter);
                }
            }

            _addSources(factory, dlls, config);

            return factory;
        }

        /// <summary>
        /// Adds all <see cref="IAdapterSource"/>s from the imported DLLs and assigns them to the appropriate <see cref="Adapter"/>s.
        /// </summary>
        /// <param name="factory">Reference to the <see cref="AdapterFactory"/> to load the <see cref="IAdapterSource"/>s into.</param>
        /// <param name="dlls">Reference to the list of imported assemblies.</param>
        /// <param name="config">Reference to the loaded <see cref="ServiceConfiguration"/>.</param>
        /// <param name="logger">Reference to the injected logger for the service.</param>
        private static void _addSources(AdapterFactory factory, IEnumerable<Assembly> dlls, ServiceConfiguration config)
        {
            foreach (var dll in dlls)
            {
                var sourceTypes = dll.GetTypes().Where(o => typeof(IAdapterSource).IsAssignableFrom(o) && !o.IsInterface && !o.IsAbstract);

                foreach (var sourceType in sourceTypes)
                {
                    var sourceConfig = config.Sources?.FirstOrDefault(o => o.Source == sourceType.Name || o.Source == sourceType.FullName);
                    IAdapterSource? source = ReflectionExtensions.ConstructFromConfig(sourceConfig?.Options, sourceType, factory._logger) as IAdapterSource;
                    if (source == null)
                    {
                        factory._logger?.LogError(new InvalidCastException("Failed to construct IAdapterSource"), "Failed to construct IAdapterSource {SourceType}", sourceType.FullName);
                        continue;
                    }

                    var adapterConfigs = config.Adapters.Where(o => o.Sources.Contains(sourceType.Name) || o.Sources.Contains(sourceType.FullName));
                    var adapterTypes = dlls
                        .SelectMany(o => adapterConfigs.Select(c => o.GetType(c.Adapter)))
                        .Where(o => o != null)
                        .Distinct()
                        .ToArray();
                    foreach (var adapterType in adapterTypes)
                    {
                        factory.Add(source, adapterType);
                    }
                }
            }
        }
    }
}