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
	/// A value type for AxisCoupling to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.14.0")]
	public partial class AxisCoupling : EventValue
    {
		/// <summary>
		/// Constructs a new value type for the AxisCoupling EVENT Data Item.
		/// </summary>
        public AxisCoupling(string value) : base(value) { }

        /// <summary>
		﻿/// axes are physically connected to each other and operate as a single unit.
        /// </summary>
		[ObservationalValue(typeof(AxisCouplingValues))]
        public static AxisCoupling TANDEM => new AxisCoupling(nameof(AxisCouplingValues.TANDEM));
        /// <summary>
		﻿/// axes are not physically connected to each other but are operating together in lockstep.
        /// </summary>
		[ObservationalValue(typeof(AxisCouplingValues))]
        public static AxisCoupling SYNCHRONOUS => new AxisCoupling(nameof(AxisCouplingValues.SYNCHRONOUS));
        /// <summary>
		﻿/// axis is the master of the <see cref="CoupledAxes">CoupledAxes</see>.
        /// </summary>
		[ObservationalValue(typeof(AxisCouplingValues))]
        public static AxisCoupling MASTER => new AxisCoupling(nameof(AxisCouplingValues.MASTER));
        /// <summary>
		﻿/// axis is a slave to the <see cref="CoupledAxes">CoupledAxes</see>.
        /// </summary>
		[ObservationalValue(typeof(AxisCouplingValues))]
        public static AxisCoupling SLAVE => new AxisCoupling(nameof(AxisCouplingValues.SLAVE));
		
        /// <summary>
        /// Implicitly converts the specified string to an <see cref="AxisCoupling"/> value.
        /// The string is converted to uppercase and used to initialize the <see cref="AxisCoupling"/> value.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <returns>An <see cref="AxisCoupling"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator AxisCoupling(string value)
            => new AxisCoupling(value.ToUpperInvariant());
		
    }
}