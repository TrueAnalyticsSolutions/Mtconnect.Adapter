﻿using System;
using System.Threading;

namespace Mtconnect
{
    /// <summary>
    /// A generic interface for classes used to derive <see cref="Mtconnect.AdapterInterface.Contracts.Attributes.DataItemAttribute"/>s from use.
    /// </summary>
    public interface IAdapterSource
    {
        /// <summary>
        /// Handles the event when an Adapter source has finished receiving and processing data.
        /// </summary>
        event DataReceivedHandler OnDataReceived;

        /// <summary>
        /// Handles the event when an Adapter source has started processing data.
        /// </summary>
        event AdapterSourceStartedHandler OnAdapterSourceStarted;

        /// <summary>
        /// Handles the event when an Adapter source has stopped processing data.
        /// </summary>
        event AdapterSourceStoppedHandler OnAdapterSourceStopped;

        /// <summary>
        /// Instructs the Adapter source to begin collecting data.
        /// </summary>
        /// <param name="token">Token for cancelling the startup method.</param>
        void Start(CancellationToken token = default);

        /// <summary>
        /// Instructs the Adapter source to stop collecting and/or processing data.
        /// </summary>
        /// <param name="ex">Reference to a possible exception that led to the stop of the Adapter Source.</param>
        void Stop(Exception ex = null);
    }
}
