using System;

namespace Problems.LeetCode
{
    public class LastStoneWeight
    {
        public int Solve(int[] nums)
        {
            
            Array.Sort(nums);
            for (int i = nums.Length -1; i >= 0; i--)
            {
                if (nums[i] == -1)
                {
                    continue;
                }

                if (nums[i] == nums[i-1])
                {
                    nums[i - 1] = -1;
                }
                else
                {
                    nums[i - 1] -= nums[i];
                }
            }

            if (nums[0] != -1)
            {
                return 0;
            }

            return nums[0];
        }
    }
}