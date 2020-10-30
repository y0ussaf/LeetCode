using Problems.Definitions;

namespace Problems.LeetCode
{
    public class ValidateBinarySearchTree
    {
        public bool IsValidBST(TreeNode root, int? l =null,int? m = null)
        {
            if (root == null)
            {
                return true;
            }
            bool min = true;
            bool max = true;
            if (l !=null)
            {
                min = root.val >= l;
            }

            if (m != null)
            {
                max = root.val <= m;
            }
            
            return max && min && IsValidBST(root.left, l, root.val)
                   && IsValidBST(root.right, root.val,m);


        }
    }
}