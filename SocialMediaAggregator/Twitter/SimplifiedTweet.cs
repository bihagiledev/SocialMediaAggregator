using SocialMediaAggregator.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
// Free to redistribute and use.
// Creator: Gentiana Coman, www.gentianacoman.com
//

using Tweetinvi.Core.Interfaces;
using Tweetinvi.Core.Interfaces.DTO;

namespace SocialMediaAggregator.Twitter
{
    /// <summary>
    /// Simplified version of a tweet.
    /// </summary>
    public class SimplifiedTweet
    {
        public SimplifiedTweet() { }

        public SimplifiedTweet(ITweetDTO tweet)
        {
            CreatedAt = tweet.CreatedAt;
            Creator = new SimplifiedTwitterUser(tweet.Creator);
            Id = tweet.IdStr;
            Text = tweet.Text;
            RetweetCount = tweet.RetweetCount;
        }

        public SimplifiedTweet(ITweet tweet) : this(tweet.TweetDTO) { }

        public DateTime CreatedAt { get; set; }

        public SimplifiedTwitterUser Creator { get; set; }

        public string Id { get; set; }

        public string Text { get; set; }

        public int RetweetCount { get; set; }
    }
}
