using Vysn.Commons;

namespace Vysn.Rest.Voice.Structures {
    /// <summary>
    /// 
    /// </summary>
    public struct VoiceStateStructure {
        /// <summary>
        /// The guild Id this voice state is for.
        /// </summary>
        public Snowflake GuildId { get; internal set; }

        /// <summary>
        /// The channel id this user is connected to.
        /// </summary>
        public Snowflake ChannelId { get; internal set; }

        /// <summary>
        /// The user id this voice state is for.
        /// </summary>
        public Snowflake UserId { get; internal set; }

        /// <summary>
        /// The guild member this voice state is for.
        /// </summary>
        public object Member { get; internal set; }

        /// <summary>
        /// The session id for this voice state.
        /// </summary>
        public string SessionId { get; internal set; }

        /// <summary>
        /// Whether this user is deafened by the server.
        /// </summary>
        public bool IsDeaf { get; internal set; }

        /// <summary>
        /// Whether this user is muted by the server.
        /// </summary>
        public bool IsMute { get; internal set; }

        /// <summary>
        /// Whether this user is locally deafened.
        /// </summary>
        public bool IsSelfDeaf { get; internal set; }

        /// <summary>
        /// Whether this user is locally muted.
        /// </summary>
        public bool IsSelfMute { get; internal set; }

        /// <summary>
        /// Whether this user is streaming using 'Go Live'.
        /// </summary>
        public bool IsSelfStream { get; internal set; }

        /// <summary>
        /// Whether this user is muted by the current user.
        /// </summary>
        public bool IsSurpressed { get; internal set; }
    }
}