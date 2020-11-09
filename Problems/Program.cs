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
            var t = LetterCombinationsOfPhoneNumber.Solve("23");
            Console.WriteLine(t.Count);
            foreach (var a in t)
            {
                Console.WriteLine(a);
            }
            
        }
        
    }
}