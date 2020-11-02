using System.Collections.Generic;
using Problems.Definitions;

namespace Problems.LeetCode
{
    public class DistanceK
    {
        public static void Go(TreeNode root,TreeNode target ,int k,List<int> list,bool found)
        {
            if (found)
            {
                list.Add(root.val);
                if (k -1 >=1)
                {
                    Go(root.left,target,k-1,list,true);
                    Go(root.right,target,k-1,list,true);
                }
                
            }
        }
        public static List<int> Solve(TreeNode root, TreeNode target, int k)
        {
            List<int> list = new List<int>();
            Go(root, target, k, list, false);
            return list;
        }
    }
}