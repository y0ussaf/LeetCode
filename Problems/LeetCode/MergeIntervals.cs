using System;
using System.Collections.Generic;
using System.Linq;

namespace Problems.LeetCode
{
    public class MergeIntervals
    {
        public static int[][] Solve(int[][] intervals)
        {
            if (intervals == null )
            {
                return null;
            }
            var ans = new int[intervals.Length][];
            if (intervals.Length == 0)
            {
                return ans;
            }
            Array.Sort(intervals,(ints, ints1) => ints[0].CompareTo(ints1[0]));
            int j = 0;
            int[] merged = {intervals[0][0], intervals[0][1]};
            for (int i = 1; i < intervals.Length; i++)
            {
                if (intervals[i][0]<= merged[1])
                {
                    merged[1] = Math.Max(intervals[i][1], merged[1]);
                    
                }
                else
                {
                    ans[j] = merged;
                    merged = intervals[i];
                    j++;
                }
            }
            ans[j] = merged;
            return ans.Where(a => a!= null).ToArray();
        }
    }
}