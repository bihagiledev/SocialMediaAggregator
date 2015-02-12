//
// Free to redistribute and use.
// Creator: Gentiana Coman, www.gentianacoman.com
//

using SocialMediaAggregator.Facebook;
using SocialMediaAggregator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaAggregator.Controllers
{
    /// <summary>
    /// An interface required by any object that controlls posting actions.
    /// </summary>
    public interface IMainPostController
    {
        void Post(IPostView view, string message, string itemPath);
    }

    public abstract class MainControllerBase : IMainPostController
    {
        public abstract IList<string> GetClientNames();

        public abstract void LoadNewsFeed(INewsFeedView view);

        public abstract void SortNewsFeedByPopularity(INewsFeedView view);

        public abstract void SortNewsFeedByDate(INewsFeedView view);

        public abstract void LoadUserFeed(INewsFeedView view);

        public abstract void LoadUserInfo(IUserInfoView view, string clientName);

        public abstract void LoadContacts(IContactListView view);

        public abstract void Post(IPostView view, string message, string itemPath);
    }

    // We are missing an implementation of the MainControllerBase which can act as the brains of the operation.
    // This will be responsible with taking requestes from the UI, executing them and returning the results to the UI.
}
