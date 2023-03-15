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
	/// A value type for PathPosition to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.12.0")]
	public partial class PathPosition : SampleValue
    {
		/// <summary>
		/// Constructs a new value type for the PathPosition EVENT Data Item.
		/// </summary>
        public PathPosition(float value) : base(value) { }

		
        /// <summary>
        /// Implicitly converts the specified float to an <see cref="PathPosition"/> value.
        /// The float is converted to uppercase and used to initialize the <see cref="PathPosition"/> value.
        /// </summary>
        /// <param name="value">The float to convert.</param>
        /// <returns>An <see cref="PathPosition"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator PathPosition(float value)
        {
            return new PathPosition(value);
        }
		
		/// <summary>
		/// A Data Item SubType implementation of <see cref="PathPosition" />.
		/// </summary>
		public partial class ACTUAL : PathPosition
		{
			/// <summary>
			/// Constructs a new value type for ACTUAL.
			/// </summary>
            public ACTUAL(float value) : base(value) { }
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="PathPosition" />.
		/// </summary>
		public partial class COMMANDED : PathPosition
		{
			/// <summary>
			/// Constructs a new value type for COMMANDED.
			/// </summary>
            public COMMANDED(float value) : base(value) { }
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="PathPosition" />.
		/// </summary>
		public partial class TARGET : PathPosition
		{
			/// <summary>
			/// Constructs a new value type for TARGET.
			/// </summary>
            public TARGET(float value) : base(value) { }
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="PathPosition" />.
		/// </summary>
		public partial class PROBE : PathPosition
		{
			/// <summary>
			/// Constructs a new value type for PROBE.
			/// </summary>
            public PROBE(float value) : base(value) { }
		}
    }
}