using System;
using System.Collections.Generic;

namespace Problems.LeetCode
{
    public class PushDominoes
    {
        public static string Solve(string dominoes)
        {
            string ans = "";
            int count = 0;
            bool RFound = false;
            for (int i = 0; i < dominoes.Length; i++)
            {
                if (dominoes[i] == 'L')
                {
                    if (!RFound)
                    {
                        ans+= new string('L',count+1);
                    }
                    else
                    {
                        ans+= new string('R',count/2);
                        if (count%2 == 1)
                        {
                            ans += '.';
                        }
                        ans+= new string('L',(count/2)+1);
                    }
                    count = 0;
                    RFound = false;
                }
               
                
                if (dominoes[i] == 'R')
                {
                    if (RFound)
                    {
                        ans+= new string('R',count+1);
                    }
                    else
                    {
                        ans+= new string('.',count);
                        ans += 'R';
                    }
                    RFound = true;
                    count = 0;
                }
                if (dominoes[i] == '.')
                {
                     
                    count++;
                }
                if (i == dominoes.Length -1)
                {
                    if (RFound)
                    {
                        ans+= new string('R',count);
                    }
                    else
                    {
                        ans+= new string('.',count);
                    }
                    
                }
            }

            return ans;
        }
        
    }
}