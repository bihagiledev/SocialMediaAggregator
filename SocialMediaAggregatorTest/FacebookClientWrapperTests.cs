using Facebook.Moq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SocialMediaAggregator.Facebook;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaAggregatorTest
{
    [TestClass]
    public class FacebookClientWrapperTests
    {
        /// <summary>
        /// This is an example of how to obtain dummy data by mocking out the FacebookClient.
        /// </summary>
        [TestMethod]
        public void Test_MockFacebookClient_GetMe()
        {
            var mockFb = FacebookMock.New();
            mockFb
                .FbSetup()
                .ReturnsJson(@"{
""id"": ""5"", 
""bio"": ""My bio"", 
  ""gender"": ""female"", 
  ""link"": ""https://www.facebook.com/5"", 
  ""name"": ""Bih AgileDev"", 
""data"":{""url"":""http://dummy_avatar.jpg""}
}");

            var fb = new FacebookClientWrapper(mockFb.Object);

            SimplifiedFacebookUser actualResult = fb.GetMe();
            SimplifiedFacebookUser expectedResult = new SimplifiedFacebookUser()
            {
                Id = "5",
                Description = "My bio",
                Gender = "female",
                Name = "Bih AgileDev",
                Link = "https://www.facebook.com/5",
                ProfileImageUrl = "http://dummy_avatar.jpg"
            };

            Assert.IsTrue(actualResult.Equals(expectedResult));
        }

        /// <summary>
        /// This is an example of how to simulate posting to Facebook and obtaining the post information.
        /// </summary>
        [TestMethod]
        public void Test_MockFacebookClient_Post()
        {
            var mockFb = FacebookMock.New();
            mockFb
                .FbSetup()
                .ReturnsJson(@"{
""created_time"": ""12/12/12"", 
""message"":""my message"",
""from"": {
    ""name"":""userName"",
    ""id"" : ""id""
},
""type"": ""photo"", 
  ""shares"": {""count"":""25""}, 
  ""link"": ""https://www.facebook.com/5"", 
  ""likes"": {""summary"":{""total_count"":""30""}}
}");
            var fb = new FacebookClientWrapper(mockFb.Object);

            var expectedResult = new SimplifiedFacebookPost()
            {
                Message = "my message",
                User = new SimplifiedFacebookUser() { Name = "userName", Id = "id" },
                Type = "photo",
                Shares = 25,
                Likes = 30,
                CreatedTime = DateTime.Parse("12/12/12")
            };

            var actualResult = fb.Post("my message", "resources\\dummy_avatar.jpg");

            Assert.IsTrue(actualResult.Equals(expectedResult));
        }

        /// <summary>
        /// This is an example of how to obtain a NewsFeed by mocking out the FacebookTimelineWrapper and FacebookClient.
        /// </summary>
        [TestMethod]
        public void Test_SimulateNewsFeed()
        {
            var mockFb = FacebookMock.New();
            mockFb.FbSetup();
            FacebookClientWrapper facebookClient = new FacebookClientWrapper(mockFb.Object, new TestFacebookTimelineWrapperFactory(2, 5));
            var timelineWrapper = facebookClient.GetTimelineWrapper();

            List<SimplifiedFacebookPost> newsFeedBatches = new List<SimplifiedFacebookPost>();
            while (timelineWrapper.HasMoreNewsFeedItems())
            {
                newsFeedBatches.AddRange(timelineWrapper.GetBatchedNewsFeed());
            }

            Assert.IsTrue(newsFeedBatches.Count == 10);
        }

        /// <summary>
        /// This is an example of how to obtain a UserFeed by mocking out the FacebookTimelineWrapper and FacebookClient.
        /// </summary>
        [TestMethod]
        public void Test_SimulateUserFeed()
        {
            var mockFb = FacebookMock.New();
            mockFb.FbSetup();
            FacebookClientWrapper facebookClient = new FacebookClientWrapper(mockFb.Object, new TestFacebookTimelineWrapperFactory(2, 5));
            var timelineWrapper = facebookClient.GetTimelineWrapper();

            List<SimplifiedFacebookPost> userFeedBatches = new List<SimplifiedFacebookPost>();
            while (timelineWrapper.HasMoreUserFeedItems())
            {
                userFeedBatches.AddRange(timelineWrapper.GetBatchedUserFeed());
            }

            Assert.IsTrue(userFeedBatches.Count == 10);
        }
    }
}
