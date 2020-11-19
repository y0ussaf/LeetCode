using System;
using System.Collections.Generic;

namespace Problems.LeetCode
{
    public class JumpGameII
    {

       
        public int Solve(int[] nums)
        {
            if (nums.Length == 0 || nums.Length == 1)
            {
                return 0;
            }
            int ans = 0;
            int start = 0;
            int end = 0;
            
            while (true)
            {
                int canReach = -1;
                for (int i = start; i <= end; i++)
                {
                    canReach = Math.Max(canReach, nums[i] + i);
                }

                ans += 1;
                start = end + 1;
                end = canReach;
                if (canReach >= nums.Length-1)
                {
                    break;   
                }
            }

            return ans;
        }
    }
}