using Problems.Definitions;

namespace Problems.LeetCode
{
    public class InvertBinaryTree
    {
        public TreeNode InvertTree(TreeNode root)
        {
            if (root == null )
            {
                return null;
            }
            var temp = root.right;
            root.right = root.left;
            root.left = temp;
            if (root.left !=null)
            {
                InvertTree(root.left);

            }
            if (root.right!=null)
            {
                InvertTree(root.right);
            }

            return root;
        }
    }
}