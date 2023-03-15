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
	/// A value type for ProgramEditName to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.12.0")]
	public partial class ProgramEditName : EventValue
    {
		/// <summary>
		/// Constructs a new value type for the ProgramEditName EVENT Data Item.
		/// </summary>
        public ProgramEditName(string value) : base(value) { }

		
        /// <summary>
        /// Implicitly converts the specified string to an <see cref="ProgramEditName"/> value.
        /// The string is converted to uppercase and used to initialize the <see cref="ProgramEditName"/> value.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <returns>An <see cref="ProgramEditName"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator ProgramEditName(string value)
        {
            return new ProgramEditName(value.ToUpperInvariant());
        }
		
    }
}