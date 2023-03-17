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
	public enum ProgramSubTypes
	{
		/// <summary>
		/// An extension to the standard. Extensions to the standard are usually prefaced with <c>x:</c>.
		/// </summary>
		STANDARD_EXTENSION = -1,
		/// <summary>
		﻿/// phase or segment of a recipe or program.
		/// </summary>
		ACTIVITY,
		/// <summary>
		﻿/// phase of a recipe process.
		/// </summary>
		SEGMENT,
		/// <summary>
		﻿/// process as part of product production; can be a subprocess of a larger process.
		/// </summary>
		RECIPE,
		/// <summary>
		﻿/// step of a discrete manufacturing process.
		/// </summary>
		OPERATION,
		/// <summary>
		﻿/// identity of the logic or motion program currently executing.
		/// </summary>
		ACTIVE,
		/// <summary>
		﻿/// identity of the primary logic or motion program currently being executed.   It is the starting nest level in a call structure and may contain calls to sub programs.
		/// </summary>
		MAIN,
		/// <summary>
		﻿/// identity of a control program that is used to specify the order of execution of other programs.
		/// </summary>
		SCHEDULE,
	}
}