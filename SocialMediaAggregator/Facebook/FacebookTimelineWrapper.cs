using Facebook;
using System;
using System.Collections.Generic;
//
// Free to redistribute and use.
// Creator: Gentiana Coman, www.gentianacoman.com
//

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaAggregator.Facebook
{
    public interface IFacebookTimelineWrapperFactory
    {
        IFacebookTimelineWrapper CreateTimelineWrapper(FacebookClient facebookClient);
    }

    public interface IFacebookTimelineWrapper
    {
        IEnumerable<SimplifiedFacebookPost> GetBatchedNewsFeed();
        IEnumerable<SimplifiedFacebookPost> GetBatchedUserFeed();
        bool HasMoreNewsFeedItems();
        bool HasMoreUserFeedItems();
    }

    public class FacebookTimelineWrapperFactory : IFacebookTimelineWrapperFactory
    {
        public FacebookTimelineWrapperFactory() { }

        public IFacebookTimelineWrapper CreateTimelineWrapper(FacebookClient facebookClient)
        {
            return new FacebookTimelineWrapper(facebookClient);
        }
    }

    /// <summary>
    /// This class helps in obtaining Facebook timelines in batches by keeping track of the pagination tokens
    /// of previous calls. When a timeline is consumed, an empty enumerable is returned.
    /// A timeline cannot be reset and in order to query from the beginning a new timeline
    /// should be instantiated.
    /// </summary>
    public class FacebookTimelineWrapper : IFacebookTimelineWrapper
    {
        FacebookClient m_facebookClient;
        string m_lastTimelineToken = UserTimelineQuery;
        string m_lastNewsFeedToken = NewsFeedQuery;

        private const string UserTimelineQuery = "/me/feed?fields=created_time,from,message,type,shares,likes.limit(1).summary(true)&limit=15";
        private const string NewsFeedQuery = "/me/home?fields=created_time,from,message,type,shares,likes.limit(1).summary(true)&limit=15";

        public FacebookTimelineWrapper(FacebookClient facebookClient)
        {
            m_facebookClient = facebookClient;
        }

        public IEnumerable<SimplifiedFacebookPost> GetBatchedNewsFeed()
        {
            if (m_lastNewsFeedToken == null)
                return new List<SimplifiedFacebookPost>();

            string nextToken;
            IEnumerable<SimplifiedFacebookPost> posts;
            GetPosts(m_lastNewsFeedToken, out posts, out nextToken);
            m_lastNewsFeedToken = nextToken;

            return posts;
        }

        public IEnumerable<SimplifiedFacebookPost> GetBatchedUserFeed()
        {
            if (m_lastTimelineToken == null)
                return new List<SimplifiedFacebookPost>();

            string nextToken;
            IEnumerable<SimplifiedFacebookPost> posts;
            GetPosts(m_lastTimelineToken, out posts, out nextToken);
            m_lastTimelineToken = nextToken;

            return posts;
        }

        public bool HasMoreNewsFeedItems()
        {
            return m_lastNewsFeedToken != null;
        }

        public bool HasMoreUserFeedItems()
        {
            return m_lastTimelineToken != null;
        }

        private void GetPosts(string query, out IEnumerable<SimplifiedFacebookPost> posts, out string lastToken)
        {
            posts = new List<SimplifiedFacebookPost>();
            lastToken = null;
            dynamic result = m_facebookClient.Get(query);
            if (result.data == null || result.data.Count == 0)
            {
                return;
            }

            var data = result.data as IEnumerable<dynamic>;
            var simplifiedPosts = data.Select(item => new SimplifiedFacebookPost(item));
            posts = simplifiedPosts.Where(item => item.Message != null);

            if (result.paging != null && result.paging.next != null)
            {
                lastToken = result.paging.next;
            }
        }
    }
}
