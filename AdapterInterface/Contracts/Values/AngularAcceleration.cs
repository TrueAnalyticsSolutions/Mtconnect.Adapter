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
	/// A value type for AngularAcceleration to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.12.0")]
	public partial class AngularAcceleration : SampleValue
    {
		/// <summary>
		/// Constructs a new value type for the AngularAcceleration EVENT Data Item.
		/// </summary>
        public AngularAcceleration(float value) : base(value) { }

		
        /// <summary>
        /// Implicitly converts the specified float to an <see cref="AngularAcceleration"/> value.
        /// The float is converted to uppercase and used to initialize the <see cref="AngularAcceleration"/> value.
        /// </summary>
        /// <param name="value">The float to convert.</param>
        /// <returns>An <see cref="AngularAcceleration"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator AngularAcceleration(float value)
        {
            return new AngularAcceleration(value);
        }
		
		/// <summary>
		/// A Data Item SubType implementation of <see cref="AngularAcceleration" />.
		/// </summary>
		public partial class PROGRAMMED : AngularAcceleration
		{
			/// <summary>
			/// Constructs a new value type for PROGRAMMED.
			/// </summary>
            public PROGRAMMED(float value) : base(value) { }
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="AngularAcceleration" />.
		/// </summary>
		public partial class ACTUAL : AngularAcceleration
		{
			/// <summary>
			/// Constructs a new value type for ACTUAL.
			/// </summary>
            public ACTUAL(float value) : base(value) { }
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="AngularAcceleration" />.
		/// </summary>
		public partial class COMMANDED : AngularAcceleration
		{
			/// <summary>
			/// Constructs a new value type for COMMANDED.
			/// </summary>
            public COMMANDED(float value) : base(value) { }
		}
    }
}