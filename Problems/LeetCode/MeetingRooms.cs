using System;
using System.Collections;
using System.Collections.Generic;

namespace Problems.LeetCode
{
    public class MeetingRooms 
    {
        
        public static int Solve(int[][] meetings)
        {
            Array.Sort(meetings,(arr1, arr2) => arr1[0].CompareTo(arr2[0]));

            int ans = 0;
            int[] k = null;
            foreach (var m in meetings)
            {
                if (k == null)
                {
                    k = new []{m[0],m[1]};
                    ans++;
                }
                else
                {
                    if (m[0]< k[1])
                    {
                        ans++;
                        k[0] = m[0];
                        k[1] = Math.Max(m[1],k[1]);
                    }
                }
            }

            return ans;
        }

        
    }
}