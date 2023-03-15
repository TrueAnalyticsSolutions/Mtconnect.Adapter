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
	/// A value type for FollowingErrorLinear to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.12.0")]
	public partial class FollowingErrorLinear : SampleValue
    {
		/// <summary>
		/// Constructs a new value type for the FollowingErrorLinear EVENT Data Item.
		/// </summary>
        public FollowingErrorLinear(float value) : base(value) { }

		
        /// <summary>
        /// Implicitly converts the specified float to an <see cref="FollowingErrorLinear"/> value.
        /// The float is converted to uppercase and used to initialize the <see cref="FollowingErrorLinear"/> value.
        /// </summary>
        /// <param name="value">The float to convert.</param>
        /// <returns>An <see cref="FollowingErrorLinear"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator FollowingErrorLinear(float value)
        {
            return new FollowingErrorLinear(value);
        }
		
		/// <summary>
		/// A Data Item SubType implementation of <see cref="FollowingErrorLinear" />.
		/// </summary>
		public partial class ACTUAL : FollowingErrorLinear
		{
			/// <summary>
			/// Constructs a new value type for ACTUAL.
			/// </summary>
            public ACTUAL(float value) : base(value) { }
		}
    }
}