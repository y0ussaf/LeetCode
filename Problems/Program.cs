using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using Problems.Definitions;
using Problems.LeetCode; 

namespace Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            var y =ProductExceptSelf.Solve(new[] {1, 2, 3, 4});
            foreach (var a in y)
            {
                Console.WriteLine(a);
            }
            
        }
        
    }
}