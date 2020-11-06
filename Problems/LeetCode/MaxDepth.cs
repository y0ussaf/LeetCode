using System;
using Problems.Definitions;

namespace Problems.LeetCode
{
    public class MaxDepth
    {
        public static int Solve(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            return Math.Max(Solve(root.left), Solve(root.right)) + 1;
        }
    }
}