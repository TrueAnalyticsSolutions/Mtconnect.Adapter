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
	/// A value type for PositionCartesian to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_91b028d_1579272506322_914606_702">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
	/// <item><b>Units</b>: <see cref="MtconnectUnit.MILLIMETER_3D" /></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter; Adapter.ValueType.scriban", "1.0.12.0")]
	public partial class PositionCartesian : Sample3DValue
    {
        /// <inheritdoc />
        public override string ObservationalType => nameof(DataItemTypes.SampleTypes.POSITION_CARTESIAN);

		/// <inheritdoc />
        public override string ObservationalSubType => null;

		/// <summary>
		/// Constructs a new value type for the PositionCartesian EVENT Data Item.
		/// </summary>
        public PositionCartesian(float?[] value) : base(value) { }

		
        /// <summary>
        /// Implicitly converts the specified float?[] to an <see cref="PositionCartesian"/> value.
        /// The float?[] is converted to uppercase and used to initialize the <see cref="PositionCartesian"/> value.
        /// </summary>
        /// <param name="value">The float?[] to convert.</param>
        /// <returns>An <see cref="PositionCartesian"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator PositionCartesian(float?[] value)
            => new PositionCartesian(value);
		
    }
}