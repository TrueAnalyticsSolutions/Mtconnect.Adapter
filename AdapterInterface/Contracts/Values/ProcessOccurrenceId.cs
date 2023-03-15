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
	/// A value type for ProcessOccurrenceId to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.12.0")]
	public partial class ProcessOccurrenceId : EventValue
    {
		/// <summary>
		/// Constructs a new value type for the ProcessOccurrenceId EVENT Data Item.
		/// </summary>
        public ProcessOccurrenceId(string value) : base(value) { }

		
        /// <summary>
        /// Implicitly converts the specified string to an <see cref="ProcessOccurrenceId"/> value.
        /// The string is converted to uppercase and used to initialize the <see cref="ProcessOccurrenceId"/> value.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <returns>An <see cref="ProcessOccurrenceId"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator ProcessOccurrenceId(string value)
        {
            return new ProcessOccurrenceId(value.ToUpperInvariant());
        }
		
		/// <summary>
		/// A Data Item SubType implementation of <see cref="ProcessOccurrenceId" />.
		/// </summary>
		public partial class ACTIVITY : ProcessOccurrenceId
		{
			/// <summary>
			/// Constructs a new value type for ACTIVITY.
			/// </summary>
            public ACTIVITY(string value) : base(value) { }
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="ProcessOccurrenceId" />.
		/// </summary>
		public partial class SEGMENT : ProcessOccurrenceId
		{
			/// <summary>
			/// Constructs a new value type for SEGMENT.
			/// </summary>
            public SEGMENT(string value) : base(value) { }
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="ProcessOccurrenceId" />.
		/// </summary>
		public partial class RECIPE : ProcessOccurrenceId
		{
			/// <summary>
			/// Constructs a new value type for RECIPE.
			/// </summary>
            public RECIPE(string value) : base(value) { }
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="ProcessOccurrenceId" />.
		/// </summary>
		public partial class OPERATION : ProcessOccurrenceId
		{
			/// <summary>
			/// Constructs a new value type for OPERATION.
			/// </summary>
            public OPERATION(string value) : base(value) { }
		}
    }
}