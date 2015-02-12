//
// Free to redistribute and use.
// Creator: Gentiana Coman, www.gentianacoman.com
//

using SocialMediaAggregator.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaAggregator
{
    /// <summary>
    /// Interface for components responsible with dealing with NewsFeedItems.
    /// </summary>
    public interface INewsFeedView
    {
        void AddNewsItems(IEnumerable<NewsFeedItem> newsItems);
        void LoadNewsItems(IEnumerable<NewsFeedItem> newsItems);
        void EndFeed();
    }
}
