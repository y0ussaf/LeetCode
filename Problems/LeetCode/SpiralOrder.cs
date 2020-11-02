using System;
using System.Collections.Generic;

namespace Problems.LeetCode
{
    public class SpiralOrder
    {
        public static void Go(int[][] matrix ,int skip, List<int> list)
        {
            
            for (int i = skip; i < matrix[0].Length - skip; i++)
            {
                 list.Add(matrix[skip][i]);
            }

            for (int i = skip +1 ; i < matrix.Length - skip; i++)
            {
                 list.Add(matrix[i][matrix[0].Length -1 - skip]);
            }

            for (int i = matrix[0].Length -2 -skip; i >= skip; i--)
            {
                 list.Add(matrix[matrix.Length -1 - skip][i]);
            }

            for (int i = matrix.Length -2 -skip; i > skip; i--)
            {
                 list.Add(matrix[i][skip]);
            }
        }
        public static IList<int> Solve(int[][] matrix)
        {
            List<int> list = new List<int>();
            if (matrix.Length == 0 ||(matrix[0].Length == 0))
            {
                return list;
            }
            var skip = 0;
            while (true)
            {
                if (2*skip >= matrix.Length)
                {
                    return list;
                }

                if (2*skip >= matrix[0].Length)
                {
                    return list;
                }
                if (matrix.Length - 2*skip == 1)
                {
                    for (int i = skip; i < matrix[0].Length -skip; i++)
                    {
                        list.Add(matrix[skip][i]);
                    }

                    return list;
                }

                if (matrix[0].Length - 2* skip == 1)
                {
                    for (int i = skip; i < matrix.Length - skip; i++)
                    {
                        list.Add(matrix[i][skip]);
                    }

                    return list;
                }
                Go(matrix,skip,list);
                skip++;
            }
        }
    }
}