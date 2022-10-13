﻿using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Linq;
using Microsoft.Extensions.Logging;
using Mtconnect.AdapterInterface.DataItems;
using Mtconnect.AdapterInterface.Contracts;
using Mtconnect.AdapterInterface;
using Mtconnect.AdapterInterface.Assets;
using System.Data;
using System.Collections.Concurrent;

namespace Mtconnect
{

    /// <summary>
    /// An abstract implementation for a MTConnect adapter
    /// </summary>
    public abstract class Adapter
    {
        /// <summary>
        /// Reference to a logging service.
        /// </summary>
        protected readonly ILogger<Adapter> _logger;

        /// <summary>
        /// The * PONG ... text
        /// </summary>
        protected byte[] PONG { get; set; }

        /// <summary>
        /// Internal collection of <see cref="DataItem"/>s being tracked.
        /// </summary>
        private Dictionary<string, DataItem> _dataItems = new Dictionary<string, DataItem>();

        /// <summary>
        /// Reference to the collection of <see cref="DataItem"/>s being tracked.
        /// </summary>
        protected IEnumerable<DataItem> DataItems => _dataItems.Values;

        /// <summary>
        /// A queue of <see cref="DataItem"/> changed values that have not been sent to clients.
        /// </summary>
        private ConcurrentQueue<ReportedValue> _values = new ConcurrentQueue<ReportedValue>();

        /// <summary>
        /// Provides a reference to a <see cref="DataItem"/> from the internal collection based on the provided <paramref name="name"/>.
        /// </summary>
        /// <param name="name">Reference to the <see cref="DataItem.Name"/> to lookup.</param>
        /// <returns>Reference to the <see cref="DataItem"/> with the matching <paramref name="name"/>.</returns>
        public DataItem this[string name]
        {
            get { return _dataItems[name]; }
            set
            {
                _dataItems[name] = value;
            }
        }

        /// <summary>
        /// The send changed has begun and we are tracking conditions.
        /// </summary>
        public bool HasBegun { get; protected set; } = false;

        /// <summary>
        /// The ascii encoder for creating the messages.
        /// </summary>
        protected ASCIIEncoding Encoder { get; } = new ASCIIEncoding();

        /// <summary>
        /// The heartbeat interval.
        /// </summary>
        private double _heartbeat;
        /// <summary>
        /// This is a method to set the heartbeat interval given in milliseconds.
        /// </summary>
        public virtual double Heartbeat
        {
            get { return _heartbeat; }
            set
            {
                _heartbeat = value;
                PONG = Encoder.GetBytes($"* PONG {_heartbeat}\n");
            }
        }

        /// <summary>
        /// Indicates what state the MTConnect Adapter is currently in.
        /// </summary>
        public AdapterStates State { get; protected set; } = AdapterStates.NotStarted;

        /// <summary>
        /// Create an adapter. Defaults the heartbeat to 10 seconds and the 
        /// port to 7878
        /// </summary>
        /// <param name="heartbeat">The optional heartbeat (default: 10,000)</param>
        public Adapter(int heartbeat = 10_000)
        {
            Heartbeat = heartbeat;
        }

        public Adapter(Options options)
        {
            Heartbeat = options.Heartbeat;
        }


        /// <summary>
        /// Add a data item to the adapter.
        /// </summary>
        /// <param name="dataItem">The data item.</param>
        /// <exception cref="DuplicateNameException"></exception>
        public void AddDataItem(DataItem dataItem)
        {
            if (_dataItems.ContainsKey(dataItem.Name))
            {
                throw new DuplicateNameException("Adapter cannot handle DataItems with the same name");
            }

            _dataItems.Add(dataItem.Name, dataItem);
            _dataItems[dataItem.Name].OnDataItemChanged += Adapter_OnDataItemChanged; ;
        }

        private void Adapter_OnDataItemChanged(DataItem sender, DataItemChangedEventArgs e) => _values.Enqueue(new ReportedValue(sender));

        /// <summary>
        /// Remove all data items.
        /// </summary>
        public void RemoveAllDataItems()
        {
            _dataItems.Clear();
            // TODO: Clear appropriate ReportedValues from the Queue
        }

        /// <summary>
        /// Remove a data item from the adapter.
        /// </summary>
        /// <param name="dataItem"></param>
        public void RemoveDataItem(DataItem dataItem)
        {
            if (!_dataItems.ContainsKey(dataItem.Name))
            {
                throw new KeyNotFoundException("No DataItems found with the given name");
            }

            _dataItems.Remove(dataItem.Name);
            // TODO: Clear appropriate ReportedValues from Queue
        }

        /// <summary>
        /// Make all data items unavailable
        /// </summary>
        public void Unavailable()
        {
            foreach (var kvp in _dataItems)
                kvp.Value.Unavailable();
        }

