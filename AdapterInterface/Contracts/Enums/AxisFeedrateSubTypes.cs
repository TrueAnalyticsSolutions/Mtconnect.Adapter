#pragma warning disable 0618
#pragma warning disable 1574
using System;
using System.CodeDom.Compiler;
using Mtconnect.AdapterInterface.Contracts.Attributes;

namespace Mtconnect.AdapterInterface.DataItemTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.14.0")]
	public enum AxisFeedrateSubTypes
	{
		/// <summary>
		/// An extension to the standard. Extensions to the standard are usually prefaced with <c>x:</c>.
		/// </summary>
		STANDARD_EXTENSION = -1,
		/// <summary>
		﻿/// measured or reported value of an <i>observation</i>.
		/// </summary>
		ACTUAL,
		/// <summary>
		﻿/// directive value including adjustments such as an offset or overrides.
		/// </summary>
		COMMANDED,
		/// <summary>
		﻿/// relating to momentary activation of a function or a movement.  <b>DEPRECATION WARNING</b>: May be deprecated in the future.
		/// </summary>
		JOG,
		/// <summary>
		﻿/// directive value without offsets and adjustments.
		/// </summary>
		PROGRAMMED,
		/// <summary>
		﻿/// performing an operation faster or in less time than nominal rate.
		/// </summary>
		RAPID,
		/// <summary>
		﻿/// operator's overridden value.
		/// </summary>
		[Obsolete("Deprecated according to https://model.mtconnect.org/ in MtconnectVersions.V_1_3_0")]
		OVERRIDE,
	}
}