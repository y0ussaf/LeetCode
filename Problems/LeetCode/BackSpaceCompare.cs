using System;

namespace Problems.LeetCode
{
    public class BackSpaceCompare
    {
        public static bool Solve(ref string s,ref string t)
        {
            return Test(ref s, ref t);
        }

        public static bool Test(ref string str1,ref string str2)
        {
            int str1K = 0;
            int str2K = 0;
            bool str1Blocked = false;
            bool str2Blocked = false;
            int u = -1;
            int y = -1;
            int i = str1.Length -1;
            int j = str2.Length -1;
            while (i>=0 || j >=0)
            {
                if (i>=0  && !str1Blocked)
                {
                    if (str1[i] != '#')
                    {
                        if (str1K == 0)
                        {
                            u = i;
                            str1Blocked = true;
                        }

                        if (str1K>0)
                        {
                            str1K--;
                            i--;
                        }
                    }else if (str1[i] == '#')
                    {
                        str1K++;
                        i--;
                    }
                
                   
 
                }
                if (j>=0 && !str2Blocked)
                {
                    
                    if (str2[j] != '#')
                    {
                        if (str2K == 0)
                        {
                            y = j;
                            str2Blocked = true;
                        }

                        if (str2K>0)
                        {
                            str2K--;
                            j--;
                        }
                    }else if (str2[j] == '#')
                    {
                        str2K++;
                        j--;
                    }
                  
                }

                if (y != -1 && u != -1)
                {
                    if (str1[u] != str2[y])
                    {
                        return false;
                    }

                    y = -1;
                    u = -1;
                    str1Blocked = false;
                    str2Blocked = false;
                    i--;
                    j--;
                }

                if ((i <0 && str2Blocked)|| (j<0 && str1Blocked))
                {
                    return false;
                }

            }
                
 
            return true;
        }
    }
}