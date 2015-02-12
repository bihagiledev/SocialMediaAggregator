//
// Free to redistribute and use.
// Creator: Gentiana Coman, www.gentianacoman.com
//

using Facebook;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocialMediaAggregator.Facebook
{

    /// <summary>
    /// Wrapper class for simple operations though the Facebook GraphApi.
    /// Note: This does not implement a method for obtaining friends of a user
    /// because the public GraphApi does not expose that.
    /// </summary>
    public class FacebookClientWrapper
    {
        #region Members

        private FacebookClient m_facebookClient;
        private IFacebookTimelineWrapper m_timelineWrapper;

        private const string PostPath = "me/feed";
        private const string PhotosPath = "me/photos";

        #endregion

        public FacebookClientWrapper()
            : this(new FacebookClient(FacebookClientCredentials.AccessToken), new FacebookTimelineWrapperFactory())
        {
        }

        public FacebookClientWrapper(IFacebookTimelineWrapperFactory timelineFactory)
            : this(new FacebookClient(FacebookClientCredentials.AccessToken), timelineFactory)
        {
        }

        public FacebookClientWrapper(FacebookClient facebookClient)
            : this(facebookClient, new FacebookTimelineWrapperFactory())
        {
        }

        public FacebookClientWrapper(FacebookClient facebookClient, IFacebookTimelineWrapperFactory timelineFactory)
        {
            m_facebookClient = facebookClient;
            m_timelineWrapper = timelineFactory.CreateTimelineWrapper(facebookClient);
        }

        public SimplifiedFacebookPost Post(string message)
        {
            Debug.Assert(m_facebookClient != null, "Expected Facebook client to have been initialized.");
            dynamic result = m_facebookClient.Post(PostPath, new { message = message });

            return new SimplifiedFacebookPost(result);
        }

        public SimplifiedFacebookPost Post(string message, string itemPath)
        {
            Debug.Assert(m_facebookClient != null, "Expected Facebook client to have been initialized.");
            dynamic result;
            using (var file = new FacebookMediaStream
            {
                ContentType = "image/jpeg",
                FileName = Path.GetFileName(itemPath)
            }.SetValue(File.OpenRead(itemPath)))
            {
                result = m_facebookClient.Post(PhotosPath,
                    new { message = message, file });
            }

            return new SimplifiedFacebookPost(result);
        }

        public SimplifiedFacebookUser GetMe()
        {
            Debug.Assert(m_facebookClient != null, "Expected Facebook client to have been initialized.");
            dynamic result = m_facebookClient.Get("me");
            dynamic pictureResult = m_facebookClient.Get("me/picture?redirect=false");
            result.picture = pictureResult.data;

            return new SimplifiedFacebookUser(result);
        }

        public IFacebookTimelineWrapper GetTimelineWrapper()
        {
            return m_timelineWrapper;
        }
    }
}
