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
	/// A value type for MaterialLayer to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.12.0")]
	public partial class MaterialLayer : EventValue
    {
		/// <summary>
		/// Constructs a new value type for the MaterialLayer EVENT Data Item.
		/// </summary>
        public MaterialLayer(string value) : base(value) { }

		
        /// <summary>
        /// Implicitly converts the specified string to an <see cref="MaterialLayer"/> value.
        /// The string is converted to uppercase and used to initialize the <see cref="MaterialLayer"/> value.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <returns>An <see cref="MaterialLayer"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator MaterialLayer(string value)
        {
            return new MaterialLayer(value.ToUpperInvariant());
        }
		
		/// <summary>
		/// A Data Item SubType implementation of <see cref="MaterialLayer" />.
		/// </summary>
		public partial class ACTUAL : MaterialLayer
		{
			/// <summary>
			/// Constructs a new value type for ACTUAL.
			/// </summary>
            public ACTUAL(string value) : base(value) { }
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="MaterialLayer" />.
		/// </summary>
		public partial class TARGET : MaterialLayer
		{
			/// <summary>
			/// Constructs a new value type for TARGET.
			/// </summary>
            public TARGET(string value) : base(value) { }
		}
    }
}