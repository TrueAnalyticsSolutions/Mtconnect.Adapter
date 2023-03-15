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
	/// A value type for LockState to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.12.0")]
	public partial class LockState : EventValue
    {
		/// <summary>
		/// Constructs a new value type for the LockState EVENT Data Item.
		/// </summary>
        public LockState(string value) : base(value) { }

        /// <summary>
		﻿/// mechanism is engaged and preventing the associated <see cref="Component">Component</see> from being opened or operated.
        /// </summary>
		[ObservationalValue(typeof(LockStateValues))]
        public static LockState LOCKED => new LockState(nameof(LockStateValues.LOCKED));
        /// <summary>
		﻿/// mechanism is disengaged and the associated <see cref="Component">Component</see> is able to be opened or operated.
        /// </summary>
		[ObservationalValue(typeof(LockStateValues))]
        public static LockState UNLOCKED => new LockState(nameof(LockStateValues.UNLOCKED));
		
        /// <summary>
        /// Implicitly converts the specified string to an <see cref="LockState"/> value.
        /// The string is converted to uppercase and used to initialize the <see cref="LockState"/> value.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <returns>An <see cref="LockState"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator LockState(string value)
        {
            return new LockState(value.ToUpperInvariant());
        }
		
    }
}