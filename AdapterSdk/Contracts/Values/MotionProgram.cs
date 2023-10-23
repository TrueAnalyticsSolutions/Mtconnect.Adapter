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
	/// A value type for MotionProgram to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter; Adapter.ValueType.scriban", "1.0.12.0")]
	public partial class MotionProgram : ConditionValue
    {
        /// <inheritdoc />
        public override string ObservationalType => nameof(DataItemTypes.ConditionTypes.MOTION_PROGRAM);

		/// <inheritdoc />
        public override string ObservationalSubType => null;

		/// <summary>
		/// Constructs a new value type for the MotionProgram EVENT Data Item.
		/// </summary>
        public MotionProgram(Condition value) : base(value) { }

		
        /// <summary>
        /// Implicitly converts the specified Condition to an <see cref="MotionProgram"/> value.
        /// The Condition is converted to uppercase and used to initialize the <see cref="MotionProgram"/> value.
        /// </summary>
        /// <param name="value">The Condition to convert.</param>
        /// <returns>An <see cref="MotionProgram"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator MotionProgram(Condition value)
            => new MotionProgram(value);
		
    }
}