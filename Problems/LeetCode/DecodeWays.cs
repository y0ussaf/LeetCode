using System.Collections.Generic;

namespace Problems.LeetCode
{
    public class DecodeWays
    {
        public static Dictionary<int,int> _cache = new Dictionary<int, int>();
        public static int Go(string s,int skip = 0)
        {
            if (_cache.ContainsKey(skip))
            {
                return _cache[skip];
            }
            if (skip == s.Length)
            {
                return 1;
            }
            if (s[skip] == '0')
            {
                return 0;
            }
     
            if (skip +2 <=s.Length)
            {
                if (s[skip] == '1' || (s[skip] == '2' &&  int.Parse(s[skip+1].ToString()) <= 6))
                {
                    _cache.Add(skip, Go(s, skip + 1) + Go(s, skip + 2));
                    return _cache[skip];
                }
            }
          
            return Go(s, skip + 1);
        }

        public  int Solve(string s, int skip = 0)
        {
            if (_cache.ContainsKey(skip))
            {
                return _cache[skip];
            }
            if (skip == s.Length)
            {
                return 1;
            }
            if (s[skip] == '0')
            {
                return 0;
            }
            if (s[skip] == '1')
            {
                if (skip +2 <=s.Length)
                {
                    _cache.Add(skip, Go(s, skip + 1) + Go(s, skip + 2));
                    return _cache[skip];
                }
            }
            if (s[skip] == '2')
            {
                if (skip +2 <= s.Length && int.Parse(s[skip+1].ToString()) <= 6) 
                {
                    _cache.Add(skip, Go(s, skip + 1) + Go(s, skip + 2));
                    return _cache[skip];
                }
            }
            return Go(s, skip + 1);
        }
    }
}