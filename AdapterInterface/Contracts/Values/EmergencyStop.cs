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
	/// A value type for EmergencyStop to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.12.0")]
	public partial class EmergencyStop : EventValue
    {
		/// <summary>
		/// Constructs a new value type for the EmergencyStop EVENT Data Item.
		/// </summary>
        public EmergencyStop(string value) : base(value) { }

        /// <summary>
		﻿/// emergency stop circuit is complete and the piece of equipment, component, or composition is allowed to operate. 
        /// </summary>
		[ObservationalValue(typeof(EmergencyStopValues))]
        public static EmergencyStop ARMED => new EmergencyStop(nameof(EmergencyStopValues.ARMED));
        /// <summary>
		﻿/// operation of the piece of equipment, component, or composition is inhibited.
        /// </summary>
		[ObservationalValue(typeof(EmergencyStopValues))]
        public static EmergencyStop TRIGGERED => new EmergencyStop(nameof(EmergencyStopValues.TRIGGERED));
		
        /// <summary>
        /// Implicitly converts the specified string to an <see cref="EmergencyStop"/> value.
        /// The string is converted to uppercase and used to initialize the <see cref="EmergencyStop"/> value.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <returns>An <see cref="EmergencyStop"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator EmergencyStop(string value)
        {
            return new EmergencyStop(value.ToUpperInvariant());
        }
		
    }
}