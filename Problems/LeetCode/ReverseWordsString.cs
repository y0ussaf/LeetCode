namespace Problems.LeetCode
{
    public class ReverseWordsString
    {
        public string ReverseWords(string s)
        {
            string ans = string.Empty;
            string buffer = string.Empty;
            for (int i = s.Length -1; i >=0; i--)
            {
                if (s[i] == ' ')
                {
                    if (buffer.Length != 0)
                    {
                        ans += ' '+ buffer ;
                        buffer = string.Empty;
                    }
                    
                }
                else
                {
                    buffer = s[i] + buffer;

                }
            }

            ans = buffer + ans;
            return ans.Trim();
        }
    }
}