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
	public enum OperatingSystemSubTypes
	{
		/// <summary>
		/// An extension to the standard. Extensions to the standard are usually prefaced with <c>x:</c>.
		/// </summary>
		STANDARD_EXTENSION = -1,
		/// <summary>
		﻿/// license code to validate or activate the hardware or software.
		/// </summary>
		LICENSE,
		/// <summary>
		﻿/// version of the hardware or software.
		/// </summary>
		VERSION,
		/// <summary>
		﻿/// date the hardware or software was released for general use.  
		/// </summary>
		RELEASE_DATE,
		/// <summary>
		﻿/// date the hardware or software was installed.
		/// </summary>
		INSTALL_DATE,
		/// <summary>
		﻿/// corporate identity for the maker of the hardware or software.  
		/// </summary>
		MANUFACTURER,
	}
}