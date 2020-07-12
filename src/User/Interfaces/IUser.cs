using System.Threading.Tasks;
using Vysn.Commons;
using Vysn.Rest.Attributes;
using Vysn.Rest.Attributes.Enums;
using Vysn.Rest.User.Params;
using Vysn.Rest.User.Structures;

namespace Vysn.Rest.User.Interfaces {
    /// <summary>
    /// 
    /// </summary>
    public interface IUser {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [Route(HttpType.GET, "/users/@me")]
        Task<UserStructure> GetAsync();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        [Route(HttpType.GET, "/users/{userId}")]
        Task<UserStructure> GetAsync(Snowflake userId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="modifyParams"></param>
        /// <returns></returns>
        [Route(HttpType.PATCH, "/users/@me")]
        Task<UserStructure> ModifyAsync(UserModifyParams modifyParams);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [Route(HttpType.GET, "/users/@me/guilds")]
        Task<object> GetGuildsAsync(UserGuildParams guildParams = default);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="guildId"></param>
        /// <returns></returns>
        [Route(HttpType.DELETE, "/users/@me/guilds/{guildId}")]
        Task LeaveGuildAsync(Snowflake guildId);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [Route(HttpType.GET, "/users/@me/channels")]
        Task<object> GetDirectMessagesAsync();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="recipientId"></param>
        /// <returns></returns>
        [Route(HttpType.POST, "/users/@me/channels")]
        Task<object> CreateDirectMessageAsync(Snowflake recipientId);

        /// <summary>
        /// TODO
        /// </summary>
        /// <returns></returns>
        Task<object> CreateGroupDirectMessageAsync();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [Route(HttpType.GET, "/users/@me/connections")]
        Task<ConnectionStructure> GetConnectionAsync();
    }
}