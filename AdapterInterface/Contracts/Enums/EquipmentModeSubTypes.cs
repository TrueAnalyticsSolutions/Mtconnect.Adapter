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
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.12.0")]
	public enum EquipmentModeSubTypes
	{
		/// <summary>
		/// An extension to the standard. Extensions to the standard are usually prefaced with <c>x:</c>.
		/// </summary>
		STANDARD_EXTENSION = -1,
		/// <summary>
		﻿/// indication that the sub-parts of a piece of equipment are under load.  Example: For traditional machine tools, this is an indication that the cutting tool is assumed to be engaged with the part.
		/// </summary>
		LOADED,
		/// <summary>
		﻿/// indication that a piece of equipment is performing any activity, the equipment is active and performing a function under load or not.  Example: For traditional machine tools, this includes when the piece of equipment is <c>LOADED</c>, making rapid moves, executing a tool change, etc.
		/// </summary>
		WORKING,
		/// <summary>
		﻿/// indication that the major sub-parts of a piece of equipment are powered or performing any activity whether producing a part or product or not.  Example: For traditional machine tools, this includes when the piece of equipment is <c>WORKING</c> or it is idle.
		/// </summary>
		OPERATING,
		/// <summary>
		﻿/// indication that primary power is applied to the piece of equipment and, as a minimum, the controller or logic portion of the piece of equipment is powered and functioning or components that are required to remain on are powered.  Example: Heaters for an extrusion machine that required to be powered even when the equipment is turned off.
		/// </summary>
		POWERED,
		/// <summary>
		﻿/// elapsed time of a temporary halt of action.
		/// </summary>
		DELAY,
	}
}