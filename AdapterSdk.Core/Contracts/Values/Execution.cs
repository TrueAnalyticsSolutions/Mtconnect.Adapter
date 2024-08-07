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
	/// A value type for Execution to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580378417664_592980_2878">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter; Adapter.ValueType.scriban", "1.0.12.0")]
	public partial class Execution : EventValue
    {
        /// <inheritdoc />
        public override string ObservationalType => nameof(DataItemTypes.EventTypes.EXECUTION);

		/// <inheritdoc />
        public override string ObservationalSubType => null;

		/// <summary>
		/// Constructs a new value type for the Execution EVENT Data Item.
		/// </summary>
        public Execution(string value) : base(value) { }

		/// <summary>
		/// Constructs a new value type for the Execution EVENT Data Item.
		/// </summary>
		public Execution(ExecutionValues value) : this(value.ToString()) { }

		/// <inheritdoc cref="ExecutionValues.READY" />
		[ObservationalValue(typeof(ExecutionValues))]
        public static Execution READY => new Execution(ExecutionValues.READY);
		/// <inheritdoc cref="ExecutionValues.ACTIVE" />
		[ObservationalValue(typeof(ExecutionValues))]
        public static Execution ACTIVE => new Execution(ExecutionValues.ACTIVE);
		/// <inheritdoc cref="ExecutionValues.INTERRUPTED" />
		[ObservationalValue(typeof(ExecutionValues))]
        public static Execution INTERRUPTED => new Execution(ExecutionValues.INTERRUPTED);
		/// <inheritdoc cref="ExecutionValues.FEED_HOLD" />
		[ObservationalValue(typeof(ExecutionValues))]
        public static Execution FEED_HOLD => new Execution(ExecutionValues.FEED_HOLD);
		/// <inheritdoc cref="ExecutionValues.STOPPED" />
		[ObservationalValue(typeof(ExecutionValues))]
        public static Execution STOPPED => new Execution(ExecutionValues.STOPPED);
		/// <inheritdoc cref="ExecutionValues.OPTIONAL_STOP" />
		[ObservationalValue(typeof(ExecutionValues))]
        public static Execution OPTIONAL_STOP => new Execution(ExecutionValues.OPTIONAL_STOP);
		/// <inheritdoc cref="ExecutionValues.PROGRAM_STOPPED" />
		[ObservationalValue(typeof(ExecutionValues))]
        public static Execution PROGRAM_STOPPED => new Execution(ExecutionValues.PROGRAM_STOPPED);
		/// <inheritdoc cref="ExecutionValues.PROGRAM_COMPLETED" />
		[ObservationalValue(typeof(ExecutionValues))]
        public static Execution PROGRAM_COMPLETED => new Execution(ExecutionValues.PROGRAM_COMPLETED);
		/// <inheritdoc cref="ExecutionValues.WAIT" />
		[ObservationalValue(typeof(ExecutionValues))]
        public static Execution WAIT => new Execution(ExecutionValues.WAIT);

        /// <summary>
        /// Implicitly converts the specified <see cref="ExecutionValues" /> to an <see cref="Execution"/> value.
        /// The <see cref="ExecutionValues" /> is converted to a string and used to initialize the <see cref="Execution"/> value.
        /// </summary>
        /// <param name="value">The <see cref="ExecutionValues" /> to convert.</param>
        /// <returns>An <see cref="Execution"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator Execution(ExecutionValues value)
            => new Execution(value);
		
        /// <summary>
        /// Implicitly converts the specified string to an <see cref="Execution"/> value.
        /// The string is converted to uppercase and used to initialize the <see cref="Execution"/> value.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <returns>An <see cref="Execution"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator Execution(string value)
            => new Execution(value.ToUpperInvariant());
		
    }
}