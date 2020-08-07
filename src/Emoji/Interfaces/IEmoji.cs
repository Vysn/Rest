using System.Collections.Generic;
using System.Threading.Tasks;
using Vysn.Commons;
using Vysn.Rest.Attributes;
using Vysn.Rest.Emoji.Params;
using Vysn.Rest.Emoji.Structures;

namespace Vysn.Rest.Emoji.Interfaces {
    /// <summary>
    /// 
    /// </summary>
    public interface IEmoji {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="guildId"></param>
        /// <returns></returns>
        [Get("/guilds/{guildId}/emojis")]
        Task<IReadOnlyCollection<EmojiStructure>> ListAsync(Snowflake guildId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="guildId"></param>
        /// <param name="emojiId"></param>
        /// <returns></returns>
        [Get("/guilds/{guildId}/emojis/{emojiId}")]
        Task<EmojiStructure> GetAsync(Snowflake guildId, Snowflake emojiId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="guildId"></param>
        /// <param name="createParams"></param>
        /// <returns></returns>
        [Post("/guilds/{guildId}/emojis")]
        Task<EmojiStructure> CreateAsync(Snowflake guildId, EmojiCreateParams createParams);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="guildId"></param>
        /// <param name="emojiId"></param>
        /// <param name="modifyParams"></param>
        /// <returns></returns>
        [Patch("/guilds/{guildId}/emojis/{emojiId}")]
        Task<EmojiStructure> ModifyAsync(Snowflake guildId, Snowflake emojiId, EmojiModifyParams modifyParams);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="guildId"></param>
        /// <param name="emojiId"></param>
        /// <returns></returns>
        [Delete("/guilds/{guildId}/emojis/{emojiId}")]
        Task DeleteAsync(Snowflake guildId, Snowflake emojiId);
    }
}