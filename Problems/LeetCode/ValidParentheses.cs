using System;
using System.Collections.Generic;

namespace Problems.LeetCode
{
    public class ValidParentheses
    {
        public static bool Solve(string s)
        {
            Stack<char> stack = new Stack<char>();
            foreach (var a in s)
            {
                if (a == '(' || a == '[' || a == '{')
                {
                   stack.Push(a);
                }

                if (a == ')')
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }
                    if (stack.Pop() != '(')
                    {
                        return false;
                    }
                }

                

                if (a == ']')
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }
                    if (stack.Pop() != '[')
                    {
                        return false;
                    }
                }

                
                if (a == '}')
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }
                    if (stack.Pop() != '{')
                    {
                        return false;
                    }
                }

               
            }

            if (stack.Count == 0)
            {
                return true;
            }
            return false;
        }
    }
}