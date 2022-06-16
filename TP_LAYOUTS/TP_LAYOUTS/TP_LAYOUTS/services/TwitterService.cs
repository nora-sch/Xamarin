using System;
using System.Collections.Generic;
using System.Text;
using TP_LAYOUTS.models;

namespace TP_LAYOUTS.services
{
    public class TwitterService : ITwitterService
    {
        public bool authenticate(string username, string password)
        {
            if (username.Equals("cedric") && password.Equals("azertyuiop"))
            {
                return true;
            }
            return false;
        }

        public List<Tweet> getTweets()
        {
            var tweets = new List<Tweet>();
            tweets.Add(new Tweet()
            {
                dateCreation = "Thu Apr 06 15:28:43 +0000 2017",
                identifiant = "850007368138018817",
                identifiantUser = "6253282",
                nomUser = "Twitter API",
                pseudoUser = "twitterapi"
            });
            tweets.Add(new Tweet()
            {
                dateCreation = "Thu Apr 06 15:58:43 +0000 2017",
                identifiant = "850007368138018820",
                identifiantUser = "6253282",
                nomUser = "Twitter API",
                pseudoUser = "twitterapi"
            });
            tweets.Add(new Tweet()
            {
                dateCreation = "Thu Apr 06 16:03:42 +0000 2017",
                identifiant = "850007368138018825",
                identifiantUser = "6253282",
                nomUser = "Twitter API",
                pseudoUser = "twitterapi"
            });
            return tweets;
        }
    }
}
