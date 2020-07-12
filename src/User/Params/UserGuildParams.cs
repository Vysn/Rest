using Vysn.Commons;

namespace Vysn.Rest.User.Params {
    /// <summary>
    /// 
    /// </summary>
    public readonly struct UserGuildParams {
        /// <summary>
        /// Get guilds before this guild ID.
        /// </summary>
        public Snowflake Before { get; }

        /// <summary>
        /// Get guilds after this guild ID.
        /// </summary>
        public Snowflake After { get; }

        /// <summary>
        /// Maximum number of guilds to return (1 - 100)
        /// </summary>
        public int Limit { get; }
    }
}