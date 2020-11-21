namespace Problems.LeetCode
{
    public class PrisonCellsAfterNDays
    {
        public int[] PrisonAfterNDays(int[] cells, int N) {

            for (int i = 0; i < N; i++)
            {
                
                int left = cells[0];
                for (int j = 1; j < cells.Length-1; j++)
                {
                    
                    if ((left == 0 && cells[j+1] == 0) || (left == 1 && cells[j+1] == 1))
                    {
                        left = cells[j];
                        cells[j] = 1;
                    }
                    else
                    {
                        left = cells[j];
                        cells[j] = 0;
                    }
                }

                cells[^1] = 0;
            }

            return cells;
        }
    }
}