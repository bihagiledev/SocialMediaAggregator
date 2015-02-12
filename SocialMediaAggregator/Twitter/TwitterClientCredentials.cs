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

namespace SocialMediaAggregator.Twitter
{
    public static class TwitterClientCredentials
    {
        public static string ConsumerSecret
        {
            get { return ConfigurationManager.AppSettings["TwitterConsumerSecret"]; }
        }

        public static string ConsumerKey
        {
            get { return ConfigurationManager.AppSettings["TwitterConsumerKey"]; }
        }

        public static string AccessToken
        {
            get { return ConfigurationManager.AppSettings["TwitterAccessToken"]; }
        }

        public static string AccessTokenSecret
        {
            get { return ConfigurationManager.AppSettings["TwitterAccessTokenSecret"]; }
        }
    }
}
