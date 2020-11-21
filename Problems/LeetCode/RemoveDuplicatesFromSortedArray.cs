namespace Problems.LeetCode
{
    public class RemoveDuplicatesFromSortedArray
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }
            int prev = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == prev)
                {
                    nums[i] = int.MaxValue;
                }
                else
                {
                    prev = nums[i];
                }
            }

            int length = 1;
            int firstpointerToGap = -1;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != int.MaxValue)
                {
                    length++;
                    if (firstpointerToGap != -1)
                    {
                        nums[firstpointerToGap] = nums[i];
                        firstpointerToGap++;
                    }
                }

                if (nums[i] == int.MaxValue)
                {
                    if (firstpointerToGap == -1)
                    {
                        firstpointerToGap = i;
                    }
                }
            }

            return length;
        } 
    }
}