        /// <summary>
        /// The asks all data items to begin themselves for collection. Only 
        /// required for conditions and should not be called if you are not 
        /// planning on adding all the conditions before you send. If you skip this
        /// the adapter will not perform the mark and sweep.
        /// </summary>
        public void Begin()
        {
            HasBegun = true;
            foreach (var kvp in _dataItems) kvp.Value.Begin();
        }

        /// <summary>
        /// Instructs the Adapter to send <see cref="DataItem"/>s based on a type of method.
        /// </summary>
        /// <param name="clientId">Reference to the id of the client to send the <see cref="ReportedValue"/>s to.</param>
        /// <param name="message">The message to send to any listeners to the adapter.</param>
        protected abstract void Write(string message, string clientId = null);

        /// <summary>
        /// Issues a <see cref="Write"/> command to the implementing Adapter for each appropriate <see cref="ReportedValue"/> depending on the provided <paramref name="sendType"/>.
        /// </summary>
        /// <param name="clientId">Reference to the id of the client to send the <see cref="ReportedValue"/>s to.</param>
        /// <param name="sendType">Flag for identifying which <see cref="ReportedValue"/>s to send.</param>
        public virtual void Send(DataItemSendTypes sendType = DataItemSendTypes.Changed, string clientId = null)
        {
            var values = new List<ReportedValue>();
            switch (sendType)
            {
                case DataItemSendTypes.All:
                    values = DataItems.SelectMany(o => o.ItemList(sendType == DataItemSendTypes.All)).Select(o => new ReportedValue(o)).ToList();
                    // TODO: Clear ConcurrentQueue
                    break;
                case DataItemSendTypes.Changed:
                    var changedDataItems = DataItems
                        .SelectMany(o => o.ItemList(sendType == DataItemSendTypes.All))
                        .Where(o => o.HasChanged);
                    values = changedDataItems.Select(o => new ReportedValue(o)).ToList();
                    // TODO: Clear ConcurrentQueue of matching DataItems.
                    break;
                default:
                    while (_values.TryDequeue(out ReportedValue value))
                    {
                        values.Add(value);
                    }
                    break;
            }

            if (values.Any())
            {
                Send(values, clientId);
            }
        }

        /// <summary>
        /// Iterates thru the provided <paramref name="values"/> and issues a <see cref="Write"/> command to the implementing Adapter.
        /// </summary>
        /// <param name="clientId">Reference to the id of the client to send the <see cref="ReportedValue"/>s to.</param>
        /// <param name="values">Collection of <see cref="ReportedValue"/>s to send values.</param>
        protected void Send(IEnumerable<ReportedValue> values, string clientId = null)
        {
            var orderedValues = values.OrderBy(o => o.Timestamp).ToList();
            var individualValues = values.Where(o => o.HasNewLine).ToList();
            var multiplicityValues = orderedValues.Except(individualValues).ToList();

            foreach (var item in individualValues)
            {
                Write($"{item.Timestamp}|{item}\n", clientId);
            }

            if (multiplicityValues.Any())
            {
                var timestampGroups = multiplicityValues.GroupBy(o => o.Timestamp);
                foreach (var grouping in timestampGroups)
                {
                    string contents = string.Join("|", grouping.Select(o => o.ToString()));
                    string timestamp = grouping.Key.ToString(Constants.DATE_TIME_FORMAT);
                    Write($"{timestamp}|{contents}\n", clientId);
                }
            }
        }

        /// <summary>
        /// Send a new asset to the Agent
        /// </summary>
        /// <param name="asset">The asset</param>
        public virtual void AddAsset(Asset asset)
        {
            StringBuilder sb = new StringBuilder();

            DateTime now = DateTime.UtcNow;
            sb.Append(now.ToString(Constants.DATE_TIME_FORMAT));
            sb.Append("|@ASSET@|");
            sb.Append(asset.AssetId);
            sb.Append('|');
            sb.Append(asset.GetMTCType());
            sb.Append("|--multiline--ABCD\n");

            XmlWriterSettings settings = new XmlWriterSettings();
            settings.OmitXmlDeclaration = true;

            XmlWriter writer = XmlWriter.Create(sb, settings);
            asset.ToXml(writer);
            writer.Close();
            sb.Append("\n--multiline--ABCD\n");

            Write(sb.ToString());
        }
        /// <summary>
        /// The heartbeat thread for a client. This thread receives data from a client, closes the socket when it fails, and handles communication timeouts when the client does not send a heartbeat within 2x the heartbeat frequency. When the heartbeat is not received, the client is assumed to be unresponsive and the connection is closed. Waits for one ping to be received before enforcing the timeout. 
        /// </summary>
        /// <param name="client">The client we are communicating with.</param>
        protected abstract void HeartbeatClient(object client);

        /// <summary>
        /// Start the listener thread.
        /// </summary>
        /// <param name="begin">Flag for whether or not to also call <see cref="Begin"/>.</param>
        public abstract void Start(bool begin = true);

        /// <summary>
        /// Stop the listener thread and shutdown all client connections.
        /// </summary>
        public abstract void Stop();
    }
}