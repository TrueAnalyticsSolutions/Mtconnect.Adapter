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
	/// A value type for Orientation to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.12.0")]
	public partial class Orientation : SampleValue
    {
		/// <summary>
		/// Constructs a new value type for the Orientation EVENT Data Item.
		/// </summary>
        public Orientation(float value) : base(value) { }

		
        /// <summary>
        /// Implicitly converts the specified float to an <see cref="Orientation"/> value.
        /// The float is converted to uppercase and used to initialize the <see cref="Orientation"/> value.
        /// </summary>
        /// <param name="value">The float to convert.</param>
        /// <returns>An <see cref="Orientation"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator Orientation(float value)
        {
            return new Orientation(value);
        }
		
		/// <summary>
		/// A Data Item SubType implementation of <see cref="Orientation" />.
		/// </summary>
		public partial class ACTUAL : Orientation
		{
			/// <summary>
			/// Constructs a new value type for ACTUAL.
			/// </summary>
            public ACTUAL(float value) : base(value) { }
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="Orientation" />.
		/// </summary>
		public partial class COMMANDED : Orientation
		{
			/// <summary>
			/// Constructs a new value type for COMMANDED.
			/// </summary>
            public COMMANDED(float value) : base(value) { }
		}
    }
}