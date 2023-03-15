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
	/// A value type for Line to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	[Obsolete("Deprecated according to https://model.mtconnect.org/ in MtconnectVersions.V_1_4_0")]
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.12.0")]
	public partial class Line : EventValue
    {
		/// <summary>
		/// Constructs a new value type for the Line EVENT Data Item.
		/// </summary>
        public Line(string value) : base(value) { }

		
        /// <summary>
        /// Implicitly converts the specified string to an <see cref="Line"/> value.
        /// The string is converted to uppercase and used to initialize the <see cref="Line"/> value.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <returns>An <see cref="Line"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator Line(string value)
        {
            return new Line(value.ToUpperInvariant());
        }
		
		/// <summary>
		/// A Data Item SubType implementation of <see cref="Line" />.
		/// </summary>
		public partial class MAXIMUM : Line
		{
			/// <summary>
			/// Constructs a new value type for MAXIMUM.
			/// </summary>
            public MAXIMUM(string value) : base(value) { }
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="Line" />.
		/// </summary>
		public partial class MINIMUM : Line
		{
			/// <summary>
			/// Constructs a new value type for MINIMUM.
			/// </summary>
            public MINIMUM(string value) : base(value) { }
		}
    }
}