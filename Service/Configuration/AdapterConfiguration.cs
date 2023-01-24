﻿
namespace Service.Configuration
{
    /// <summary>
    /// Options for configuring a single <see cref="Mtconnect.Adapter"/>.
    /// </summary>
    public class AdapterConfiguration
    {
        /// <summary>
        /// Filename for the <see cref="Mtconnect.Adapter"/> implementation.
        /// </summary>
        public string Adapter { get; set; }

        /// <summary>
        /// Filename(s) for the <see cref="Mtconnect.IAdapterSource"/>(s) to attach to the referenced <see cref="Mtconnect.Adapter"/>.
        /// </summary>
        public string[] Sources { get; set; }

        /// <summary>
        /// ServiceConfiguration options for the referenced <see cref="Mtconnect.Adapter"/>.
        /// </summary>
        public Dictionary<string, object>? Options { get; set; }
    }
}