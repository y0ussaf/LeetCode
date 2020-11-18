namespace Problems.LeetCode
{
    public class SubarraySum
    {
        public int Solve(int[] nums, int k)
        {
            int sum = 0;
            int ans = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int j = i;
                while (j < nums.Length)
                {
                    sum += nums[j];
                    j++;
                    if (sum == k)
                    {
                        ans++;
                    }
                }
                sum = 0;
            }

            return ans;
        }
    }
}