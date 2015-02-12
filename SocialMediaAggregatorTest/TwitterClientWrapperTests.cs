using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SocialMediaAggregator.Twitter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaAggregatorTest
{
    [TestClass]
    public class TwitterClientWrapperTests
    {
        [TestMethod]
        public void Test_MockFacebookClient_GetMe()
        {
            var twitterWrapper = new TestTwitterClientWrapper();
            var actualResult = twitterWrapper.AboutMe();

            Assert.IsTrue(actualResult.Name == "A user");
        }

        [TestMethod]
        public void Test_SimulateHomeTweets()
        {
            var twitterWrapper = new TestTwitterClientWrapper();
            var timelineWrapper = twitterWrapper.GetTimelineWrapper();

            List<SimplifiedTweet> homeTweetBatches = new List<SimplifiedTweet>();
            while (timelineWrapper.HasMoreHomeTweets())
            {
                homeTweetBatches.AddRange(timelineWrapper.GetBatchedHomeTweets(10));
            }

            Assert.IsTrue(homeTweetBatches.Count == 10);
        }

        [TestMethod]
        public void Test_SimulateUserTweets()
        {
            var twitterWrapper = new TestTwitterClientWrapper();
            var timelineWrapper = twitterWrapper.GetTimelineWrapper();

            List<SimplifiedTweet> userTweetBatches = new List<SimplifiedTweet>();
            while (timelineWrapper.HasMoreUserTweets())
            {
                userTweetBatches.AddRange(timelineWrapper.GetBatchedUserTweets(10));
            }

            Assert.IsTrue(userTweetBatches.Count == 10);
        }
    }
}
