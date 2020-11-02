namespace Problems.LeetCode
{
    public class UniquePaths
    {
        private static int[,] cache;
        public static int Go(int[] pos, int m, int n)
        {
            if (cache[pos[1] -1,pos[0]-1] != 0)
            {
                return cache[pos[1]-1, pos[0]-1];
            }
            if (n == pos[0] && m == pos[1])
            {
                return 1;
            }

            int count = 0;
            
            if (m != pos[1])
            {
                // can't move down
                int[] p = new int[2];
                pos.CopyTo(p,0);
                p[1] += 1;
                count += Go(p, m, n);
            }

            if (n != pos[0] )
            {
                int[] p = new int[2];
                pos.CopyTo(p,0);
                p[0] += 1;
                count += Go(p, m, n);
            }

            cache[pos[1] -1 , pos[0] -1] = count;
            return count;
        }
        public static int Solve(int m, int n)
        {
            cache = new int[m,n];
            return Go(new[] {1, 1}, m, n);
        }
    }
}