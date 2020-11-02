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
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(3);
            root.left.left = new TreeNode(4);
            root.left.right = new TreeNode(5);
            root.right.left = new TreeNode(6);
            root.right.right = new TreeNode(7);
            var k = LevelOrder.Solve(root);
            foreach (var c in k)
            {
                foreach (var v in c)
                {
                    Console.WriteLine(v);
                }

                Console.WriteLine("###");
            }
        }
        
    }
}