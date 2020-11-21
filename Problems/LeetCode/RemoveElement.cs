namespace Problems.LeetCode
{
    public class RemoveElement
    {
        public int Solve(int[] nums, int val)
        {
            int pointerToVal = -1;
            int len = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    len++;
                    if (pointerToVal != -1)
                    {
                        nums[pointerToVal] = nums[i];
                        pointerToVal++;
                    }
                }

                if (nums[i] == val)
                {
                    if (pointerToVal == -1)
                    {
                        pointerToVal = i;
                    }
                }
            }

            return len;
        }
    }
}