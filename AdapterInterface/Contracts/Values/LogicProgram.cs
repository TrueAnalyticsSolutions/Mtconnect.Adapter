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
	/// A value type for LogicProgram to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.12.0")]
	public partial class LogicProgram : ConditionValue
    {
		/// <summary>
		/// Constructs a new value type for the LogicProgram EVENT Data Item.
		/// </summary>
        public LogicProgram(Condition value) : base(value) { }

		
        /// <summary>
        /// Implicitly converts the specified Condition to an <see cref="LogicProgram"/> value.
        /// The Condition is converted to uppercase and used to initialize the <see cref="LogicProgram"/> value.
        /// </summary>
        /// <param name="value">The Condition to convert.</param>
        /// <returns>An <see cref="LogicProgram"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator LogicProgram(Condition value)
        {
            return new LogicProgram(value);
        }
		
    }
}