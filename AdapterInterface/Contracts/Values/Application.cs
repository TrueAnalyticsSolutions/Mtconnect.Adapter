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
	/// A value type for Application to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.12.0")]
	public partial class Application : EventValue
    {
		/// <summary>
		/// Constructs a new value type for the Application EVENT Data Item.
		/// </summary>
        public Application(string value) : base(value) { }

		
        /// <summary>
        /// Implicitly converts the specified string to an <see cref="Application"/> value.
        /// The string is converted to uppercase and used to initialize the <see cref="Application"/> value.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <returns>An <see cref="Application"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator Application(string value)
        {
            return new Application(value.ToUpperInvariant());
        }
		
		/// <summary>
		/// A Data Item SubType implementation of <see cref="Application" />.
		/// </summary>
		public partial class VERSION : Application
		{
			/// <summary>
			/// Constructs a new value type for VERSION.
			/// </summary>
            public VERSION(string value) : base(value) { }
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="Application" />.
		/// </summary>
		public partial class RELEASEDATE : Application
		{
			/// <summary>
			/// Constructs a new value type for RELEASE_DATE.
			/// </summary>
            public RELEASEDATE(string value) : base(value) { }
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="Application" />.
		/// </summary>
		public partial class MANUFACTURER : Application
		{
			/// <summary>
			/// Constructs a new value type for MANUFACTURER.
			/// </summary>
            public MANUFACTURER(string value) : base(value) { }
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="Application" />.
		/// </summary>
		public partial class LICENSE : Application
		{
			/// <summary>
			/// Constructs a new value type for LICENSE.
			/// </summary>
            public LICENSE(string value) : base(value) { }
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="Application" />.
		/// </summary>
		public partial class INSTALLDATE : Application
		{
			/// <summary>
			/// Constructs a new value type for INSTALL_DATE.
			/// </summary>
            public INSTALLDATE(string value) : base(value) { }
		}
    }
}