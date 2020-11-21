using System.Text;

namespace Problems.LeetCode
{
    public class ReverseWordsString
    {
        public string ReverseWords(string s)
        {
            StringBuilder ans =new StringBuilder();
            string buffer = string.Empty;
            for (int i = s.Length -1; i >=0; i--)
            {
                if (s[i] == ' ')
                {
                    if (buffer.Length != 0)
                    {
                        ans.Append(' '+ buffer);
                        buffer = string.Empty;
                    }
                    
                }
                else
                {
                    buffer = s[i] + buffer;

                }
            }

            ans.Append(' '+buffer);
            return ans.ToString().TrimStart();
        }
    }
}