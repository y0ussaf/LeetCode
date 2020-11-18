namespace Problems.LeetCode
{
    public class ZigZagConversion
    {
        public string Solve(string s, int numRows)
        {
            if (numRows == 1 || s.Length <= numRows)
            {
                return s;
            }
            string[] lines = new string[numRows];
            for (int i = 0; i < lines.Length; i++)
            {
                lines[i] = string.Empty;
            }
            int column = 0;
            int lineNbr = 0;
            foreach (var c in s)
            {
                
                if (column% (numRows -1) == 0)
                {
                    lines[lineNbr] += c;
                    if (lineNbr == numRows -1)
                    {
                        lineNbr = 0;
                        column++;
                    }
                    else
                    {
                        lineNbr++;
                    }
                }
                else
                {
                    lines[(numRows-1) - column%(numRows -1) ] += c;
                    column++;
                }
            }

            string ans = string.Empty;
            foreach (var line in lines)
            {
                ans += line;
            }

            return ans;
        }
    }
}