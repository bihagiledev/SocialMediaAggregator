using SocialMediaAggregator.Twitter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaAggregatorTest
{
    /// <summary>
    /// This class is an indicator of how you could mock out the Twitter client.
    /// For advanced testing, write your own implementation and use it for the Controller tests.
    /// Hint: Write the controller such that it is bound to the Interface, not the actual implementation :)
    /// </summary>
    public class TestTwitterClientWrapper : ITwitterClientWrapper
    {
        public SimplifiedTweet PostTweet(string message)
        {
            return new SimplifiedTweet() { Text = message };
        }

        public SimplifiedTweet PostTweetWithMedia(string message, string itemPath)
        {
            return new SimplifiedTweet() { Text = message };
        }

        public SimplifiedTwitterUser AboutMe()
        {
            return new SimplifiedTwitterUser() { Description = "My bio", Name = "A user" };
        }

        public ITwitterTimelineWrapper GetTimelineWrapper()
        {
            return new TestTwitterTimelineWrapper();
        }

        public IList<SimplifiedTwitterUser> GetFriends()
        {
            return new List<SimplifiedTwitterUser>() { new SimplifiedTwitterUser() { Description = "A bio", Name = "A user" } };
        }
    }
}
