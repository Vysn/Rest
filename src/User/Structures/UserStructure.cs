using Vysn.Commons;
using Vysn.Rest.User.Structures.Enums;

namespace Vysn.Rest.User.Structures {
    /// <summary>
    /// 
    /// </summary>
    public struct UserStructure {
        /// <summary>
        /// The user's ID.
        /// </summary>
        public Snowflake Id { get; internal set; }

        /// <summary>
        /// The user's username, not unique across the platform.
        /// </summary>
        public string Username { get; internal set; }

        /// <summary>
        /// TODO
        /// The user's 4-digit discord-tag.
        /// </summary>
        public string Discriminator { get; internal set; }

        /// <summary>
        /// The user's avatar hash.
        /// </summary>
        public string AvatarHash { get; internal set; }

        /// <summary>
        /// Whether the user belongs to an OAuth2 application.
        /// </summary>
        public bool IsBot { get; internal set; }

        /// <summary>
        /// Whether the user is an Official Discord System.
        /// </summary>
        public bool IsSystem { get; internal set; }

        /// <summary>
        /// Whether the user has 2 factor enabled on their account.
        /// </summary>
        public bool HasMFAEnabled { get; internal set; }

        /// <summary>
        /// The user's chosen language option.
        /// </summary>
        public string Locale { get; internal set; }

        /// <summary>
        /// Whether the email on this account has been verified.
        /// </summary>
        public bool IsVerified { get; internal set; }

        /// <summary>
        /// The user's email.
        /// </summary>
        public string Email { get; internal set; }

        /// <summary>
        /// The <see cref="UserFlags"/> on a user's account.
        /// </summary>
        public UserFlags Flags { get; internal set; }

        /// <summary>
        /// The type of Nitro subscription on a user's account.
        /// </summary>
        public PremiumType PremiumType { get; internal set; }

        /// <summary>
        /// The public <see cref="UserFlags"/> on a user's account.
        /// </summary>
        public UserFlags PublicFlags { get; internal set; }
    }
}