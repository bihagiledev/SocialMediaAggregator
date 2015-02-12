using Facebook;
using SocialMediaAggregator.Facebook;
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
    public class TestFacebookTimelineWrapper : IFacebookTimelineWrapper
    {
        private int m_currentNewsFeedPage = 0;
        private int m_currentUserFeedPage = 0;
        private int m_maxPage;
        private int m_pageSize;

        public TestFacebookTimelineWrapper(int maxPage = 2, int pageSize = 5)
        {
            m_maxPage = maxPage;
            m_pageSize = pageSize;
        }

        public IEnumerable<SimplifiedFacebookPost> GetBatchedNewsFeed()
        {
            List<SimplifiedFacebookPost> results = new List<SimplifiedFacebookPost>();
            if (!HasMoreNewsFeedItems())
                return results;

            for (int i = 0; i < m_pageSize; i++)
            {
                results.Add(GetPost(i));
            }

            m_currentNewsFeedPage++;
            return results;
        }


        private SimplifiedFacebookPost GetPost(int index)
        {
            Random random = new Random(index);
            return new SimplifiedFacebookPost()
            {
                Message = "NewsText" + index,
                User = GetUser(index),
                Type = "post",
                Shares = random.Next() % 1000,
                Likes = random.Next() % 1000,
                CreatedTime = DateTime.Now
            };
        }

        private SimplifiedFacebookUser GetUser(int index)
        {
            return new SimplifiedFacebookUser()
            {
                Id = index.ToString(),
                Description = "Bio" + index,
                Gender = "male",
                Name = "User" + index,
                Link = "https://www.facebook.com/" + index,
                ProfileImageUrl = "http://dummy_avatar.jpg"
            };
        }

        public IEnumerable<SimplifiedFacebookPost> GetBatchedUserFeed()
        {
            List<SimplifiedFacebookPost> results = new List<SimplifiedFacebookPost>();
            if (!HasMoreUserFeedItems())
                return results;

            for (int i = 0; i < m_pageSize; i++)
            {
                results.Add(GetPost(i));
            }

            m_currentUserFeedPage++;
            return results;
        }

        public bool HasMoreNewsFeedItems()
        {
            return m_currentNewsFeedPage != m_maxPage;
        }

        public bool HasMoreUserFeedItems()
        {
            return m_currentUserFeedPage != m_maxPage;
        }
    }

    public class TestFacebookTimelineWrapperFactory : IFacebookTimelineWrapperFactory
    {
        private int m_maxPage;
        private int m_pageSize;

        public TestFacebookTimelineWrapperFactory(int maxPage, int pageSize)
        {
            m_maxPage = maxPage;
            m_pageSize = pageSize;
        }

        public IFacebookTimelineWrapper CreateTimelineWrapper(FacebookClient facebookClient)
        {
            return new TestFacebookTimelineWrapper(m_maxPage, m_pageSize);
        }
    }
}
