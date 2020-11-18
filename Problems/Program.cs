using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using Problems.Definitions;
using Problems.LeetCode; 

namespace Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            Subsets subsets = new Subsets();
            var t = subsets.Solve(new[] {1, 2, 3});

            foreach (var v in t)
            {
                foreach (var a in v)
                {
                    Console.WriteLine(a);
                }

                Console.WriteLine("#");
            }
            

        }
        
    }
}