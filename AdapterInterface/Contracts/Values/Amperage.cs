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
	/// A value type for Amperage to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	[Obsolete("Deprecated according to https://model.mtconnect.org/ in MtconnectVersions.V_1_6_0")]
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.12.0")]
	public partial class Amperage : SampleValue
    {
		/// <summary>
		/// Constructs a new value type for the Amperage EVENT Data Item.
		/// </summary>
        public Amperage(float value) : base(value) { }

		
        /// <summary>
        /// Implicitly converts the specified float to an <see cref="Amperage"/> value.
        /// The float is converted to uppercase and used to initialize the <see cref="Amperage"/> value.
        /// </summary>
        /// <param name="value">The float to convert.</param>
        /// <returns>An <see cref="Amperage"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator Amperage(float value)
        {
            return new Amperage(value);
        }
		
		/// <summary>
		/// A Data Item SubType implementation of <see cref="Amperage" />.
		/// </summary>
		public partial class ALTERNATING : Amperage
		{
			/// <summary>
			/// Constructs a new value type for ALTERNATING.
			/// </summary>
            public ALTERNATING(float value) : base(value) { }
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="Amperage" />.
		/// </summary>
		public partial class DIRECT : Amperage
		{
			/// <summary>
			/// Constructs a new value type for DIRECT.
			/// </summary>
            public DIRECT(float value) : base(value) { }
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="Amperage" />.
		/// </summary>
		public partial class ACTUAL : Amperage
		{
			/// <summary>
			/// Constructs a new value type for ACTUAL.
			/// </summary>
            public ACTUAL(float value) : base(value) { }
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="Amperage" />.
		/// </summary>
		public partial class TARGET : Amperage
		{
			/// <summary>
			/// Constructs a new value type for TARGET.
			/// </summary>
            public TARGET(float value) : base(value) { }
		}
    }
}