//
// Free to redistribute and use.
// Creator: Gentiana Coman, www.gentianacoman.com
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facebook;
using SocialMediaAggregator.ObjectModel;
using SocialMediaAggregator.Facebook;

namespace SocialMediaAggregator.Facebook
{
    /// <summary>
    /// A stripped down version of a Facebook post.
    /// </summary>
    public class SimplifiedFacebookPost
    {
        public SimplifiedFacebookPost() { }

        public SimplifiedFacebookPost(JsonObject post)
        {
            CreatedTime = DateTime.Parse(post["created_time"] as string);
            Message = GetMessage(post);
            dynamic from = post["from"] as dynamic;
            User = new SimplifiedFacebookUser()
            {
                Name = from.name,
                Id = from.id
            };
            Shares = GetShares(post);
            Type = post["type"] as string;
            Likes = GetLikes(post);
        }

        private string GetMessage(JsonObject post)
        {
            if (post.ContainsKey("message"))
                return post["message"] as string;

            return null;
        }

        private long GetShares(JsonObject post)
        {
            if (!post.ContainsKey("shares"))
                return 0;

            dynamic shares = post["shares"] as dynamic;
            long result;
            long.TryParse(shares.count, out result);

            return result;
        }

        private long GetLikes(JsonObject post)
        {
            if (!post.ContainsKey("likes"))
                return 0;

            var likes = post["likes"] as JsonObject;

            if (!likes.ContainsKey("summary"))
                return 0;

            var summary = likes["summary"] as JsonObject;

            if (!summary.ContainsKey("total_count"))
                return 0;

            var count = summary["total_count"] as string;
            long result;
            long.TryParse(count, out result);

            return result;
        }

        public DateTime CreatedTime { get; set; }
        public string Message { get; set; }
        public SimplifiedFacebookUser User { get; set; }
        public long Shares { get; set; }
        public string Type { get; set; }
        public long Likes { get; set; }

        public bool Equals(SimplifiedFacebookPost other)
        {
            return CreatedTime == other.CreatedTime &&
                Message == other.Message &&
                User.Equals(other.User) &&
                Shares == other.Shares &&
                Type == other.Type &&
                Likes == other.Likes;
        }
    }
}
