using System;
using Problems.Definitions;

namespace Problems.LeetCode
{
    public class RemoveNthFromEnd
    {
        public static ListNode Solve(ListNode head, int n)
        {
            ListNode p1 = head;
            ListNode p2 = head;
            ListNode p3 = head;
             for (int i = 0; i < n; i++)
            {
                p1 = p1.next;
            }

            if (p1 == null)
            {
                Console.WriteLine("im here");
                head = head.next;
                return head;
            }
            
            while (p1!=null)
            {
                p3 = p2;
                p1 = p1.next;
                p2 = p2.next;
            }

            p3.next = p2.next;
            return head;
        }
    }
}