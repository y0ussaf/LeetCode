namespace Problems.LeetCode
{
    public class IsMonotonic
    {
        public bool Solve(int[] A)
        {
            int c = 0;// 1 increasing 2 decreasing
            for (int i = 0; i < A.Length -1; i++)
            {
                if (c == 0)
                {
                    if (A[i] < A[i+1])
                    {
                        c = 1;
                    }

                    if (A[i] > A[i+1])
                    {
                        c = 2;
                    }
                }else if (c == 1)
                {
                    if (A[i] > A[i+1])
                    {
                        return false;
                    }
                }else if (c == 2)
                {
                    if (A[i] < A[i+1])
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}