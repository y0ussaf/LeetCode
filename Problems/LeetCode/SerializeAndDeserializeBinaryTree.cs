using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualBasic;
using Problems.Definitions;

namespace Problems.LeetCode
{
    public class SerializeAndDeserializeBinaryTree
    {
         
        public string Serialize(TreeNode root)
        {
            if (root == null)
            {
                return "[]";
            }
            Queue<TreeNode> queue = new Queue<TreeNode>();
            StringBuilder ans = new StringBuilder();
            queue.Enqueue(root);
            TreeNode p;
            while (queue.Count != 0)
            {
                p = queue.Dequeue();
                if (p == null)
                {
                    ans.Append(",null");
                }
                else
                {
                    ans.Append((p == root ? "" : ",") + p.val);
                }
                if (p != null)
                {
                    queue.Enqueue(p.left);
                    queue.Enqueue(p.right);
                }
            }

            return "["+ans.ToString().Trim("null,".ToCharArray()) +"]";
        }

        // Decodes your encoded data to tree.
        public TreeNode Deserialize(string data)
        {
            var k = data.Trim(new []{'[',']'});
            string[] arr = k.Split(',');
            if (k.Length == 0)
            {
                return null;
            }
            TreeNode root = new TreeNode(int.Parse(arr[0]));
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            TreeNode node;
            for (int i = 1; i < arr.Length ; i++)
            {
                if (arr[i] != "null")
                {
                    node = new TreeNode(int.Parse(arr[i]));
                }
                else
                {
                    node = null;
                }
                if (i%2 == 0)
                {
                    queue.Dequeue().right = node;
                    
                }
                else
                {
                    queue.Peek().left = node;
                }

                if (node != null)
                {
                    queue.Enqueue(node);

                }
            }

            return root;
        }
    }
}