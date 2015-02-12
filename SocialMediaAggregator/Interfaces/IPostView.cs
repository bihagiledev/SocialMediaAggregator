//
// Free to redistribute and use.
// Creator: Gentiana Coman, www.gentianacoman.com
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaAggregator.Interfaces
{
    /// <summary>
    /// An interface required by any object that handles posting.
    /// </summary>
    public interface IPostView
    {
        void PostSucceeded();
    }
}
