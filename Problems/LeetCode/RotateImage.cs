using System;

namespace Problems.LeetCode
{
    public class RotateImage
    {
         
        public static void Go(int[][] matrix,int window=0) 
        {
            if (window == matrix.Length/2)
            {
                return;
            }
            int n = matrix[0].Length;
            for (int i = window; i < matrix[window].Length -1 - window; i++)
            {
                int actualPosX = i;
                int actualPosY = window;
                int value = matrix[actualPosY][actualPosX];
                do
                {
                    int y = actualPosX;
                    int x = n - 1 - actualPosY;
                    int temp = matrix[y][x];
                    matrix[y][x] = value;
                    value = temp;
                    actualPosX = x;
                    actualPosY = y;
                  
                } while (actualPosX!= i || actualPosY != window);
            }
            Go(matrix,window+1);
        }

        public void Solve(int[][] matrix)
        {
            Go(matrix);
        }
    }
}