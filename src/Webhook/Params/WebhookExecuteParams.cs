namespace Vysn.Rest.Webhook.Params {
    /// <summary>
    /// 
    /// </summary>
    /// TODO: Rename this
    public enum HookTarget {
        /// <summary>
        /// 
        /// </summary>
        Discord,

        /// <summary>
        /// 
        /// </summary>
        Slack,

        /// <summary>
        /// 
        /// </summary>
        GitHub
    }

    /// <summary>
    /// 
    /// </summary>
    public readonly struct WebhookExecuteParams {
        /// <summary>
        /// 
        /// </summary>
        public bool ShouldWait { get; }
        
        /// <summary>
        /// 
        /// </summary>
        public string Content { get; }
        
        /// <summary>
        /// 
        /// </summary>
        public string Username { get; }
        
        /// <summary>
        /// 
        /// </summary>
        public string AvatarUrl { get; }
        
        /// <summary>
        /// 
        /// </summary>
        public bool IsTTS { get; }
        
        /// <summary>
        /// 
        /// </summary>
        public string File { get; }
        
        /// <summary>
        /// TODO
        /// </summary>
        public object[] Embeds { get; }
        
        /// <summary>
        /// TODO
        /// </summary>
        public string PayloadJson { get; }
        
        /// <summary>
        /// TODO
        /// </summary>
        public object AllowedMentions { get; }
    }
}