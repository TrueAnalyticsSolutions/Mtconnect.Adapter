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
	/// A value type for ActivationCount to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_91b028d_1579272271512_537408_674">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter; Adapter.ValueType.scriban", "1.0.12.0")]
	public partial class ActivationCount : EventValue
    {
        /// <inheritdoc />
        public override string ObservationalType => nameof(DataItemTypes.EventTypes.ACTIVATION_COUNT);

		/// <inheritdoc />
        public override string ObservationalSubType => null;

		/// <summary>
		/// Constructs a new value type for the ActivationCount EVENT Data Item.
		/// </summary>
        public ActivationCount(Int32? value) : base(value) { }

		
        /// <summary>
        /// Implicitly converts the specified Int32 to an <see cref="ActivationCount"/> value.
        /// The Int32 is converted to uppercase and used to initialize the <see cref="ActivationCount"/> value.
        /// </summary>
        /// <param name="value">The Int32 to convert.</param>
        /// <returns>An <see cref="ActivationCount"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator ActivationCount(Int32? value)
            => new ActivationCount(value);
		
		/// <summary>
		/// A Data Item SubType implementation of <see cref="ActivationCount" />.
		/// </summary>
		public partial class TARGET : ActivationCount
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.ActivationCountSubTypes.TARGET);

			/// <summary>
			/// Constructs a new value type for TARGET.
			/// </summary>
            public TARGET(Int32? value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified Int32 to an <see cref="TARGET"/> value.
			/// The Int32 is converted to uppercase and used to initialize the <see cref="TARGET"/> value.
			/// </summary>
			/// <param name="value">The Int32 to convert.</param>
			/// <returns>An <see cref="TARGET"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator TARGET(Int32? value)
				=> new TARGET(value);
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="ActivationCount" />.
		/// </summary>
		public partial class GOOD : ActivationCount
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.ActivationCountSubTypes.GOOD);

			/// <summary>
			/// Constructs a new value type for GOOD.
			/// </summary>
            public GOOD(Int32? value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified Int32 to an <see cref="GOOD"/> value.
			/// The Int32 is converted to uppercase and used to initialize the <see cref="GOOD"/> value.
			/// </summary>
			/// <param name="value">The Int32 to convert.</param>
			/// <returns>An <see cref="GOOD"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator GOOD(Int32? value)
				=> new GOOD(value);
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="ActivationCount" />.
		/// </summary>
		public partial class BAD : ActivationCount
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.ActivationCountSubTypes.BAD);

			/// <summary>
			/// Constructs a new value type for BAD.
			/// </summary>
            public BAD(Int32? value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified Int32 to an <see cref="BAD"/> value.
			/// The Int32 is converted to uppercase and used to initialize the <see cref="BAD"/> value.
			/// </summary>
			/// <param name="value">The Int32 to convert.</param>
			/// <returns>An <see cref="BAD"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator BAD(Int32? value)
				=> new BAD(value);
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="ActivationCount" />.
		/// </summary>
		public partial class REMAINING : ActivationCount
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.ActivationCountSubTypes.REMAINING);

			/// <summary>
			/// Constructs a new value type for REMAINING.
			/// </summary>
            public REMAINING(Int32? value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified Int32 to an <see cref="REMAINING"/> value.
			/// The Int32 is converted to uppercase and used to initialize the <see cref="REMAINING"/> value.
			/// </summary>
			/// <param name="value">The Int32 to convert.</param>
			/// <returns>An <see cref="REMAINING"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator REMAINING(Int32? value)
				=> new REMAINING(value);
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="ActivationCount" />.
		/// </summary>
		public partial class ABORTED : ActivationCount
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.ActivationCountSubTypes.ABORTED);

			/// <summary>
			/// Constructs a new value type for ABORTED.
			/// </summary>
            public ABORTED(Int32? value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified Int32 to an <see cref="ABORTED"/> value.
			/// The Int32 is converted to uppercase and used to initialize the <see cref="ABORTED"/> value.
			/// </summary>
			/// <param name="value">The Int32 to convert.</param>
			/// <returns>An <see cref="ABORTED"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator ABORTED(Int32? value)
				=> new ABORTED(value);
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="ActivationCount" />.
		/// </summary>
		public partial class FAILED : ActivationCount
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.ActivationCountSubTypes.FAILED);

			/// <summary>
			/// Constructs a new value type for FAILED.
			/// </summary>
            public FAILED(Int32? value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified Int32 to an <see cref="FAILED"/> value.
			/// The Int32 is converted to uppercase and used to initialize the <see cref="FAILED"/> value.
			/// </summary>
			/// <param name="value">The Int32 to convert.</param>
			/// <returns>An <see cref="FAILED"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator FAILED(Int32? value)
				=> new FAILED(value);
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="ActivationCount" />.
		/// </summary>
		public partial class COMPLETE : ActivationCount
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.ActivationCountSubTypes.COMPLETE);

			/// <summary>
			/// Constructs a new value type for COMPLETE.
			/// </summary>
            public COMPLETE(Int32? value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified Int32 to an <see cref="COMPLETE"/> value.
			/// The Int32 is converted to uppercase and used to initialize the <see cref="COMPLETE"/> value.
			/// </summary>
			/// <param name="value">The Int32 to convert.</param>
			/// <returns>An <see cref="COMPLETE"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator COMPLETE(Int32? value)
				=> new COMPLETE(value);
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="ActivationCount" />.
		/// </summary>
		public partial class ALL : ActivationCount
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.ActivationCountSubTypes.ALL);

			/// <summary>
			/// Constructs a new value type for ALL.
			/// </summary>
            public ALL(Int32? value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified Int32 to an <see cref="ALL"/> value.
			/// The Int32 is converted to uppercase and used to initialize the <see cref="ALL"/> value.
			/// </summary>
			/// <param name="value">The Int32 to convert.</param>
			/// <returns>An <see cref="ALL"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator ALL(Int32? value)
				=> new ALL(value);
		}
    }
}