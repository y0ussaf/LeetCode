using Problems.Definitions;

namespace Problems.LeetCode
{
    public class PartitionList
    {
        public static ListNode Solve(ListNode head, int x)
        {
            if (head == null)
            {
                return null;
            }
            ListNode last = head;
            while (true)
            {
                if (last.next == null) 
                {
                    break;
                }
                last = last.next;
            }

            ListNode p = head;
            ListNode prev = null;
            ListNode first = null;
            while (p != first  )
            {
                if (first == null && p == last)
                {
                    break;
                }
                if (p.val >= x)
                {
                    first ??= p;
                    if (prev != null)
                    {
                        prev.next = p.next;
                    }
                    else
                    {
                        head = p.next;
                    }
                    last.next = p;
                    last = p;
                    p = p.next;
                    last.next = null;
                    continue;
                }
                prev = p;
                p = p.next;
                
            }

            return head;
        }
    }
}