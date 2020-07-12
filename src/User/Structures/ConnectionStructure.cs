using Vysn.Rest.User.Structures.Enums;

namespace Vysn.Rest.User.Structures {
    /// <summary>
    /// 
    /// </summary>
    public struct ConnectionStructure {
        /// <summary>
        /// 
        /// </summary>
        public string Id { get; internal set; }

        /// <summary>
        /// 
        /// </summary>
        public string Name { get; internal set; }

        /// <summary>
        /// 
        /// </summary>
        public string Type { get; internal set; }

        /// <summary>
        /// 
        /// </summary>
        public bool IsRevoked { get; internal set; }

        /// <summary>
        /// TODO
        /// </summary>
        public object[] Integrations { get; internal set; }

        /// <summary>
        /// 
        /// </summary>
        public bool IsVerified { get; internal set; }

        /// <summary>
        /// 
        /// </summary>
        public bool IsFriendSyncEnabled { get; internal set; }

        /// <summary>
        /// 
        /// </summary>
        public bool IsActivityVisible { get; internal set; }

        /// <summary>
        /// 
        /// </summary>
        public VisibilityType Visibility { get; internal set; }
    }
}