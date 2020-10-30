using System;
using System.Collections.Generic;

namespace Problems.LeetCode
{
    
    public class Permutations
    {
        public static  IList<IList<int>> Helper(int[] nums, int start=0)
        {
            IList<IList<int>> k = new List<IList<int>>();
            if (start == nums.Length -1)
            {
                k.Add(new List<int> {nums[start]});
                return k;

            }
            for (int i = start; i < nums.Length; i++)
            {
                var temp = nums[start];
                nums[start] = nums[i];
                nums[i] = temp;
                var result = Helper(nums, start+1);
                List<int> list;
                foreach (var c in result)
                { 
                    list = new List<int>();
                    list.Add(nums[start]);
                    list.AddRange(c);
                    k.Add(list);

                }
                nums[i] = nums[start];
                nums[start] = temp;
                
            }

            return k;
        }
        public static IList<IList<int>> Solve(int[] nums)
        {
            return Helper(new[] {1, 2, 3});
        }
    }
}