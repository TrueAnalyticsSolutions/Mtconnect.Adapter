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
	/// A value type for ControllerModeOverride to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.12.0")]
	public partial class ControllerModeOverride : EventValue
    {
		/// <summary>
		/// Constructs a new value type for the ControllerModeOverride EVENT Data Item.
		/// </summary>
        public ControllerModeOverride(string value) : base(value) { }

        /// <summary>
		﻿/// <see cref="ControllerModeOverride">ControllerModeOverride</see> is in the <c>ON</c> state and the mode override is active.
        /// </summary>
		[ObservationalValue(typeof(ControllerModeOverrideValues))]
        public static ControllerModeOverride ON => new ControllerModeOverride(nameof(ControllerModeOverrideValues.ON));
        /// <summary>
		﻿/// <see cref="ControllerModeOverride">ControllerModeOverride</see> is in the <c>OFF</c> state and the mode override is inactive.
        /// </summary>
		[ObservationalValue(typeof(ControllerModeOverrideValues))]
        public static ControllerModeOverride OFF => new ControllerModeOverride(nameof(ControllerModeOverrideValues.OFF));
		
        /// <summary>
        /// Implicitly converts the specified string to an <see cref="ControllerModeOverride"/> value.
        /// The string is converted to uppercase and used to initialize the <see cref="ControllerModeOverride"/> value.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <returns>An <see cref="ControllerModeOverride"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator ControllerModeOverride(string value)
        {
            return new ControllerModeOverride(value.ToUpperInvariant());
        }
		
		/// <summary>
		/// A Data Item SubType implementation of <see cref="ControllerModeOverride" />.
		/// </summary>
		public partial class DRYRUN : ControllerModeOverride
		{
			/// <summary>
			/// Constructs a new value type for DRY_RUN.
			/// </summary>
            public DRYRUN(string value) : base(value) { }
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="ControllerModeOverride" />.
		/// </summary>
		public partial class SINGLEBLOCK : ControllerModeOverride
		{
			/// <summary>
			/// Constructs a new value type for SINGLE_BLOCK.
			/// </summary>
            public SINGLEBLOCK(string value) : base(value) { }
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="ControllerModeOverride" />.
		/// </summary>
		public partial class MACHINEAXISLOCK : ControllerModeOverride
		{
			/// <summary>
			/// Constructs a new value type for MACHINE_AXIS_LOCK.
			/// </summary>
            public MACHINEAXISLOCK(string value) : base(value) { }
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="ControllerModeOverride" />.
		/// </summary>
		public partial class OPTIONALSTOP : ControllerModeOverride
		{
			/// <summary>
			/// Constructs a new value type for OPTIONAL_STOP.
			/// </summary>
            public OPTIONALSTOP(string value) : base(value) { }
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="ControllerModeOverride" />.
		/// </summary>
		public partial class TOOLCHANGESTOP : ControllerModeOverride
		{
			/// <summary>
			/// Constructs a new value type for TOOL_CHANGE_STOP.
			/// </summary>
            public TOOLCHANGESTOP(string value) : base(value) { }
		}
    }
}