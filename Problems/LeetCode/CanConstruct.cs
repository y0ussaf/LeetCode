using System.Collections.Generic;

namespace Problems.LeetCode
{
    public class CanConstruct
    {
        public static bool Solve(string ransomNote, string magazine)
        {
            Dictionary<char,int> d = new Dictionary<char, int>();
            foreach (var c in magazine)
            {
                if (!d.ContainsKey(c))
                {
                    d.Add(c,0);
                }

                d[c] = d[c] + 1;
            }

            foreach (var r in ransomNote)
            {
                if (!d.ContainsKey(r) || d[r] == 0)
                {
                    return false;

                }
                
                d[r] = d[r] - 1;
            }
            return true;
        }
    }
}