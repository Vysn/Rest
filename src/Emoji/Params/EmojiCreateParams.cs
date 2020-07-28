using System.Collections.Generic;
using Vysn.Commons;

namespace Vysn.Rest.Emoji.Params {
    /// <summary>
    /// 
    /// </summary>
    public struct EmojiCreateParams {
        /// <summary>
        /// Name of the emoji.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The 128x128 emoji image.
        /// </summary>
        public object Image { get; set; }

        /// <summary>
        /// Roles to which this emoji will be whitelisted.
        /// </summary>
        public IReadOnlyCollection<Snowflake> Roles { get; set; }
    }
}