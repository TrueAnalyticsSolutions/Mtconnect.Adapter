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
	/// A value type for DepositionAccelerationVolumetric to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
	/// <item><b>Units</b>: <see cref="MtconnectUnit.CUBIC_MILLIMETER_PER_SECOND_SQUARED" /></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter; Adapter.ValueType.scriban", "1.0.12.0")]
	public partial class DepositionAccelerationVolumetric : SampleValue
    {
        /// <inheritdoc />
        public override string ObservationalType => nameof(DataItemTypes.SampleTypes.DEPOSITION_ACCELERATION_VOLUMETRIC);

		/// <inheritdoc />
        public override string ObservationalSubType => null;

		/// <summary>
		/// Constructs a new value type for the DepositionAccelerationVolumetric EVENT Data Item.
		/// </summary>
        public DepositionAccelerationVolumetric(float? value) : base(value) { }

		
        /// <summary>
        /// Implicitly converts the specified float? to an <see cref="DepositionAccelerationVolumetric"/> value.
        /// The float? is converted to uppercase and used to initialize the <see cref="DepositionAccelerationVolumetric"/> value.
        /// </summary>
        /// <param name="value">The float? to convert.</param>
        /// <returns>An <see cref="DepositionAccelerationVolumetric"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator DepositionAccelerationVolumetric(float? value)
            => new DepositionAccelerationVolumetric(value);
		
		/// <summary>
		/// A Data Item SubType implementation of <see cref="DepositionAccelerationVolumetric" />.
		/// </summary>
		public partial class ACTUAL : DepositionAccelerationVolumetric
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.DepositionAccelerationVolumetricSubTypes.ACTUAL);

			/// <summary>
			/// Constructs a new value type for ACTUAL.
			/// </summary>
            public ACTUAL(float? value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified float? to an <see cref="ACTUAL"/> value.
			/// The float? is converted to uppercase and used to initialize the <see cref="ACTUAL"/> value.
			/// </summary>
			/// <param name="value">The float? to convert.</param>
			/// <returns>An <see cref="ACTUAL"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator ACTUAL(float? value)
				=> new ACTUAL(value);
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="DepositionAccelerationVolumetric" />.
		/// </summary>
		public partial class COMMANDED : DepositionAccelerationVolumetric
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.DepositionAccelerationVolumetricSubTypes.COMMANDED);

			/// <summary>
			/// Constructs a new value type for COMMANDED.
			/// </summary>
            public COMMANDED(float? value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified float? to an <see cref="COMMANDED"/> value.
			/// The float? is converted to uppercase and used to initialize the <see cref="COMMANDED"/> value.
			/// </summary>
			/// <param name="value">The float? to convert.</param>
			/// <returns>An <see cref="COMMANDED"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator COMMANDED(float? value)
				=> new COMMANDED(value);
		}
    }
}