using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Problems.LeetCode
{
    public class GroupAnagrams
    {
        public static IList<IList<string>> Solve(string[] strings)
        {
            Dictionary<string,List<string>> ans = new Dictionary<string, List<string>>();
            char[] s;
            string sorted = string.Empty;
            foreach (var str in strings)
            {
                s = str.ToCharArray();
                Array.Sort(s);
                sorted = string.Join(string.Empty, s);
                if (!ans.TryGetValue(sorted,out var list)) {
                    list = new List<string>();
                    ans[sorted] = list;
                }
                list.Add(str);
            }

            var keys = ans.Keys;
            IList<IList<string>> y = new List<IList<string>>();
            foreach (var key in keys)
            {
                y.Add(ans[key]);
            }
            return y;
        }
    }
}