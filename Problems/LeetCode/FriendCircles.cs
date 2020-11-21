namespace Problems.LeetCode
{
    public class FriendCircles
    {
        public void Go(int[][] M, int[] visited, int rowIndex)
        {
            var row = M[rowIndex];
            visited[rowIndex] = 1;
            for (int j = 0; j < row.Length; j++)
            {
                if (row[j] == 1 && visited[j] == 0)
                {
                    if (j == rowIndex)
                    {
                        continue;
                    }

                    Go(M, visited, j);
                    
                }
                
            }
        }

        public int Solve(int[][] M)
        {
            int ans = 0;
            int[] rowsVisited = new int[M.Length];
            for (int i = 0; i < M.Length; i++)
            {
                if (rowsVisited[i] == 0)
                {
                    ans++;
                    Go(M, rowsVisited,i);
                }
            }

            return ans;
        }
        
    }
}