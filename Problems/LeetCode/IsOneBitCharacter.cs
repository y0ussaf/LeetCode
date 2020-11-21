namespace Problems.LeetCode
{
    public class IsOneBitCharacter
    {
        public bool Solve(int[] bits)
        {
            int s = 0;
            for (int i = 0; i < bits.Length; i++)
            {
                if (i == bits.Length -1)
                {
                    return s == 0;
                }
                if (bits[i] == 1)
                {
                    s = s == 1 ? 0 : 1;
                }

                if (bits[i] == 0)
                {
                    if (s == 1)
                    {
                        s = 0;
                    }  
                }
            }

            return false;
        }
    }
}