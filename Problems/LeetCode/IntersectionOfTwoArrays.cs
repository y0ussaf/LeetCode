using System.Collections.Generic;
using System.Linq;

namespace Problems.LeetCode
{
    public class IntersectionOfTwoArrays
    {
        public int[] Solve(int[] nums1, int[] nums2)
        {
            HashSet<int> k = new HashSet<int>();
            HashSet<int> ans = new HashSet<int>();
            foreach (var n in nums1)
            {
                k.Add(n);
            }

            foreach (var c in nums2)
            {
                if (k.Contains(c))
                {
                    ans.Add(c);
                }
            }

            return ans.ToArray();
        }
    }
}