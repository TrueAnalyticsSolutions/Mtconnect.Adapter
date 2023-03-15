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
	/// A value type for FunctionalMode to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.12.0")]
	public partial class FunctionalMode : EventValue
    {
		/// <summary>
		/// Constructs a new value type for the FunctionalMode EVENT Data Item.
		/// </summary>
        public FunctionalMode(string value) : base(value) { }

        /// <summary>
		﻿/// <see cref="Component">Component</see> is currently producing product, ready to produce product, or its current intended use is to be producing product.
        /// </summary>
		[ObservationalValue(typeof(FunctionalModeValues))]
        public static FunctionalMode PRODUCTION => new FunctionalMode(nameof(FunctionalModeValues.PRODUCTION));
        /// <summary>
		﻿/// <see cref="Component">Component</see> is not currently producing product.   It is being prepared or modified to begin production of product.
        /// </summary>
		[ObservationalValue(typeof(FunctionalModeValues))]
        public static FunctionalMode SETUP => new FunctionalMode(nameof(FunctionalModeValues.SETUP));
        /// <summary>
		﻿/// <see cref="Component">Component</see> is not currently producing product.  Typically, it has completed the production of a product and is being modified or returned to a neutral state such that it may then be prepared to begin production of a different product.
        /// </summary>
		[ObservationalValue(typeof(FunctionalModeValues))]
        public static FunctionalMode TEARDOWN => new FunctionalMode(nameof(FunctionalModeValues.TEARDOWN));
        /// <summary>
		﻿/// <see cref="Component">Component</see> is not currently producing product.  It is currently being repaired, waiting to be repaired, or has not yet been returned to a normal production status after maintenance has been performed.
        /// </summary>
		[ObservationalValue(typeof(FunctionalModeValues))]
        public static FunctionalMode MAINTENANCE => new FunctionalMode(nameof(FunctionalModeValues.MAINTENANCE));
        /// <summary>
		﻿/// <see cref="Component">Component</see> is being used to prove-out a new process, testing of equipment or processes, or any other active use that does not result in the production of product.
        /// </summary>
		[ObservationalValue(typeof(FunctionalModeValues))]
        public static FunctionalMode PROCESS_DEVELOPMENT => new FunctionalMode(nameof(FunctionalModeValues.PROCESS_DEVELOPMENT));
		
        /// <summary>
        /// Implicitly converts the specified string to an <see cref="FunctionalMode"/> value.
        /// The string is converted to uppercase and used to initialize the <see cref="FunctionalMode"/> value.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <returns>An <see cref="FunctionalMode"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator FunctionalMode(string value)
        {
            return new FunctionalMode(value.ToUpperInvariant());
        }
		
    }
}