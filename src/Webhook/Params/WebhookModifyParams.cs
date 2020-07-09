using Vysn.Commons;

namespace Vysn.Rest.Webhook.Params {
    /// <summary>
    /// 
    /// </summary>
    public readonly struct WebhookModifyParams {
        /// <summary>
        /// 
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// 
        /// </summary>
        public object Avatar { get; }

        /// <summary>
        /// 
        /// </summary>
        public Snowflake ChannelId { get; }

        /// <summary>
        /// 
        /// </summary>
        public WebhookModifyParams(string name = default,
                                   object avatar = default,
                                   Snowflake channelId = default) {
            Name = name;
            Avatar = avatar;
            ChannelId = channelId;
        }
    }
}