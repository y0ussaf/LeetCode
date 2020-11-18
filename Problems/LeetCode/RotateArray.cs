using System;

namespace Problems.LeetCode
{
    public class RotateArray
    {
        public void Rotate(int[] nums, int k)
        {
            int[] copy = new int[nums.Length];
            for (int j = 0; j < nums.Length; j++)
            {
                copy[(j + k) % nums.Length] = nums[j];
            }
            Array.Copy(copy,nums,nums.Length);
        }
        }
    }
