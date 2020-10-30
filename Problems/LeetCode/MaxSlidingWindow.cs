using System.Collections.Generic;

namespace Problems.LeetCode
{
    public class MaxSlidingWindow
    {
        public static int[] Solve(int[] nums,int k)
        {
            List<int> list = new List<int>();
            var max = nums[0];
            var maxIndex = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if ((nums.Length -i)>=k)
                {
                    for (int j = maxIndex +1; i+j < k; j++)
                    {
                        if (nums[i]> max)
                        {
                            max = nums[j];
                        }
                                
                    }
                            
                    list.Add(max);
                    
                }
                else
                {
                    break;
                }
            }

            return list.ToArray();
        }
    }
}