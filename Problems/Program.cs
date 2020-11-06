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
            var t = LongestStrChain.Solve(new[] {"a", "b", "ba", "bca", "bda", "bdca"});
            Console.WriteLine(t);
            
        }
        
    }
}