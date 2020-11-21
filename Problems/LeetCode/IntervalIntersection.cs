using System;
using System.Collections.Generic;

namespace Problems.LeetCode
{
    public class IntervalIntersection
    {
        public int[][] Solve(int[][] A, int[][] B)
        {
             List<int[]> list = new List<int[]>();
             int i = 0;
             int j = 0;
             while (i < A.Length && j < B.Length)
             {
                 if ((A[i][0] >= B[j][0] && A[i][0] <= B[j][1]) || (B[j][0] >= A[i][0] && B[j][0] <= A[i][1]))
                 {
                     list.Add(new []{Math.Max(A[i][0],B[j][0]),Math.Min(A[i][1],B[j][1])});
                 }

                 if (j < B.Length -1)
                 {
                     if (A[i][1] > B[j][1] && !(A[i][1] < B[j+1][0]))
                     {
                         j++;
                         continue;
                     }
                 }
                 

                 if (i < A.Length -1)
                 {
                     if (B[j][1] > A[i][1] &&  ! (B[j][1] < A[i+1][0]))
                     {
                         i++;
                         continue;
                     }
                 }
                 

                 i++;
                 j++;
             }

              

             return list.ToArray();
        }
    }
}