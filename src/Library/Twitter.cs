using System;
using TwitterUCU;

namespace UCURide
{
    public class Twitter
    {
        string consumerKey = "CkovShLMNVCY0STsZlcRUFu99";
        string consumerKeySecret = "6rc35cHCyqFQSy4vIIjKiCYu31qqkBBkSS5BRlqeYCt5r7zO5B";
        string accessTokenSecret = "gNytQjJgLvurJekVU0wmBBkrR1Th40sJmTO8JDhiyUkuy";
        string accessToken = "1396065818-MeBf8ybIXA3FpmldORfBMdmrVJLVgijAXJv3B18";


        public void Send(IMessage message)
        {

            var twitter = new TwitterImage(consumerKey, consumerKeySecret, accessToken, accessTokenSecret);
            Console.WriteLine(twitter.PublishToTwitter($"{message.Message}" ,$@"{message.Foto}"));
            //var twitterDirectMessage = new TwitterMessage(consumerKey, consumerKeySecret, accessToken, accessTokenSecret);
            //Console.WriteLine(twitterDirectMessage.SendMessage("Hola!", "380889967"));
        }
       
                
        
    }
    
}