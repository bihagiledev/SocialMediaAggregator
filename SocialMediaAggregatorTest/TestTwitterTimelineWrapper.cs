using SocialMediaAggregator.Twitter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaAggregatorTest
{
    /// <summary>
    /// This is an example test mock that can be used to simulate paginating through a Facebook feed.
    /// This can be used or extended to help in testing other parts of the system without requiring a connection
    /// to a Facebook server.
    /// </summary>
    public class TestTwitterTimelineWrapper : ITwitterTimelineWrapper
    {
        private int m_currentHomeFeedPage = 0;
        private int m_currentUserFeedPage = 0;
        private int m_maxPage;
        private int m_pageSize;

        public TestTwitterTimelineWrapper(int maxPage = 2, int pageSize = 5)
        {
            m_maxPage = maxPage;
            m_pageSize = pageSize;
        }

        public IList<SimplifiedTweet> GetBatchedHomeTweets(int count)
        {
            List<SimplifiedTweet> results = new List<SimplifiedTweet>();
            if (!HasMoreHomeTweets())
                return results;

            for (int i = 0; i < m_pageSize; i++)
            {
                results.Add(GetPost(i));
            }

            m_currentHomeFeedPage++;
            return results;
        }


        private SimplifiedTweet GetPost(int index)
        {
            Random random = new Random(index);
            return new SimplifiedTweet()
            {
                CreatedAt = DateTime.Now,
                Creator = GetUser(index),
                Id = index.ToString(),
                Text = "Tweet" + index,
                RetweetCount = random.Next() % 1000
            };
        }

        private SimplifiedTwitterUser GetUser(int index)
        {
            Random random = new Random(index);
            return new SimplifiedTwitterUser()
            {
                Name = "Twitter User" + index,
                ScreenName = "Twitter screen user" + index,
                Id = index.ToString(),
                ProfileImageUrl = "http://something",
                Description = "A description",
                FriendsCount = random.Next() % 1000,
                Link = "http://twitter.com"
            };
        }

        public IList<SimplifiedTweet> GetBatchedUserTweets(int count)
        {
            List<SimplifiedTweet> results = new List<SimplifiedTweet>();
            if (!HasMoreUserTweets())
                return results;

            for (int i = 0; i < m_pageSize; i++)
            {
                results.Add(GetPost(i));
            }

            m_currentUserFeedPage++;
            return results;
        }

        public bool HasMoreHomeTweets()
        {
            return m_currentHomeFeedPage != m_maxPage;
        }

        public bool HasMoreUserTweets()
        {
            return m_currentUserFeedPage != m_maxPage;
        }
    }
}
