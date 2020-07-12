using System;

namespace Vysn.Rest.User.Structures.Enums {
    /// <summary>
    /// 
    /// </summary>
    [Flags]
    public enum UserFlags {
        /// <summary>
        /// 
        /// </summary>
        None = 0,

        /// <summary>
        /// 
        /// </summary>
        DiscordEmployee = 1 << 0,

        /// <summary>
        /// 
        /// </summary>
        DiscordPartner = 1 << 1,

        /// <summary>
        /// 
        /// </summary>
        HypeSquadEvents = 1 << 2,

        /// <summary>
        /// 
        /// </summary>
        BugHunterLevelOne = 1 << 3,

        /// <summary>
        /// 
        /// </summary>
        HouseBravery = 1 << 6,

        /// <summary>
        /// 
        /// </summary>
        HouseBrilliance = 1 << 7,

        /// <summary>
        /// 
        /// </summary>
        HouseBalance = 1 << 8,

        /// <summary>
        /// 
        /// </summary>
        EarlySupporter = 1 << 9,

        /// <summary>
        /// 
        /// </summary>
        TeamUser = 1 << 10,

        /// <summary>
        /// 
        /// </summary>
        System = 1 << 12,

        /// <summary>
        /// 
        /// </summary>
        BugHunterLevelTwo = 1 << 14,

        /// <summary>
        /// 
        /// </summary>
        VerifiedBot = 1 << 16,

        /// <summary>
        /// 
        /// </summary>
        VerifiedBotDeveloper = 1 << 17
    }
}