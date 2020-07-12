using Vysn.Commons;

namespace Vysn.Rest.Voice.Structures {
    /// <summary>
    /// 
    /// </summary>
    public struct VoiceRegionStructure {
        /// <summary>
        /// Unique ID for this region.
        /// </summary>
        public Snowflake Id { get; internal set; }
        
        /// <summary>
        /// Name of the region.
        /// </summary>
        public string Name { get; internal set; }
        
        /// <summary>
        /// Whether if this server is VIP-only.
        /// </summary>
        public bool IsVIP { get; internal set; }
        
        /// <summary>
        /// True for a single server that is closest to the current user's client.
        /// </summary>
        public bool IsOptimal { get; internal set; }
        
        /// <summary>
        /// Whether this is a deprecated voice region.
        /// </summary>
        public bool IsDeprecated { get; internal set; }
        
        /// <summary>
        /// Whether this is a custom voice region (Used for events/etc).
        /// </summary>
        public bool IsCustom { get; internal set; }
    }
}