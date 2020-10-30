namespace Problems.LeetCode
{
    public class SortColors
    {
        
        public static void Solve(int[] nums)
        {
            int p0 = 0;
            int p2 = nums.Length - 1;
            int temp;
            int i = 0;
            while (i<=p2)
            {
                if (nums[i] == 0)
                {
                    temp = nums[p0];
                    nums[p0] = 0;
                    nums[i] = temp;
                    p0++;
                    i++;
                }
                else if (nums[i] == 2  )
                {
                    temp = nums[p2];
                    nums[p2] = 2; nums[i] = temp;
                    p2--;
                }
                else
                {
                    i++;

                }
            }
               
 

        }
    }
}