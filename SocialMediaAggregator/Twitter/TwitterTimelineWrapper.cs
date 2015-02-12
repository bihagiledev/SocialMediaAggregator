//
// Free to redistribute and use.
// Creator: Gentiana Coman, www.gentianacoman.com
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tweetinvi;
using Tweetinvi.Core.Interfaces.DTO;

namespace SocialMediaAggregator.Twitter
{
    /// <summary>
    /// Interface to help with testing.
    /// </summary>
    public interface ITwitterTimelineWrapper
    {
        IList<SimplifiedTweet> GetBatchedHomeTweets(int count);
        IList<SimplifiedTweet> GetBatchedUserTweets(int count);
        bool HasMoreHomeTweets();
        bool HasMoreUserTweets();
    }

    /// <summary>
    /// This class helps in obtaining Twitter timelines in batches by keeping track of the maxId
    /// of previous calls. When a timeline is consumed, an empty enumerable is returned.
    /// A timeline cannot be reset and in order to query from the beginning a new timeline
    /// should be instantiated.
    /// </summary>
    public class TwitterTimelineWrapper : ITwitterTimelineWrapper
    {
        #region Constants

        private const long StartId = -1;
        private const long EndMaxId = -2;
        private const string BaseTimelineQuery = @"https://api.twitter.com/1.1/statuses/";
        private const string UserTimelineQuery = BaseTimelineQuery + "user_timeline.json?count={0}";
        private const string UserTimelineQuerySegmented = UserTimelineQuery + "&max_id={1}";
        private const string HomeTimelineQuery = BaseTimelineQuery + "home_timeline.json?count={0}";
        private const string HomeTimelineQuerySegmented = HomeTimelineQuery + "&max_id={1}";

        #endregion

        private long m_lastUserMaxId = StartId;
        private long m_lastHomeMaxId = StartId;

        public IList<SimplifiedTweet> GetBatchedUserTweets(int count = 20)
        {
            string userTimelineQuery = m_lastUserMaxId == StartId ?
                String.Format(UserTimelineQuery, count) :
                String.Format(UserTimelineQuerySegmented, count, m_lastUserMaxId);
            return GetBatchedTweets(count, userTimelineQuery, ref m_lastUserMaxId);
        }

        public IList<SimplifiedTweet> GetBatchedHomeTweets(int count = 20)
        {
            string homeTimelineQuery = m_lastHomeMaxId == StartId ?
                 String.Format(HomeTimelineQuery, count) :
                 String.Format(HomeTimelineQuerySegmented, count, m_lastHomeMaxId);
            return GetBatchedTweets(count, homeTimelineQuery, ref m_lastHomeMaxId);
        }

        public bool HasMoreHomeTweets()
        {
            return m_lastHomeMaxId != EndMaxId;
        }

        public bool HasMoreUserTweets()
        {
            return m_lastUserMaxId != EndMaxId;
        }

        private IList<SimplifiedTweet> GetBatchedTweets(int count, string query, ref long maxId)
        {
            if (maxId == EndMaxId)
            {
                return new List<SimplifiedTweet>();
            }

            var returnedTweets = ExecuteGETQueryGetTweets(query);

            if (returnedTweets.Count == 0)
            {
                // We have reached the end of the stream of tweets.
                maxId = EndMaxId;
                return new List<SimplifiedTweet>();
            }

            maxId = returnedTweets.Min(tweet => tweet.Id) - 1;
            return returnedTweets.Select(tweet => new SimplifiedTweet(tweet)).ToList();
        }

        private static IList<ITweetDTO> ExecuteGETQueryGetTweets(string query)
        {
            var returnedTweets = TwitterAccessor.ExecuteGETQuery<IList<ITweetDTO>>(query);

            if (returnedTweets == null)
            {
                new List<ITweetDTO>();
            }

            if (ExceptionHandler.GetLastException() != null)
            {
                // Something bad happened.
                throw ExceptionHandler.GetLastException().WebException;
            }

            return returnedTweets;
        }
    }
}
