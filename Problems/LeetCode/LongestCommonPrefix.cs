using System.Collections.Generic;

namespace Problems.LeetCode
{
    public class LongestCommonPrefix
    {
        public string Solve(string[] strs)
        {
            string prefix = string.Empty;
            if (strs.Length == 0)
            {
                return prefix;
            }
            int j = 0;
            bool continuee = true;
            while (true)
            {
                if (j > strs[0].Length -1)
                {
                    break;
                }
                char prev = strs[0][j];
                for (int i = 1; i < strs.Length; i++)
                {
                    
                    if (j > strs[i].Length -1 || strs[i][j] != prev)
                    {
                        continuee = false;
                        break;
                    }
                }

                if (!continuee)
                {
                    break;
                }

                j++;
                prefix += prev;
            }

            return prefix;
        }
    }
}