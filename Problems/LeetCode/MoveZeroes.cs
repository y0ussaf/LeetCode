namespace Problems.LeetCode
{
    public class MoveZeroes
    {
        public static void Solve(int[] nums)
        {
            int a = -1;
             for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    if (a == -1)
                    {
                        a = i;
                    }
                   
                }
                else
                {
                    if (a != -1)
                    {
                        nums[a] = nums[i];
                        nums[i] = 0;
                        if (nums[a+1]== 0)
                        {
                            a++;
                        }
                        else
                        {
                            a = -1;
                        }
                    }
                }
            }

          
        }
    }
}