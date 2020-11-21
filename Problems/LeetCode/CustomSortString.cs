using System.Collections.Generic;

namespace Problems.LeetCode
{
    public class CustomSortString
    {
        public string Solve(string S, string T)
        {
            string ans = string.Empty;
            Dictionary<char,int> dictionary = new Dictionary<char, int>();
            foreach (var c in T)
            {
                if (!dictionary.ContainsKey(c))
                {
                    dictionary.Add(c,0);
                }

                dictionary[c]++;
            }

            foreach (var c in S)
            {
                if (dictionary.ContainsKey(c))
                {
                    int repeat = dictionary[c];
                    ans+= new string(c,repeat);
                    dictionary.Remove(c);
                }
            }

            foreach (var pair in dictionary)
            {
                ans+= new string(pair.Key,pair.Value);
            }
            return ans;
        }
        
    }
}