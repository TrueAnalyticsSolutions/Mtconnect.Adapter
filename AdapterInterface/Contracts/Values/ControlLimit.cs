#pragma warning disable 0618
#pragma warning disable 1574
using System;
using System.CodeDom.Compiler;
using Mtconnect.AdapterInterface.Contracts.Attributes;
using Mtconnect.AdapterInterface.Contracts;
using Mtconnect.AdapterInterface.DataItems;
using Mtconnect.AdapterInterface.DataItemValues;
using Mtconnect.AdapterInterface.Units;

namespace Mtconnect.AdapterInterface.DataItemValues
{
	/// <summary>
	/// A value type for ControlLimit to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1620206731259_178927_703">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "1.0.7.0")]
	public partial class ControlLimit : EventValue
    {
        /// <inheritdoc />
        public override string ObservationalType => nameof(DataItemTypes.EventTypes.CONTROL_LIMIT);

		/// <inheritdoc />
        public override string ObservationalSubType => null;

		/// <summary>
		/// Constructs a new value type for the ControlLimit EVENT Data Item.
		/// </summary>
        public ControlLimit(string value) : base(value) { }

		
        /// <summary>
        /// Implicitly converts the specified string to an <see cref="ControlLimit"/> value.
        /// The string is converted to uppercase and used to initialize the <see cref="ControlLimit"/> value.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <returns>An <see cref="ControlLimit"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator ControlLimit(string value)
            => new ControlLimit(value.ToUpperInvariant());
		
    }
}