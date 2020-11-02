using System;
using System.Collections.Generic;
using System.Linq;

namespace Problems.LeetCode
{
    public class FirstMissingPositive
    {
        public static int Solve(int[] nums)
        {
                HashSet<int> hashSet = new HashSet<int>();
                foreach (var n in nums)
                {
                    if (n>0)
                    {
                        hashSet.Add(n);
                    }
                }
           
                for (int i = 1; i <= nums.Length; i++)
                {
                    if (!hashSet.Contains(i))
                    {
                        return i;
                    }
                }
           
                return nums.Length +1;
        }
    }
}