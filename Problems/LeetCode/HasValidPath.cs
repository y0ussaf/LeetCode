namespace Problems.LeetCode
{
    public class HasValidPath
    {
        public bool IsVisited(int x, int y, int[][] visited)
        {
            return visited[x][y] == 1;
        }
        public bool IsOustideBounds(int x, int y,int n,int m)
        {
            if (x < 0 || x > m -1)
            {
                return true;
            }

            if (y < 0 || y > n -1)
            {
                return true;
            }

            return false;
        }
        public bool Go(int[][] grid, int[][] visited,int x = 0,int y = 0)
        {
            
            if (x == grid.Length -1 && y == grid[0].Length -1)
            {
                return true;
            }

            visited[x][y] = 1;
            bool isValid = false;
            if (grid[x][y] == 1)
            {
                // right
                if (!IsOustideBounds(x, y + 1, grid[0].Length, grid.Length) && !IsVisited(x,y+1,visited))
                {
                    if (grid[x][y + 1] == 3 || grid[x][y + 1] == 5 || grid[x][y+1] == 1)
                    {
                        isValid = Go(grid, visited, x, y + 1);
                    }
                }

                // left
                if (!IsOustideBounds(x, y - 1, grid[0].Length, grid.Length) && !IsVisited(x,y-1,visited))
                {
                    if (grid[x][y - 1] == 4 || grid[x][y - 1] == 6 || grid[x][y-1] == 1)
                    {
                        isValid = isValid || Go(grid, visited, x, y - 1);
                    }
                }
            }

            if (grid[x][y] == 2)
            {
                // top
                if (!IsOustideBounds(x-1,y,grid[0].Length,grid.Length) && !IsVisited(x-1,y,visited))
                {
                    if (grid[x-1][y] == 3 || grid[x-1][y] == 4 || grid[x-1][y] == 2)
                    {
                        isValid = isValid || Go(grid, visited, x -1, y);
                    }
                }
                   
                // bottom
                if (!IsOustideBounds(x+1,y,grid[0].Length,grid.Length) && !IsVisited(x+1,y,visited))
                {
                    if (grid[x+1][y] == 5 || grid[x+1][y] == 6 || grid[x+1][y] == 2)
                    {
                        isValid = isValid || Go(grid, visited, x + 1, y);
                    }
                }
                   
            }

            if (grid[x][y] == 3)
            {
                // left
                if (!IsOustideBounds(x, y - 1, grid[0].Length, grid.Length) && !IsVisited(x,y-1,visited))
                {
                    if (grid[x][y-1] != 5 && grid[x][y-1] != 2)
                    {
                        isValid = isValid || Go(grid, visited, x, y-1);
                    }
                }

                    
                // bottom
                if (!IsOustideBounds(x + 1, y, grid[0].Length, grid.Length) && !IsVisited(x+1,y,visited))
                {
                    if (grid[x+1][y] != 1 && grid[x+1][y] != 4)
                    {
                        isValid = isValid || Go(grid, visited, x + 1, y);
                    }
                }
                    
            }

            if (grid[x][y] == 4)
            {
                // right
                if (!IsOustideBounds(x, y + 1, grid[0].Length, grid.Length) && !IsVisited(x,y+1,visited))
                {
                    if (grid[x][y+1] != 2 && grid[x][y+1] != 6)
                    {
                        isValid = isValid || Go(grid, visited, x, y + 1);
                    }
                }

                    
                // bottom
                if (!IsOustideBounds(x+1, y , grid[0].Length, grid.Length) && !IsVisited(x+1,y,visited))
                {
                    if (grid[x+1][y] != 1 && grid[x+1][y] != 3)
                    {
                        isValid = isValid || Go(grid, visited, x + 1, y);
                    }
                }
                    
            }

            if (grid[x][y] == 5)
            {
                // top
                if (!IsOustideBounds(x - 1, y, grid[0].Length, grid.Length) && !IsVisited(x-1,y,visited))
                {
                    if (grid[x-1][y] != 1 && grid[x-1][y] != 6)
                    {
                        isValid = isValid || Go(grid, visited, x - 1, y);
                    }
                }
                // left
                if (!IsOustideBounds(x, y -1, grid[0].Length, grid.Length) && !IsVisited(x,y-1,visited))
                {
                    if (grid[x][y-1] != 2 && grid[x][y-1] != 3)
                    {
                        isValid = isValid || Go(grid, visited, x, y - 1);
                    }
                }
            }

            if (grid[x][y] == 6)
            {
                // top
                if (!IsOustideBounds(x-1, y, grid[0].Length, grid.Length) && !IsVisited(x-1,y,visited))
                {
                    if (grid[x - 1][y] != 1 && grid[x - 1][y] != 5)
                    {
                        isValid = isValid || Go(grid, visited, x - 1, y);
                    }
                }

                //right
                if (!IsOustideBounds(x, y + 1, grid[0].Length, grid.Length) && !IsVisited(x,y+1,visited))
                {
                    if (grid[x][y+1] != 2 && grid[x][y+1] != 4 )
                    {
                        isValid = isValid || Go(grid, visited, x , y+1);
                    }
                }

                
            }
            
            return isValid;
        }
        public bool Solve(int[][] grid)
        {
            int[][] visited = new int[grid.Length][];
            for (int i = 0; i < visited.Length; i++)
            {
                visited[i] = new int[grid[0].Length];
            }

            return Go(grid, visited);
        }
    }
}