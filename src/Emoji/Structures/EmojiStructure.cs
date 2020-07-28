using System.Collections.Generic;
using Vysn.Commons;
using Vysn.Rest.User.Structures;

namespace Vysn.Rest.Emoji.Structures {
    /// <summary>
    /// 
    /// </summary>
    public class EmojiStructure {
        /// <summary>
        /// The Id of this emoji.
        /// </summary>
        public Snowflake Id { get; internal set; }

        /// <summary>
        /// The name of this emoji
        /// </summary>
        public string Name { get; internal set; }

        /// <summary>
        /// List of roles this emoji is whitelisted to.
        /// </summary>
        public IReadOnlyCollection<Snowflake> Roles { get; internal set; }

        /// <summary>
        /// The user who created this emoji.
        /// </summary>
        public UserStructure User { get; internal set; }

        /// <summary>
        /// Whether this emoji must be wrapped in colons.
        /// </summary>
        public bool AreColonsRequired { get; internal set; }

        /// <summary>
        /// Whether this emoji is managed.
        /// </summary>
        public bool IsManaged { get; internal set; }

        /// <summary>
        /// Whether this emoji is animated.
        /// </summary>
        public bool IsAnimated { get; internal set; }

        /// <summary>
        /// Whether this emoji can be used, may be false due to loss of Server Boosts.
        /// </summary>
        public bool IsAvailable { get; internal set; }
    }
}