namespace Problems.LeetCode
{
    public class SearchInsertPosition
    {
        public int SearchInsert(int[] nums, int target)
        {
            
            var start = 0;
            var end = nums.Length -1;
            while (true)
            {
                
                
                var mid = (end - start) / 2 +start;
                if (nums[mid] == target)
                {
                    return mid;
                }
                if (start == end )
                {
                    if (target > nums[start])
                    {
                        return start + 1;
                    }
                    
                    return start;
                }

                if (end < start)
                {
                    return end + 1;
                }
                if ( target > nums[mid])
                {
                    start = mid+1;
                }
                else
                {
                    end = mid -1;
                }

                
            }
            
        }
    }
}