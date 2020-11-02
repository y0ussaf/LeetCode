using System.Collections.Generic;
using Problems.Definitions;

namespace Problems.LeetCode
{
    public class RemoveZeroSumSublists
    {
        public static ListNode Solve(ListNode head)
        {
            ListNode ans = head;
            ListNode p = head;
            Dictionary<int,ListNode> nodes = new Dictionary<int, ListNode>();
            int sum = 0;
            while (p!=null)
            {
                if (sum+ p.val == 0)
                {
                    sum += p.val;
                    ans = p = p.next;
                    
                }else if (nodes.ContainsKey(sum+p.val))
                {
                    nodes[sum + p.val].next = p.next;
                    sum += p.val;
                    p = p.next;
                }
                else
                {
                    nodes[sum + p.val] = p;
                    sum += p.val;
                    p = p.next;
                }
                
            }
            return ans;
        }
    }
}