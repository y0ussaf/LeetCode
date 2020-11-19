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
            ReverseWordsString reverseWords = new ReverseWordsString();
            var t = reverseWords.ReverseWords("a good   example");
            Console.WriteLine('#'+t+'#');
        }
        
    }
}