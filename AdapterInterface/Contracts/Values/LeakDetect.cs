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
	/// A value type for LeakDetect to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.12.0")]
	public partial class LeakDetect : EventValue
    {
		/// <summary>
		/// Constructs a new value type for the LeakDetect EVENT Data Item.
		/// </summary>
        public LeakDetect(string value) : base(value) { }

        /// <summary>
		﻿/// leak is currently being detected.
        /// </summary>
		[ObservationalValue(typeof(LeakDetectValues))]
        public static LeakDetect DETECTED => new LeakDetect(nameof(LeakDetectValues.DETECTED));
        /// <summary>
		﻿/// leak is currently not being detected.
        /// </summary>
		[ObservationalValue(typeof(LeakDetectValues))]
        public static LeakDetect NOT_DETECTED => new LeakDetect(nameof(LeakDetectValues.NOT_DETECTED));
		
        /// <summary>
        /// Implicitly converts the specified string to an <see cref="LeakDetect"/> value.
        /// The string is converted to uppercase and used to initialize the <see cref="LeakDetect"/> value.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <returns>An <see cref="LeakDetect"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator LeakDetect(string value)
        {
            return new LeakDetect(value.ToUpperInvariant());
        }
		
    }
}