using Vysn.Commons;
using Vysn.Rest.Webhook.Structures.Enums;

namespace Vysn.Rest.Webhook.Structures {
    /// <summary>
    /// 
    /// </summary>
    public struct WebhookStructure {
        /// <summary>
        /// The id of the webhook
        /// </summary>
        public Snowflake Id { get; internal set; }

        /// <summary>
        /// The type (<see cref="WebhookType"/>) of webhook.
        /// </summary>
        public WebhookType Type { get; internal set; }

        /// <summary>
        /// The guild id this webhook is for.
        /// </summary>
        public Snowflake GuildId { get; internal set; }

        /// <summary>
        /// The channel id this webhook is for.
        /// </summary>
        public Snowflake ChannelId { get; internal set; }

        /// <summary>
        /// The user this webhook was created by.
        /// </summary>
        public object User { get; internal set; }

        /// <summary>
        /// The default name of the webhook.
        /// </summary>
        public string Name { get; internal set; }

        /// <summary>
        /// The default avatar of the webhook.
        /// </summary>
        public string Avatar { get; internal set; }

        /// <summary>
        /// The secure token of the webhook.
        /// </summary>
        public string Token { get; internal set; }
    }
}