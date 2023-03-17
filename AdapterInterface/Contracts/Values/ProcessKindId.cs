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
	/// A value type for ProcessKindId to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.14.0")]
	public partial class ProcessKindId : EventValue
    {
		/// <summary>
		/// Constructs a new value type for the ProcessKindId EVENT Data Item.
		/// </summary>
        public ProcessKindId(string value) : base(value) { }

		
        /// <summary>
        /// Implicitly converts the specified string to an <see cref="ProcessKindId"/> value.
        /// The string is converted to uppercase and used to initialize the <see cref="ProcessKindId"/> value.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <returns>An <see cref="ProcessKindId"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator ProcessKindId(string value)
            => new ProcessKindId(value.ToUpperInvariant());
		
		/// <summary>
		/// A Data Item SubType implementation of <see cref="ProcessKindId" />.
		/// </summary>
		public partial class UUID : ProcessKindId
		{
			/// <summary>
			/// Constructs a new value type for UUID.
			/// </summary>
            public UUID(string value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified string to an <see cref="UUID"/> value.
			/// The string is converted to uppercase and used to initialize the <see cref="UUID"/> value.
			/// </summary>
			/// <param name="value">The string to convert.</param>
			/// <returns>An <see cref="UUID"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator UUID(string value)
				=> new UUID(value.ToUpperInvariant());
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="ProcessKindId" />.
		/// </summary>
		public partial class ISOSTEPEXECUTABLE : ProcessKindId
		{
			/// <summary>
			/// Constructs a new value type for I_S_O_STEP_EXECUTABLE.
			/// </summary>
            public ISOSTEPEXECUTABLE(string value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified string to an <see cref="ISOSTEPEXECUTABLE"/> value.
			/// The string is converted to uppercase and used to initialize the <see cref="ISOSTEPEXECUTABLE"/> value.
			/// </summary>
			/// <param name="value">The string to convert.</param>
			/// <returns>An <see cref="ISOSTEPEXECUTABLE"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator ISOSTEPEXECUTABLE(string value)
				=> new ISOSTEPEXECUTABLE(value.ToUpperInvariant());
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="ProcessKindId" />.
		/// </summary>
		public partial class PROCESSNAME : ProcessKindId
		{
			/// <summary>
			/// Constructs a new value type for PROCESS_NAME.
			/// </summary>
            public PROCESSNAME(string value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified string to an <see cref="PROCESSNAME"/> value.
			/// The string is converted to uppercase and used to initialize the <see cref="PROCESSNAME"/> value.
			/// </summary>
			/// <param name="value">The string to convert.</param>
			/// <returns>An <see cref="PROCESSNAME"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator PROCESSNAME(string value)
				=> new PROCESSNAME(value.ToUpperInvariant());
		}
    }
}