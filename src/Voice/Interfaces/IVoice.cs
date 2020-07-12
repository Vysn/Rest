using System.Collections.Generic;
using System.Threading.Tasks;
using Vysn.Rest.Attributes;
using Vysn.Rest.Attributes.Enums;
using Vysn.Rest.Voice.Structures;

namespace Vysn.Rest.Voice.Interfaces {
    /// <summary>
    /// 
    /// </summary>
    public interface IVoice {
        /// <summary>
        /// Returns an array of <see cref="VoiceRegionStructure"/> that can be used when creating servers.
        /// </summary>
        /// <returns></returns>
        [Route(HttpType.GET, "/voice/regions")]
        Task<ICollection<VoiceRegionStructure>> ListRegionsAsync();
    }
}