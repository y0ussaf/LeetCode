using System;

namespace Problems.LeetCode
{
    public class SearchRange
    {
        public static int[] Solve(int[] nums, int target)
        {

            int[] ans = new int[] {-1, -1};
            if (nums.Length == 0)
            {
                return ans;
            }
            int start = 0;
            int end = nums.Length - 1;
            int mid;
            
            while (true)
            {
                mid = (end - start +1)/2 + start;
                if (start > end)
                {
                    ans[0] = -1;
                    ans[1] = -1;
                    break;
                }
                if (start == end)
                {
                    if (nums[start] == target)
                    {
                        ans[0] = mid;
                    }
                    else
                    {
                        ans[0] = -1;
                    }
                    break;
                }
                if (nums[mid] == target)
                {
                    if (nums[mid] != nums[mid -1])
                    {
                        ans[0] = mid;
                        break;
                    }

                    end = mid -1;
                }
                else
                {
                    if (nums[mid] < target)
                    {
                        start = mid + 1;
                         
                    }
                    else
                    {
                        end = mid - 1;
                    }
                }
            }

            if (ans[0] == -1)
            {
                return ans;
            }
            start = 0;
            end = nums.Length - 1;
            
            while (true)
            {
                mid = (end - start +1)/2 + start;
                if (start > end)
                {
                    ans[0] = -1;
                    ans[1] = -1;
                    break;
                }
                if (start == end)
                {
                    if (nums[start] == target)
                    {
                        ans[1] = mid;
                    }
                    else
                    {
                        ans[1] = -1;
                    }
                    break;
                }
               
                if (nums[mid] == target)
                {
                    if (mid == nums.Length -1)
                    {
                        ans[1] = mid;
                        break;
                    }

                    if (nums[mid] != nums[mid +1])
                    {
                        ans[1] = mid;
                        break;
                    }


                    start = mid +1;
                }
                else
                {
                    if (nums[mid] < target)
                    {
                        start = mid + 1;
                         
                    }
                    else
                    {
                        end = mid - 1;
                    }
                }
            }

            return ans;
        }
    }
}