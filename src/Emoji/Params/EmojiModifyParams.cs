using System.Collections.Generic;
using Vysn.Commons;

namespace Vysn.Rest.Emoji.Params {
    /// <summary>
    /// 
    /// </summary>
    public struct EmojiModifyParams {
        /// <summary>
        /// Name of the emoji.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Roles to which this emoji will be whitelisted.
        /// </summary>
        public IReadOnlyCollection<Snowflake> Roles { get; set; }
    }
}