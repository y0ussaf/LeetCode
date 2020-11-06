using System.Collections.Generic;

namespace Problems.LeetCode
{
    public class LengthOfLongestSubstring
    {
        public static int Solve(string s)
        {
            Dictionary<char,int> hashSet = new Dictionary<char, int>();
            int ans = 0;
            int count = 0;
            int limit = -1;
            for (int i = 0; i < s.Length; i++)
            {
                if (hashSet.ContainsKey(s[i]))
                {
                    if (hashSet[s[i]] > limit)
                    {
                        if (count > ans)
                        {
                            ans = count;
                        }

                        count = i - hashSet[s[i]]  -1;
                        limit = hashSet[s[i]];
                    }
                   
                }

                hashSet[s[i]] = i;
                count++;
            }
           
            if (count != 0)
            {
                ans = count > ans ?  count : ans;
            }
            return ans;
        }
    }
}