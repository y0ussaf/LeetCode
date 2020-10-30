using System;
using System.Collections.Generic;

namespace Problems.LeetCode
{
    public class ProductExceptSelf
    {
        public static int [] Solve(int[] nums)
        {
            int[] c = new int[nums.Length];
            int[] ans = new int[nums.Length];
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                if (i == nums.Length -1 )
                {
                    c[ nums.Length -1 - i] = nums[i];
                }
                else
                {
                     c[ nums.Length -1- i] = (c[nums.Length -2 -i] * nums[i]);
                }
            }

            int p = 1;
            for (int i = 0; i < nums.Length; i++)
            {
                
                if (i == 0)
                {
                    ans[i] = c[nums.Length -2];
                }
                else if (i == nums.Length -1)
                {
                    ans[i] = p;
                }
                else
                {
                    ans[i] = p * c[nums.Length -2 - i];

                }
                p *= nums[i];

            }
            return ans;
        }
    }
}