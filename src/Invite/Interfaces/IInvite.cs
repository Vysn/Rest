using System.Threading.Tasks;
using Vysn.Rest.Attributes;
using Vysn.Rest.Attributes.Enums;
using Vysn.Rest.Invite.Structures;

namespace Vysn.Rest.Invite.Interfaces {
    /// <summary>
    /// Invite Resource
    /// </summary>
    public interface IInvite {
        /// <summary>
        /// Returns an <see cref="InviteStructure"/> for the given <paramref name="inviteCode"/>.
        /// </summary>
        /// <param name="inviteCode"></param>
        /// <param name="withCounts">Whether the invite should contains approxiamate member counts.</param>
        /// <returns><see cref="InviteStructure"/></returns>
        [Route(HttpType.GET, "/invites/{inviteCode}")]
        Task<InviteStructure> GetAsync(string inviteCode, bool withCounts = false);

        /// <summary>
        /// Deletes an invite.
        /// </summary>
        /// <param name="inviteCode"></param>
        /// <returns><see cref="InviteStructure"/></returns>
        [Route(HttpType.DELETE, "/invites/{inviteCode}")]
        Task<InviteStructure> DeleteAsync(string inviteCode);
    }
}