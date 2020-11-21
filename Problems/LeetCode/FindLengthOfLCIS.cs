namespace Problems.LeetCode
{
    public class FindLengthOfLCIS
    {
        public int Solve(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }
            int ans = 0;
            int l = 0;
            int r = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] <= nums[i-1])
                {
                    if (r -l +1 > ans)
                    {
                        ans = r - l + 1;
                    }

                    l = i;
                    r = i;
                }
                else
                {
                    r++;
                }
            }
            if (r -l +1 > ans)
            {
                ans = r - l + 1;
            }
            return ans;
        }
    }
}