namespace Problems.LeetCode
{
    public class NumIslands
    {
        public static int Solve(char[][] grid)
        {
            int ans = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == '1')
                    {
                        if (i == 0 && j == 0)
                        {
                            ans += 1;
                            continue;
                        }
                        if (i == 0 && grid[i][j-1] == '0' )
                        {
                            ans += 1;
                            continue;
                        }

                        if (j == 0 && grid[i-1][j] == '0' &&  ( j == grid[0].Length  -1 ||  grid[i][j+1] == '0' ))
                        {
                            ans += 1;
                            continue;
                        }
                        if (i != 0 && j != 0)
                        {
                            if (grid[i-1][j] == '0' && grid[i][j-1] == '0')
                            {
                                ans += 1;
                            }
                        }
                        
                    }
                }
            }

            return ans;
        }
    }
}