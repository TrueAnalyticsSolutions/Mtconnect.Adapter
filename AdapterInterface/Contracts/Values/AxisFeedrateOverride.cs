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
	/// A value type for AxisFeedrateOverride to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.12.0")]
	public partial class AxisFeedrateOverride : EventValue
    {
		/// <summary>
		/// Constructs a new value type for the AxisFeedrateOverride EVENT Data Item.
		/// </summary>
        public AxisFeedrateOverride(string value) : base(value) { }

		
        /// <summary>
        /// Implicitly converts the specified string to an <see cref="AxisFeedrateOverride"/> value.
        /// The string is converted to uppercase and used to initialize the <see cref="AxisFeedrateOverride"/> value.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <returns>An <see cref="AxisFeedrateOverride"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator AxisFeedrateOverride(string value)
        {
            return new AxisFeedrateOverride(value.ToUpperInvariant());
        }
		
		/// <summary>
		/// A Data Item SubType implementation of <see cref="AxisFeedrateOverride" />.
		/// </summary>
		public partial class JOG : AxisFeedrateOverride
		{
			/// <summary>
			/// Constructs a new value type for JOG.
			/// </summary>
            public JOG(string value) : base(value) { }
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="AxisFeedrateOverride" />.
		/// </summary>
		public partial class PROGRAMMED : AxisFeedrateOverride
		{
			/// <summary>
			/// Constructs a new value type for PROGRAMMED.
			/// </summary>
            public PROGRAMMED(string value) : base(value) { }
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="AxisFeedrateOverride" />.
		/// </summary>
		public partial class RAPID : AxisFeedrateOverride
		{
			/// <summary>
			/// Constructs a new value type for RAPID.
			/// </summary>
            public RAPID(string value) : base(value) { }
		}
    }
}