using System.Collections.Generic;

namespace Problems.LeetCode
{
    public class KthLargest
    {
        public List<int> List = new List<int>();
        public int k;
        public KthLargest(int k, int[] nums) {
            List.AddRange(nums);
            List.Sort();
            this.k = k;
        }
    
        public int Add(int val) {
            SearchInsertPosition insertPosition = new SearchInsertPosition();
            var arr = List.ToArray();
            var pos = insertPosition.SearchInsert(arr, val);
            List.RemoveRange(pos, List.Count - pos);
            List.Add(val);
            List.AddRange(arr[pos..]);
            return List[^k];
        }
    }
}