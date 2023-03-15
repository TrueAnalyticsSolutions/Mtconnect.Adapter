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
	/// A value type for Program to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.12.0")]
	public partial class Program : EventValue
    {
		/// <summary>
		/// Constructs a new value type for the Program EVENT Data Item.
		/// </summary>
        public Program(string value) : base(value) { }

		
        /// <summary>
        /// Implicitly converts the specified string to an <see cref="Program"/> value.
        /// The string is converted to uppercase and used to initialize the <see cref="Program"/> value.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <returns>An <see cref="Program"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator Program(string value)
        {
            return new Program(value.ToUpperInvariant());
        }
		
		/// <summary>
		/// A Data Item SubType implementation of <see cref="Program" />.
		/// </summary>
		public partial class ACTIVITY : Program
		{
			/// <summary>
			/// Constructs a new value type for ACTIVITY.
			/// </summary>
            public ACTIVITY(string value) : base(value) { }
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="Program" />.
		/// </summary>
		public partial class SEGMENT : Program
		{
			/// <summary>
			/// Constructs a new value type for SEGMENT.
			/// </summary>
            public SEGMENT(string value) : base(value) { }
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="Program" />.
		/// </summary>
		public partial class RECIPE : Program
		{
			/// <summary>
			/// Constructs a new value type for RECIPE.
			/// </summary>
            public RECIPE(string value) : base(value) { }
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="Program" />.
		/// </summary>
		public partial class OPERATION : Program
		{
			/// <summary>
			/// Constructs a new value type for OPERATION.
			/// </summary>
            public OPERATION(string value) : base(value) { }
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="Program" />.
		/// </summary>
		public partial class ACTIVE : Program
		{
			/// <summary>
			/// Constructs a new value type for ACTIVE.
			/// </summary>
            public ACTIVE(string value) : base(value) { }
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="Program" />.
		/// </summary>
		public partial class MAIN : Program
		{
			/// <summary>
			/// Constructs a new value type for MAIN.
			/// </summary>
            public MAIN(string value) : base(value) { }
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="Program" />.
		/// </summary>
		public partial class SCHEDULE : Program
		{
			/// <summary>
			/// Constructs a new value type for SCHEDULE.
			/// </summary>
            public SCHEDULE(string value) : base(value) { }
		}
    }
}