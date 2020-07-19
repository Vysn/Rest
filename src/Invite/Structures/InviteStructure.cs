using Vysn.Rest.Invite.Structures.Enums;
using Vysn.Rest.User.Structures;

namespace Vysn.Rest.Invite.Structures {
    /// <summary>
    /// 
    /// </summary>
    public struct InviteStructure {
        /// <summary>
        /// The invite code.
        /// </summary>
        public string Code { get; internal set; }

        /// <summary>
        /// The guild this invite is for.
        /// </summary>
        public object Guild { get; internal set; }

        /// <summary>
        /// The channel this invite is for.
        /// </summary>
        public object Channel { get; internal set; }

        /// <summary>
        /// The user who created the invite.
        /// </summary>
        public UserStructure User { get; internal set; }

        /// <summary>
        /// The target user for this invite.
        /// </summary>
        public UserStructure TargetUser { get; internal set; }

        /// <summary>
        /// The type of <see cref="TargetUserType"/> for this invite.
        /// </summary>
        public TargetUserType UserType { get; internal set; }

        /// <summary>
        /// An approximate count of online members.
        /// </summary>
        public int PresenceCount { get; internal set; }

        /// <summary>
        /// An approximate count of total members.
        /// </summary>
        public int MemberCount { get; internal set; }
    }
}