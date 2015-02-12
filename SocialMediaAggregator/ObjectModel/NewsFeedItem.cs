//
// Free to redistribute and use.
// Creator: Gentiana Coman, www.gentianacoman.com
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaAggregator.ObjectModel
{
    /// <summary>
    /// Object model for a piece of social media news understood by the View interfaces.
    /// </summary>
    public class NewsFeedItem
    {
        public NewsFeedItem() { }

        public string Text { get; set; }
        public string AuthorName { get; set; }
        public string AuthorScreenName { get; set; }
        public DateTime CreateDate { get; set; }
        public long Popularity { get; set; }
        public string AuthorPictureUrl { get; set; }
    }
}
