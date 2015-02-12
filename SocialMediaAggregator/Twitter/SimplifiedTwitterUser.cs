//
// Free to redistribute and use.
// Creator: Gentiana Coman, www.gentianacoman.com
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tweetinvi.Core.Interfaces;
using Tweetinvi.Core.Interfaces.DTO;

namespace SocialMediaAggregator.Twitter
{
    /// <summary>
    /// A stripped down version of a Twitter user.
    /// </summary>
    public class SimplifiedTwitterUser
    {
        public SimplifiedTwitterUser() { }

        public SimplifiedTwitterUser(IUserDTO user)
        {
            Name = user.Name;
            ScreenName = user.ScreenName;
            Id = user.IdStr;
            Description = user.Description;
            FriendsCount = user.FriendsCount;
            ProfileImageUrl = user.ProfileImageUrl;
            Link = user.Url;
        }

        public SimplifiedTwitterUser(IUser user)
            : this(user.UserDTO) { }

        public string Name { get; set; }

        public string ScreenName { get; set; }

        public string Id { get; set; }

        public string ProfileImageUrl { get; set; }

        public string Description { get; set; }

        public int FriendsCount { get; set; }

        public string Link { get; set; }
    }
}
