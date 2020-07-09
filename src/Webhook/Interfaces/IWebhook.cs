using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Vysn.Commons;
using Vysn.Rest.Attributes;
using Vysn.Rest.Attributes.Enums;
using Vysn.Rest.Webhook.Params;
using Vysn.Rest.Webhook.Structures;

namespace Vysn.Rest.Webhook.Interfaces {
    /// <summary>
    /// TODO: Renaming
    /// </summary>
    public interface IWebhook {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="channelId"></param>
        /// <param name="name"></param>
        /// <param name="avatarPath"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException">Throws when webhook name is 'clyde'.</exception>
        [Route(HttpType.POST, "/channels/{channelId}/webhooks")]
        Task<Optional<WebhookStructure>> CreateAsync(Snowflake channelId, string name, string avatarPath);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="channelId"></param>
        /// <returns></returns>
        [Route(HttpType.GET, "/channels/{channelId}/webhooks")]
        Task<ICollection<WebhookStructure>> GetChannelHooksAsync(Snowflake channelId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="guildId"></param>
        /// <returns></returns>
        [Route(HttpType.GET, "/guilds/{guildId}/webhooks")]
        Task<ICollection<WebhookStructure>> GetGuildHooksAsync(Snowflake guildId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="webhookId"></param>
        /// <returns></returns>
        [Route(HttpType.GET, "/webhooks/{webookId}")]
        Task<WebhookStructure> GetAsync(Snowflake webhookId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="webhookId"></param>
        /// <param name="webhookToken"></param>
        /// <returns></returns>
        [Route(HttpType.GET, "/webhooks/{webookId}/{webhookToken}")]
        Task<WebhookStructure> GetAsync(Snowflake webhookId, string webhookToken);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="webookId"></param>
        /// <param name="modifyParams"></param>
        /// <returns></returns>
        [Route(HttpType.PATCH, "/webhooks/{webhookId}")]
        Task<WebhookStructure> ModifyAsync(Snowflake webookId, WebhookModifyParams modifyParams);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="webhookId"></param>
        /// <param name="webhookToken"></param>
        /// <param name="modifyParams"></param>
        /// <returns></returns>
        [Route(HttpType.PATCH, "/webhooks/{webhookId}/{webhookToken}")]
        Task<WebhookStructure> ModifyAsync(Snowflake webhookId, string webhookToken, WebhookModifyParams modifyParams);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="webhookId"></param>
        /// <returns></returns>
        [Route(HttpType.DELETE, "/webhooks/{webhookId}")]
        Task DeleteAsync(Snowflake webhookId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="webhookId"></param>
        /// <param name="webhookToken"></param>
        /// <returns></returns>
        [Route(HttpType.DELETE, "/webhooks/{webhookId}/{webhookToken}")]
        Task DeleteAsync(Snowflake webhookId, string webhookToken);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="webhookId"></param>
        /// <param name="webhookToken"></param>
        /// <param name="executeParams"></param>
        /// <returns></returns>
        [Route(HttpType.POST, "/webhooks/{webhookId}/{webhookToken}")]
        Task ExecuteAsync(Snowflake webhookId, string webhookToken, WebhookExecuteParams executeParams);
    }
}