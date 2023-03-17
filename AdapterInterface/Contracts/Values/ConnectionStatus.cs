#pragma warning disable 0618
#pragma warning disable 1574
using System;
using System.CodeDom.Compiler;
using Mtconnect.AdapterInterface.Contracts.Attributes;
using Mtconnect.AdapterInterface.Contracts;
using Mtconnect.AdapterInterface.DataItems;
using Mtconnect.AdapterInterface.DataItemValues;

namespace Mtconnect.AdapterInterface.DataItemValues
{
	/// <summary>
	/// A value type for ConnectionStatus to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.14.0")]
	public partial class ConnectionStatus : EventValue
    {
		/// <summary>
		/// Constructs a new value type for the ConnectionStatus EVENT Data Item.
		/// </summary>
        public ConnectionStatus(string value) : base(value) { }

        /// <summary>
		﻿/// no connection at all.
        /// </summary>
		[ObservationalValue(typeof(ConnectionStatusValues))]
        public static ConnectionStatus CLOSED => new ConnectionStatus(nameof(ConnectionStatusValues.CLOSED));
        /// <summary>
		﻿/// <i>agent</i> is waiting for a connection request from an <i>adapter</i>.
        /// </summary>
		[ObservationalValue(typeof(ConnectionStatusValues))]
        public static ConnectionStatus LISTEN => new ConnectionStatus(nameof(ConnectionStatusValues.LISTEN));
        /// <summary>
		﻿/// open connection.  The normal state for the data transfer phase of the connection.
        /// </summary>
		[ObservationalValue(typeof(ConnectionStatusValues))]
        public static ConnectionStatus ESTABLISHED => new ConnectionStatus(nameof(ConnectionStatusValues.ESTABLISHED));
		
        /// <summary>
        /// Implicitly converts the specified string to an <see cref="ConnectionStatus"/> value.
        /// The string is converted to uppercase and used to initialize the <see cref="ConnectionStatus"/> value.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <returns>An <see cref="ConnectionStatus"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator ConnectionStatus(string value)
            => new ConnectionStatus(value.ToUpperInvariant());
		
    }
}