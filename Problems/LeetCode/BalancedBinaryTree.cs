using System;
using System.Collections.Generic;
using Problems.Definitions;

namespace Problems.LeetCode
{
    public class BalancedBinaryTree
    {
        

        public static KeyValuePair<bool,int> Go(TreeNode root)
        {
            if (root == null)
            {
                return new KeyValuePair<bool, int>(true,0);
            }

            var l = Go(root.left);
            var r = Go(root.right);
            return new KeyValuePair<bool, int>(l.Key && r.Key && Math.Abs(l.Value - r.Value) <= 1 ,
                Math.Max(r.Value,l.Value) +1);
            
        }
        public static bool Solve(TreeNode root)
        {
            return Go(root).Key;
        }
    }
}