namespace Problems.LeetCode
{
    public class MaximumSubArray
    {
        public static int MaxSubArray(int[] nums)
        {
            int ans = int.MinValue,left=0;
            
            foreach (var num in nums)
            {
                if (left < 0)
                {
                    left = num;
                }
                else
                {
                    left += num;
                }
                if (left > ans)
                {
                    ans = left;
                }
            }
            return ans;

        }
    }
}