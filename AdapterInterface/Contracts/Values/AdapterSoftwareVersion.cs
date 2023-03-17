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
	/// A value type for AdapterSoftwareVersion to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.14.0")]
	public partial class AdapterSoftwareVersion : EventValue
    {
		/// <summary>
		/// Constructs a new value type for the AdapterSoftwareVersion EVENT Data Item.
		/// </summary>
        public AdapterSoftwareVersion(string value) : base(value) { }

		
        /// <summary>
        /// Implicitly converts the specified string to an <see cref="AdapterSoftwareVersion"/> value.
        /// The string is converted to uppercase and used to initialize the <see cref="AdapterSoftwareVersion"/> value.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <returns>An <see cref="AdapterSoftwareVersion"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator AdapterSoftwareVersion(string value)
            => new AdapterSoftwareVersion(value.ToUpperInvariant());
		
    }
}