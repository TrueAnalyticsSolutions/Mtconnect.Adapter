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
	/// A value type for PressurizationRate to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.12.0")]
	public partial class PressurizationRate : SampleValue
    {
		/// <summary>
		/// Constructs a new value type for the PressurizationRate EVENT Data Item.
		/// </summary>
        public PressurizationRate(float value) : base(value) { }

		
        /// <summary>
        /// Implicitly converts the specified float to an <see cref="PressurizationRate"/> value.
        /// The float is converted to uppercase and used to initialize the <see cref="PressurizationRate"/> value.
        /// </summary>
        /// <param name="value">The float to convert.</param>
        /// <returns>An <see cref="PressurizationRate"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator PressurizationRate(float value)
        {
            return new PressurizationRate(value);
        }
		
		/// <summary>
		/// A Data Item SubType implementation of <see cref="PressurizationRate" />.
		/// </summary>
		public partial class COMMANDED : PressurizationRate
		{
			/// <summary>
			/// Constructs a new value type for COMMANDED.
			/// </summary>
            public COMMANDED(float value) : base(value) { }
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="PressurizationRate" />.
		/// </summary>
		public partial class ACTUAL : PressurizationRate
		{
			/// <summary>
			/// Constructs a new value type for ACTUAL.
			/// </summary>
            public ACTUAL(float value) : base(value) { }
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="PressurizationRate" />.
		/// </summary>
		public partial class PROGRAMMED : PressurizationRate
		{
			/// <summary>
			/// Constructs a new value type for PROGRAMMED.
			/// </summary>
            public PROGRAMMED(float value) : base(value) { }
		}
    }
}