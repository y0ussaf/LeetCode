using System;

namespace Problems.LeetCode
{
    public class SortedSquares
    {
        public int[] Solve(int[] A)
        {
            int [] ans = new int[A.Length];
            int indexNegative = -1;
            int indexPositive = -1;
            int zeroCount = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == 0)
                {
                    zeroCount++;
                }
                if (A[i] < 0)
                {
                    indexNegative = i;
                }

                if (A[i] > 0 && indexPositive == -1)
                {
                    indexPositive = i;
                }
            }

            if (zeroCount == A.Length)
            {
                return ans;
            }
            int j = zeroCount;
            while (true)
            {
                int sq1;
                int sq2;
                if (indexNegative < 0)
                {
                    while (indexPositive <= A.Length -1)
                    {
                        sq2 = (int) Math.Pow(A[indexPositive], 2);
                        ans[j] = sq2;
                        j++;
                        indexPositive++;
                    }
                    break;
                }

                if (indexPositive > A.Length -1 || indexPositive == -1)
                {
                    while (indexNegative >=0)
                    {
                        sq1 = (int) Math.Pow(A[indexNegative], 2);
                        ans[j] = sq1;
                        j++;
                        indexNegative--;
                    }
                    break;
                }
                sq1 = (int) Math.Pow(A[indexNegative], 2);
                sq2 = (int) Math.Pow(A[indexPositive], 2);
                if (sq1 < sq2)
                {
                    ans[j] = sq1;
                    indexNegative--;
                }
                else
                {
                    ans[j] = sq2;
                    indexPositive++;
                }
                j++;
            }

            return ans;
        }
    }
}