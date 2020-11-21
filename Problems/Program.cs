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
              FriendCircles friendCircles = new FriendCircles();
              var a = friendCircles.Solve(new[]
              {
                  new[] {1, 1, 0},
                  new[] {1, 1, 1},
                  new[] {0, 1, 1}
              });
              Console.WriteLine(a);


        }
        
    }
}