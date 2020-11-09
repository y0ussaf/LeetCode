using System;
using System.Collections.Generic;

namespace Problems.LeetCode
{
    public class LetterCombinationsOfPhoneNumber
    {
        public static IList<string> Go(string digits, char[][] chars)
        {
            IList<string> l = new List<string>();
            if (digits.Length == 0)
            {
                return l;
            }
            
            int s = int.Parse(digits[0].ToString());
            Console.WriteLine(s);
            IList<string> list = Go(digits.Remove(0, 1), chars);
            for (int i = 0; i < chars[s -2].Length; i++)
            {
                if (list.Count == 0)
                {
                    l.Add(chars[s-2][i].ToString());
                }
                else
                {
                    foreach (var element in list)
                    {
                        l.Add(chars[s-2][i]+element);
                    }
                }
                
            }

            return l;
        }
        public static IList<string> Solve(string digits)
        {
            char[][] chars = new char[8][];
            byte a = 97;
            int l;
            for (int i = 0; i < chars.Length; i++)
            {
                if (i + 2 != 7 && i + 2 != 9)
                {
                    l = 3;
                }
                else
                {
                    l = 4;
                }

                for (int j = 0; j < l; j++)
                {
                    if (j == 0)
                    {
                        chars[i] = new char[l];
                    }

                    chars[i][j] = (char) a;
                    a++;
                }
            }

            return Go(digits, chars);
        }
    }
}