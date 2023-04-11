#pragma warning disable 0618
#pragma warning disable 1574
using System;
using System.CodeDom.Compiler;
using Mtconnect.AdapterInterface.Contracts.Attributes;
using Mtconnect.AdapterInterface.Contracts;
using Mtconnect.AdapterInterface.DataItems;
using Mtconnect.AdapterInterface.DataItemValues;
using Mtconnect.AdapterInterface.Units;

namespace Mtconnect.AdapterInterface.DataItemValues
{
	/// <summary>
	/// A value type for Firmware to be used in a <see cref="IAdapterDataModel" /> implementation. View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "1.0.12.0")]
	public partial class Firmware : EventValue
    {
        /// <inheritdoc />
        public override string ObservationalType => nameof(DataItemTypes.EventTypes.FIRMWARE);

		/// <inheritdoc />
        public override string ObservationalSubType => null;

		/// <summary>
		/// Constructs a new value type for the Firmware EVENT Data Item.
		/// </summary>
        public Firmware(string value) : base(value) { }

		
        /// <summary>
        /// Implicitly converts the specified string to an <see cref="Firmware"/> value.
        /// The string is converted to uppercase and used to initialize the <see cref="Firmware"/> value.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <returns>An <see cref="Firmware"/> value initialized with the specified string in uppercase.</returns>
        public static implicit operator Firmware(string value)
            => new Firmware(value.ToUpperInvariant());
		
		/// <summary>
		/// A Data Item SubType implementation of <see cref="Firmware" />.
		/// </summary>
		public partial class VERSION : Firmware
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.FirmwareSubTypes.VERSION);

			/// <summary>
			/// Constructs a new value type for VERSION.
			/// </summary>
            public VERSION(string value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified string to an <see cref="VERSION"/> value.
			/// The string is converted to uppercase and used to initialize the <see cref="VERSION"/> value.
			/// </summary>
			/// <param name="value">The string to convert.</param>
			/// <returns>An <see cref="VERSION"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator VERSION(string value)
				=> new VERSION(value.ToUpperInvariant());
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="Firmware" />.
		/// </summary>
		public partial class RELEASEDATE : Firmware
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.FirmwareSubTypes.RELEASE_DATE);

			/// <summary>
			/// Constructs a new value type for RELEASE_DATE.
			/// </summary>
            public RELEASEDATE(string value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified string to an <see cref="RELEASEDATE"/> value.
			/// The string is converted to uppercase and used to initialize the <see cref="RELEASEDATE"/> value.
			/// </summary>
			/// <param name="value">The string to convert.</param>
			/// <returns>An <see cref="RELEASEDATE"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator RELEASEDATE(string value)
				=> new RELEASEDATE(value.ToUpperInvariant());
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="Firmware" />.
		/// </summary>
		public partial class MANUFACTURER : Firmware
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.FirmwareSubTypes.MANUFACTURER);

			/// <summary>
			/// Constructs a new value type for MANUFACTURER.
			/// </summary>
            public MANUFACTURER(string value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified string to an <see cref="MANUFACTURER"/> value.
			/// The string is converted to uppercase and used to initialize the <see cref="MANUFACTURER"/> value.
			/// </summary>
			/// <param name="value">The string to convert.</param>
			/// <returns>An <see cref="MANUFACTURER"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator MANUFACTURER(string value)
				=> new MANUFACTURER(value.ToUpperInvariant());
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="Firmware" />.
		/// </summary>
		public partial class LICENSE : Firmware
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.FirmwareSubTypes.LICENSE);

			/// <summary>
			/// Constructs a new value type for LICENSE.
			/// </summary>
            public LICENSE(string value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified string to an <see cref="LICENSE"/> value.
			/// The string is converted to uppercase and used to initialize the <see cref="LICENSE"/> value.
			/// </summary>
			/// <param name="value">The string to convert.</param>
			/// <returns>An <see cref="LICENSE"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator LICENSE(string value)
				=> new LICENSE(value.ToUpperInvariant());
		}
		/// <summary>
		/// A Data Item SubType implementation of <see cref="Firmware" />.
		/// </summary>
		public partial class INSTALLDATE : Firmware
		{
			/// <inheritdoc />
            public override string ObservationalSubType => nameof(DataItemTypes.FirmwareSubTypes.INSTALL_DATE);

			/// <summary>
			/// Constructs a new value type for INSTALL_DATE.
			/// </summary>
            public INSTALLDATE(string value) : base(value) { }
			
			/// <summary>
			/// Implicitly converts the specified string to an <see cref="INSTALLDATE"/> value.
			/// The string is converted to uppercase and used to initialize the <see cref="INSTALLDATE"/> value.
			/// </summary>
			/// <param name="value">The string to convert.</param>
			/// <returns>An <see cref="INSTALLDATE"/> value initialized with the specified string in uppercase.</returns>
			public static implicit operator INSTALLDATE(string value)
				=> new INSTALLDATE(value.ToUpperInvariant());
		}
    }
}