using System.Collections.Generic;

namespace Problems.LeetCode
{
    public class TwoSum
    {
        public static int[] Solve(int[] nums, int target)
        {
            Dictionary<int,int> k = new Dictionary<int, int>();
            int[] ans = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                if (k.ContainsKey(nums[i]))
                {
                    ans[0] = k[nums[i]];
                    ans[1]= i;
                    break;
                }

                k[target - nums[i]] = i;
            }

            return ans;
        }
    }
}