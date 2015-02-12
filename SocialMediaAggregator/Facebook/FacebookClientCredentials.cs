//
// Free to redistribute and use.
// Creator: Gentiana Coman, www.gentianacoman.com
//

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaAggregator.Facebook
{
    public static class FacebookClientCredentials
    {
        public static string ApplicationId
        {
            get
            {
                return ConfigurationManager.AppSettings["FBApplicationId"];
            }
        }

        public static string AppSecret
        {
            get
            {
                return ConfigurationManager.AppSettings["FBApplicationSecret"];
            }
        }

        public static string AccessToken
        {
            get
            {
                return ConfigurationManager.AppSettings["FBAccessToken"];
            }
        }
    }
}
