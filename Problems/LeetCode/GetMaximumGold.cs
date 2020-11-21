using System;
using System.Collections.Generic;

namespace Problems.LeetCode
{
    public class GetMaximumGold
    {
        public Dictionary<Tuple<int,int>,int> _cache = new Dictionary<Tuple<int, int>, int>();
        public bool IsOutsideTheBounds(int[][] grid,int x,int y)
        {
            if (x < 0 || x > grid[0].Length-1)
            {
                return true;
            }

            if (y < 0 || y > grid.Length -1)
            {
                return true;
            }

            return false;
        }
        
        public int CollectGold(int[][] grid,int[][] visited,int x,int y)
        {
            
            int goldCollectedFromThisCell = grid[y][x];
            visited[y][x] = 1;
            int max = 0;
            // right
            if (!IsOutsideTheBounds(grid,x+1,y) && grid[y][x+1] != 0 && visited[y][x+1] == 0)
            {
                max = Math.Max(CollectGold(grid, visited,x + 1, y),max);
            }
            // left
            if (!IsOutsideTheBounds(grid,x-1,y) && grid[y][x-1] != 0 && visited[y][x-1] == 0)
            {
                max = Math.Max(CollectGold(grid, visited,x - 1, y), max);
            }
            // bottom
            if (!IsOutsideTheBounds(grid,x,y+1) && grid[y+1][x] != 0 && visited[y+1][x] == 0)
            {
                max =  Math.Max( CollectGold(grid, visited,x, y + 1),max);
            }
            // top
            if (!IsOutsideTheBounds(grid,x,y-1) && grid[y-1][x] != 0 && visited[y-1][x] == 0)
            {
                max = Math.Max(CollectGold(grid, visited,x, y - 1), max);
            }
            int result = goldCollectedFromThisCell + max;
            return result;
        }
        public int Solve(int[][] grid)
        {
            int max = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] != 0)
                    {
                        var visited = new int[grid.Length][];
                        for (int k = 0; k < visited.Length; k++)
                        {
                            visited[k] = new int[grid[i].Length];
                        }
                        max = Math.Max(max, CollectGold(grid, visited, j, i));
                    }
                    
                }
                
            }

            return max;

        }
    }
}