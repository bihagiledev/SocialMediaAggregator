//
// Free to redistribute and use.
// Creator: Gentiana Coman, www.gentianacoman.com
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaAggregator.Facebook
{
    public class SimplifiedFacebookUser
    {
        public SimplifiedFacebookUser() { }

        public SimplifiedFacebookUser(dynamic facebookJsonUser)
        {
            Id = facebookJsonUser.id;
            Name = facebookJsonUser.name;
            Description = facebookJsonUser.bio;
            Gender = facebookJsonUser.gender;
            ProfileImageUrl = facebookJsonUser.picture.url;
            Link = facebookJsonUser.link;
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ProfileImageUrl { get; set; }
        public string Link { get; set; }
        public string Gender { get; set; }

        public bool Equals(SimplifiedFacebookUser other)
        {
            return Id == other.Id &&
                Name == other.Name &&
                Description == other.Description &&
                Gender == other.Gender &&
                ProfileImageUrl == other.ProfileImageUrl &&
                Link == other.Link;
        }
    }
}
