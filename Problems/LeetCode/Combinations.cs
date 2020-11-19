using System.Collections.Generic;

namespace Problems.LeetCode
{
    public class Combinations
    {
        void Go(int n, int k,List<int> list, IList<IList<int>> ans)
        {
            if (list.Count == k)
            {
                ans.Add(list);
                return;
            }
            int a = n;
            List<int> b;
            while (a != 0)
            {
                b = new List<int>(list){a};
                Go(a-1,k,b,ans);
                a--;
            }
        }
        public IList<IList<int>> Combine(int n, int k) {
            IList<IList<int>> ans = new List<IList<int>>();
            Go(n,k,new List<int>(),ans );
            return ans;
        }
    }
}