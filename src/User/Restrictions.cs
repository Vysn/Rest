using System;
using System.Collections.Generic;
using System.Linq;
using Vysn.Rest.User.Structures;

namespace Vysn.Rest.User {
    /// <summary>
    /// 
    /// </summary>
    public readonly struct Restrictions {
        private static readonly IReadOnlyList<string> BadNames =
            new[] {
                "discordtag",
                "everyone",
                "here"
            };

        private static readonly IReadOnlyCollection<char> BadChars
            = new[] {
                '@',
                '#',
                ':'
            };

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static bool IsValidUsername(ref UserStructure userStructure) {
            if (userStructure.Username.Length < 2 ||
                userStructure.Username.Length > 32) {
                throw new ArgumentOutOfRangeException();
            }

            var username = userStructure.Username;
            if (BadChars.Any(badChar => username[0] == badChar)) {
                throw new Exception("");
            }

            if (username[..3] == "```") {
                throw new Exception("");
            }

            if (BadNames.Any(x => username.ToLower() == x)) {
                throw new Exception("");
            }

            userStructure.Username = userStructure.Username.Trim();
            return true;
        }
    }
}