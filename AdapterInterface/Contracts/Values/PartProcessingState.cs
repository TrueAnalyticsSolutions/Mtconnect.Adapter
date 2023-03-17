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
	/// A value type for PartProcessingState to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.14.0")]
	public partial class PartProcessingState : EventValue
    {
		/// <summary>
		/// Constructs a new value type for the PartProcessingState EVENT Data Item.
		/// </summary>
        public PartProcessingState(string value) : base(value) { }

        /// <summary>
		﻿/// part occurrence is not actively being processed, but the processing has not ended.   Processing requirements exist that have not yet been fulfilled. This is the default entry state when the part occurrence is originally received. In some cases, the part occurrence may return to this state while it waits for additional processing to be performed.
        /// </summary>
		[ObservationalValue(typeof(PartProcessingStateValues))]
        public static PartProcessingState NEEDS_PROCESSING => new PartProcessingState(nameof(PartProcessingStateValues.NEEDS_PROCESSING));
        /// <summary>
		﻿/// part occurrence is actively being processed.
        /// </summary>
		[ObservationalValue(typeof(PartProcessingStateValues))]
        public static PartProcessingState IN_PROCESS => new PartProcessingState(nameof(PartProcessingStateValues.IN_PROCESS));
        /// <summary>
		﻿/// part occurrence is no longer being processed.   A general state when the reason for termination is unknown.
        /// </summary>
		[ObservationalValue(typeof(PartProcessingStateValues))]
        public static PartProcessingState PROCESSING_ENDED => new PartProcessingState(nameof(PartProcessingStateValues.PROCESSING_ENDED));
        /// <summary>
		﻿/// part occurrence has completed processing successfully.
        /// </summary>
		[ObservationalValue(typeof(PartProcessingStateValues))]
        public static PartProcessingState PROCESSING_ENDED_COMPLETE => new PartProcessingState(nameof(PartProcessingStateValues.PROCESSING_ENDED_COMPLETE));
        /// <summary>
		﻿/// process has been stopped during the processing.   The part occurrence will require special treatment.
        /// </summary>
		[ObservationalValue(typeof(PartProcessingStateValues))]
        public static PartProcessingState PROCESSING_ENDED_STOPPED => new PartProcessingState(nameof(PartProcessingStateValues.PROCESSING_ENDED_STOPPED));
        /// <summary>
		﻿/// processing of the part occurrence has come to a premature end.
        /// </summary>
		[ObservationalValue(typeof(PartProcessingStateValues))]
        public static PartProcessingState PROCESSING_ENDED_ABORTED => new PartProcessingState(nameof(PartProcessingStateValues.PROCESSING_ENDED_ABORTED));
        /// <summary>
		﻿/// terminal state when the part occurrence has been removed from the equipment by an external entity and it no longer exists at the equipment.
        /// </summary>
		[ObservationalValue(typeof(PartProcessingStateValues))]
        public static PartProcessingState PROCESSING_ENDED_LOST => new PartProcessingState(nameof(PartProcessingStateValues.PROCESSING_ENDED_LOST));
        /// <summary>
		﻿/// part occurrence has been skipped for processing on the piece of equipment.
        /// </summary>
		[ObservationalValue(typeof(PartProcessingStateValues))]
        public static PartProcessingState PROCESSING_ENDED_SKIPPED => new PartProcessingState(nameof(PartProcessingStateValues.PROCESSING_ENDED_SKIPPED));
        /// <summary>
		﻿/// part occurrence has been processed completely. However, the processing may have a problem.
        /// </summary>
		[ObservationalValue(typeof(PartProcessingStateValues))]
        public static PartProcessingState PROCESSING_ENDED_REJECTED => new PartProcessingState(nameof(PartProcessingStateValues.PROCESSING_ENDED_REJECTED));
        /// <summary>
		﻿/// part occurrence is waiting for transit.
        /// </summary>
		[ObservationalValue(typeof(PartProcessingStateValues))]
        public static PartProcessingState WAITING_FOR_TRANSIT => new PartProcessingState(nameof(PartProcessingStateValues.WAITING_FOR_TRANSIT));
        /// <summary>
		﻿/// part occurrence is being transported to its destination.
        /// </summary>
		[ObservationalValue(typeof(PartProcessingStateValues))]
        public static PartProcessingState IN_TRANSIT => new PartProcessingState(nameof(PartProcessingStateValues.IN_TRANSIT));
        /// <summary>
		﻿/// part occurrence has been placed at its designated destination.
        /// </summary>
		[ObservationalValue(typeof(PartProcessingStateValues))]
        public static PartProcessingState TRANSIT_COMPLETE => new PartProcessingState(nameof(PartProcessingStateValues.TRANSIT_COMPLETE));
		
        /// <summary>
        /// Implicitly converts the specified string to an <see cref="PartProcessingState"/> value.
        /// The string is converted to uppercase and used to initialize the <see cref="PartProcessingState"/> value.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <returns>An <see cref="PartProcessingState"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator PartProcessingState(string value)
            => new PartProcessingState(value.ToUpperInvariant());
		
    }
}