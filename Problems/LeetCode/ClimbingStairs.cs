using System.Collections.Generic;

namespace Problems.LeetCode
{
    public class ClimbingStairs
    {
        static Dictionary<int,int> _cache = new Dictionary<int, int>();
        public static int Solve(int n)
        {
            if (_cache.ContainsKey(n))
            {
                return _cache[n];
            }
            if (n == 0)
            {
                return 1;
            }
            if (n == 1)
            {
                return 1;
            }
            int k = Solve(n - 1) + Solve(n - 2);
            _cache[n] = k;
            return k;
        }
    }
}