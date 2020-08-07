using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Vysn.Commons;
using Vysn.Rest.Attributes;
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
        [Post("/channels/{channelId}/webhooks")]
        Task<Optional<WebhookStructure>> CreateAsync(Snowflake channelId, string name, string avatarPath);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="channelId"></param>
        /// <returns></returns>
        [Get("/channels/{channelId}/webhooks")]
        Task<ICollection<WebhookStructure>> GetChannelHooksAsync(Snowflake channelId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="guildId"></param>
        /// <returns></returns>
        [Get("/guilds/{guildId}/webhooks")]
        Task<ICollection<WebhookStructure>> GetGuildHooksAsync(Snowflake guildId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="webhookId"></param>
        /// <returns></returns>
        [Get("/webhooks/{webookId}")]
        Task<WebhookStructure> GetAsync(Snowflake webhookId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="webhookId"></param>
        /// <param name="webhookToken"></param>
        /// <returns></returns>
        [Get("/webhooks/{webookId}/{webhookToken}")]
        Task<WebhookStructure> GetAsync(Snowflake webhookId, string webhookToken);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="webookId"></param>
        /// <param name="modifyParams"></param>
        /// <returns></returns>
        [Patch("/webhooks/{webhookId}")]
        Task<WebhookStructure> ModifyAsync(Snowflake webookId, WebhookModifyParams modifyParams);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="webhookId"></param>
        /// <param name="webhookToken"></param>
        /// <param name="modifyParams"></param>
        /// <returns></returns>
        [Patch("/webhooks/{webhookId}/{webhookToken}")]
        Task<WebhookStructure> ModifyAsync(Snowflake webhookId, string webhookToken, WebhookModifyParams modifyParams);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="webhookId"></param>
        /// <returns></returns>
        [Delete("/webhooks/{webhookId}")]
        Task DeleteAsync(Snowflake webhookId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="webhookId"></param>
        /// <param name="webhookToken"></param>
        /// <returns></returns>
        [Delete("/webhooks/{webhookId}/{webhookToken}")]
        Task DeleteAsync(Snowflake webhookId, string webhookToken);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="webhookId"></param>
        /// <param name="webhookToken"></param>
        /// <param name="executeParams"></param>
        /// <returns></returns>
        [Post("/webhooks/{webhookId}/{webhookToken}")]
        Task ExecuteAsync(Snowflake webhookId, string webhookToken, WebhookExecuteParams executeParams);
    }
}