using System;
using System.Collections.Generic;
using Problems.Definitions;

namespace Problems.LeetCode
{
    public class LevelOrder
    {
        public static void Go(Queue<TreeNode> queue ,IList<IList<int>> list)
        {
            TreeNode treeNode;
            Queue<TreeNode> nextLevelQueue = new Queue<TreeNode>();
            List<int> l = new List<int>();
            while (queue.Count != 0)
            {
                treeNode = queue.Dequeue();
                l.Add(treeNode.val);
                if (treeNode.left != null)
                {
                    nextLevelQueue.Enqueue(treeNode.left);

                }

                if (treeNode.right !=null)
                {
                    nextLevelQueue.Enqueue(treeNode.right);

                }

            }
            list.Add(l);
            if (nextLevelQueue.Count != 0)
            {
                Go(nextLevelQueue,list);
            }

             
        }
        public static IList<IList<int>> Solve(TreeNode root)
        {
            IList<IList<int>> list = new List<IList<int>>();
            if (root == null)
            {
                return list;
            }
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            Go(queue,list);
            return list;
        }
        
         
    }
}