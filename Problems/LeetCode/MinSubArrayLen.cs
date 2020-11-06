namespace Problems.LeetCode
{
    public class MinSubArrayLen
    {
        public static int Solve(int s, int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return 0;
            }
            int ans = 0;
            int i = 0;
            int j = 0;
            int sum = 0;
            while (i <= nums.Length -1 && j <= nums.Length -1)
            {
                for (int k = j; k <= i; k++)
                {
                    sum += nums[k];
                    
                }

                if (i == nums.Length -1 && sum < s)
                {
                    break;
                }

                if (sum >= s)
                {
                    if (i == j)
                    {
                        return 1;
                    }

                    if (ans != 0)
                    {
                        ans = i - j + 1 < ans ? i - j + 1 : ans;
                    }
                    else
                    {
                        ans = i - j + 1;

                    }

                    j++;
                }
                else
                {
                    i++;
                }
                sum = 0;

            }

            return ans;
        }
    }
}