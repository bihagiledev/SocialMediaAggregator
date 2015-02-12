//
// Free to redistribute and use.
// Creator: Gentiana Coman, www.gentianacoman.com
//

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Tweetinvi;
using Tweetinvi.Core.Interfaces;
using Tweetinvi.Core.Interfaces.DTO;
using Tweetinvi.Core.Interfaces.DTO.QueryDTO;

namespace SocialMediaAggregator.Twitter
{
    /// <summary>
    /// Interface to simplify testing.
    /// </summary>
    public interface ITwitterClientWrapper
    {
        SimplifiedTweet PostTweet(string message);

        SimplifiedTweet PostTweetWithMedia(string message, string itemPath);

        SimplifiedTwitterUser AboutMe();

        ITwitterTimelineWrapper GetTimelineWrapper();

        IList<SimplifiedTwitterUser> GetFriends();
    }

    /// <summary>
    /// Wrapper class for simple operations throught the Twitter Api.
    /// </summary>
    public class TwitterClientWrapper : ITwitterClientWrapper
    {
        ITwitterTimelineWrapper m_timelineWrapper;

        public TwitterClientWrapper()
        {
            TwitterCredentials.SetCredentials(
                TwitterClientCredentials.AccessToken,
                TwitterClientCredentials.AccessTokenSecret,
                TwitterClientCredentials.ConsumerKey,
                TwitterClientCredentials.ConsumerSecret);

            m_timelineWrapper = new TwitterTimelineWrapper();
        }

        public SimplifiedTweet PostTweet(string message)
        {
            // Using Static Tweet class
            var tweet = Tweet.PublishTweet(message);
            if (tweet == null || ExceptionHandler.GetLastException() != null)
            {
                throw ExceptionHandler.GetLastException().WebException;
            }

            return new SimplifiedTweet(tweet);
        }

        public SimplifiedTweet PostTweetWithMedia(string message, string itemPath)
        {
            var fileData = File.ReadAllBytes(itemPath);
            var tweet = Tweet.PublishTweetWithMedia(message, fileData);
            if (tweet == null || ExceptionHandler.GetLastException() != null)
            {
                throw ExceptionHandler.GetLastException().WebException;
            }

            return new SimplifiedTweet(tweet);
        }

        public SimplifiedTwitterUser AboutMe()
        {
            return new SimplifiedTwitterUser(User.GetLoggedUser());
        }

        public ITwitterTimelineWrapper GetTimelineWrapper()
        {
            return m_timelineWrapper;
        }

        public IList<SimplifiedTwitterUser> GetFriends()
        {
            var friends = User.GetLoggedUser().GetFriends(50);
            return friends.Select(friend => new SimplifiedTwitterUser(friend)).ToList();
        }
    }
}
