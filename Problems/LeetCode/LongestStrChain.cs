using System;
using System.Collections.Generic;

namespace Problems.LeetCode
{
    public class LongestStrChain
    {
        static Dictionary<string,int> _cache = new Dictionary<string, int>();
        static int Go(string word,HashSet<string> hashSet)
        {
            if (_cache.ContainsKey(word))
            {
                return _cache[word];
            }
            if (word.Length == 1)
            {
                return 1;
            }
            int ans = 0;
            int res;
            for (int i = 0; i < word.Length; i++)
            {
                if (hashSet.Contains(word.Remove(i, 1)))
                {
                    res = Go(word.Remove(i, 1), hashSet);
                    ans = res > ans ? res : ans;
                }
            }

            _cache[word] = ans + 1;
            return ans + 1;
        }
        public static int Solve(string[] words)
        {
            HashSet<string> hashSet = new HashSet<string>();
            foreach (var word in words)
            {
                hashSet.Add(word);
            }
            
            int ans = 0;
            int res;
            foreach (var word in words)
            {
                res = Go(word,hashSet);
                ans = res > ans ? res : ans;
            }
            return ans;
        }
        
    }
}