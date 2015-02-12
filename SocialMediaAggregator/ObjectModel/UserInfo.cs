//
// Free to redistribute and use.
// Creator: Gentiana Coman, www.gentianacoman.com
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaAggregator.ObjectModel
{
    /// <summary>
    /// Object model for a social media user understood by the View interfaces.
    /// </summary>
    public class UserInfo
    {
        public UserInfo() { }

        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ProfileImageUrl { get; set; }
        public string ScreenName { get; set; }
        public int FriendsCount { get; set; }
        public string Link { get; set; }
        public string Gender { get; set; }
        public string ClientName { get; set; }
    }
}
