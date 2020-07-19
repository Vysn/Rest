using System;

namespace Vysn.Rest.Invite.Structures {
    /// <summary>
    /// 
    /// </summary>
    public struct InviteMetaStructure {
        /// <summary>
        /// Number of times this invite has been used.
        /// </summary>
        public int Uses { get; internal set; }

        /// <summary>
        /// The max number of times this invite can be used.
        /// </summary>
        public int MaxUses { get; internal set; }

        /// <summary>
        /// The duration (seconds) after which the invite expires.
        /// </summary>
        public int MaxAge { get; internal set; }

        /// <summary>
        /// Whether this invite only grants temporary membership.
        /// </summary>
        public bool IsTemporary { get; internal set; }

        /// <summary>
        /// When this invite was created.
        /// </summary>
        public DateTime CreatedAt { get; internal set; }
    }
}