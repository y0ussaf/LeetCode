using System.Collections.Generic;

namespace Problems.LeetCode
{
    public class GenerateParenthesis
    {
        public static IList<string> Solve(int n)
        {
            IList<string> k = new List<string>();

            if (n == 1)
            {
                k.Add("()");
                return k;
            }

            IList<string> r = Solve(n - 1);
            foreach (var a in r)
            {
                k.Add($"(){a}");
                k.Add($"({a})");
            }

            if (n%2!=0)
            {
                string s = "";
                for (int i = 0; i < n; i++)
                {
                    if (n== i +1)
                    {
                        s += "()";
                        break;
                    }
                    if (i%2 == 0)
                    {
                        s += "((";
                    }
                    else
                    {
                        s += "))";
                    }
                }
                k.Add(s);
            }
            return k;
        }
    }
}