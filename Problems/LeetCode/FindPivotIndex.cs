using System;
using System.Collections.Generic;

namespace Problems.LeetCode
{
    public class FindPivotIndex
    {
        public int PivotIndex(int[] nums)
        {
            int sum = 0;
            foreach (var t in nums)
            {
                sum += t;
            }

            int left = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (left == sum - left - nums[i])
                {
                    return i;
                }

                left += nums[i];
            }
            return -1;
        }
    }
}