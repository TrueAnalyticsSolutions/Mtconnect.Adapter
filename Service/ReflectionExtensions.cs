﻿using System.Collections;

namespace Service
{
    internal static class ReflectionExtensions
    {
        internal static object? ConstructFromConfig(object? config, Type targetType, ILogger<Worker>? logger = null)
        {
            Type? configType = config?.GetType();
            bool isDictionary = config is IDictionary<string, object?>;

            object? result = null;
            var ctors = targetType.GetConstructors().OrderByDescending(o => o.GetParameters()?.Length);
            foreach (var ctor in ctors)
            {
                var ctorParams = ctor.GetParameters();

                List<object?> resultParams = new List<object?>();
                foreach (var ctorParam in ctorParams)
                {
                    object? value = null;
                    if (isDictionary)
                    {
                        if ((config as IDictionary).Contains(ctorParam.Name))
                        {
                            value = (config as IDictionary)[ctorParam.Name];
                        }
                    }
                    else
                    {
                        var property = configType?.GetProperty(ctorParam.Name);
                        if (property != null)
                        {
                            value = property.GetValue(config, null);
                        }
                    }

                    if (value != null)
                    {
                        value = Convert.ChangeType(value, ctorParam.ParameterType);

                        resultParams.Add(value);
                    }
                    else if (ctorParam.IsOptional)
                    {
                        resultParams.Add(ctorParam.DefaultValue);
                    }
                }
                if (resultParams.Count == ctorParams.Length)
                {
                    result = ctor.Invoke(resultParams.ToArray());
                    if (result != null) break;
                }
            }

            if (result == null)
            {
                logger?.LogError("Could not construct {AdapterOptionsType}", targetType.FullName);
                return null;
            }

            Dictionary<string, object?>? configProperties = null;
            if (isDictionary)
            {
                configProperties = (config as Dictionary<string, object?>);
            }
            else
            {
                configProperties = configType?.GetProperties().ToDictionary(o => o.Name, o => o.GetValue(config, null));
            }
            if (configProperties != null)
            {
                foreach (var kvp in configProperties)
                {
                    var property = targetType.GetProperty(kvp.Key);
                    if (property == null) continue;

                    property.SetValue(result, kvp.Value);
                }
            }

            return result;
        }
    }
}