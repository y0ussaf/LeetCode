using System.Collections.Generic;
using System.Linq;

namespace Problems.LeetCode
{
    public class Twitter
    {
        private List<KeyValuePair<int, int>> _tweets = new List<KeyValuePair<int, int>>();
        private Dictionary<int, Dictionary<int,int>> _followers = new Dictionary<int, Dictionary<int, int>>();
        public void PostTweet(int userId, int tweetId)
        {
            _tweets.Add(new KeyValuePair<int, int>(userId,tweetId));
        }
        public IList<int> GetNewsFeed(int userId) {
            IList<int> list = new List<int>();
            int i = 0;
            int j = _tweets.Count-1;
            while (i<10 && j >=0)
            {
                if(_tweets[j].Key == userId 
                   || (_followers.ContainsKey(_tweets[j].Key) 
                   && _followers[_tweets[j].Key].ContainsKey(userId)))
                {
                    list.Add(_tweets[j].Value);
                    i++;
                }

                j--;
            }

            return list;
        }
        public void Follow(int followerId, int followeeId)
        {
            Dictionary<int, int> followers;
            if (_followers.ContainsKey(followeeId))
            {
                followers = _followers[followeeId];
            }
            else
            {
                followers = new Dictionary<int, int>();
                _followers.Add(followeeId,followers);
            }
            if (!followers.ContainsKey(followerId))
            {
                followers.Add(followerId,followerId);

            }
        }
        
        public void Unfollow(int followerId, int followeeId) {
            if (_followers.ContainsKey(followeeId) && _followers[followeeId].ContainsKey(followerId))
            {
                _followers[followeeId].Remove(followerId);
            }
        }
        
    }
}