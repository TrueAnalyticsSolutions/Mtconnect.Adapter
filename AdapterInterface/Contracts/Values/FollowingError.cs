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
	/// A value type for FollowingError to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.12.0")]
	public partial class FollowingError : SampleValue
    {
		/// <summary>
		/// Constructs a new value type for the FollowingError EVENT Data Item.
		/// </summary>
        public FollowingError(float value) : base(value) { }

		
        /// <summary>
        /// Implicitly converts the specified float to an <see cref="FollowingError"/> value.
        /// The float is converted to uppercase and used to initialize the <see cref="FollowingError"/> value.
        /// </summary>
        /// <param name="value">The float to convert.</param>
        /// <returns>An <see cref="FollowingError"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator FollowingError(float value)
        {
            return new FollowingError(value);
        }
		
		/// <summary>
		/// A Data Item SubType implementation of <see cref="FollowingError" />.
		/// </summary>
		public partial class ACTUAL : FollowingError
		{
			/// <summary>
			/// Constructs a new value type for ACTUAL.
			/// </summary>
            public ACTUAL(float value) : base(value) { }
		}
    }
}