namespace Problems.LeetCode
{
    public class NonDecreasingArray
    {
        public static bool Solve(int[] nums)
        {
            int count = 0;
            for (int i = 0; i < nums.Length -1; i++)
            {
                if (i >0)
                {
                    if (nums[i] < nums[i-1])
                    {
                        if (nums[i-1] > nums[i+1])
                        {
                            return false;
                        }

                        count++;
                    }

                }
               

                if (count == 2)
                {
                    return false;
                }
            }

            return true;
        }
    }
}