#pragma warning disable 0618
#pragma warning disable 1574
#pragma warning disable CS1574
using System;
using System.CodeDom.Compiler;
using Mtconnect.AdapterSdk;
using Mtconnect.AdapterSdk.Attributes;
using Mtconnect.AdapterSdk.DataItems;
using Mtconnect.AdapterSdk.DataItemValues;
using Mtconnect.AdapterSdk.Units;

namespace Mtconnect.AdapterSdk.DataItemValues
{
	/// <summary>
	/// A value type for Communications to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter; Adapter.ValueType.scriban", "1.0.12.0")]
	public partial class Communications : ConditionValue
    {
        /// <inheritdoc />
        public override string ObservationalType => nameof(DataItemTypes.ConditionTypes.COMMUNICATIONS);

		/// <inheritdoc />
        public override string ObservationalSubType => null;

		/// <summary>
		/// Constructs a new value type for the Communications EVENT Data Item.
		/// </summary>
        public Communications(Condition value) : base(value) { }

		
        /// <summary>
        /// Implicitly converts the specified Condition to an <see cref="Communications"/> value.
        /// The Condition is converted to uppercase and used to initialize the <see cref="Communications"/> value.
        /// </summary>
        /// <param name="value">The Condition to convert.</param>
        /// <returns>An <see cref="Communications"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator Communications(Condition value)
            => new Communications(value);
		
    }
}