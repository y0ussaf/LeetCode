using System.Collections.Generic;

namespace Problems.LeetCode
{
    public class Subsets
    {
        public void Go(int [] nums,IList<IList<int>> ans,List<int> list,int start = 0)
        {
            if (list.Count == 2)
            {
                ans.Add(list);
                return;
            }
            if (start > nums.Length -1)
            {
                return;
            }
            for (int i = start; i < nums.Length; i++)
            {
                List<int> a = new List<int>(list) {nums[i]};
                Go(nums,ans,a,i+1);
            }
        }
        public IList<IList<int>> Solve(int[] nums) {
            IList<IList<int>> ans = new List<IList<int>>();
            Go(nums,ans,new List<int>());
            return ans;
        }
    }
}