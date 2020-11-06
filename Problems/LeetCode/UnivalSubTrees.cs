using Problems.Definitions;

namespace Problems.LeetCode
{
    public class UnivalSubTrees
    {
        public static bool IsUnival(TreeNode root,int value)
        {
            if (root == null)
            {
                return true;
            }
            return root.val == value && IsUnival(root.left,value) 
                && IsUnival(root.right,value);
        }

        public static int Count(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            if (IsUnival(root,root.val))
            {
                return 1;
            }
            
            return Count(root.left) + Count(root.right);
        }

        public static int Solve(TreeNode root)
        {
            return Count(root);
        }
    }
}