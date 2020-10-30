using Problems.Definitions;

namespace Problems.LeetCode
{
    public class AddTwoNumbers
    {
        public static ListNode Solve(ListNode l1, ListNode l2)
        {
            
            var a = 0;
            ListNode root = null;
            ListNode temp = root;
            int l1Val = 0;
            int l2Val = 0;
            while (l1!= null || l2!=null || a == 1)
            {
                if (temp == null)
                {
                    temp = new ListNode();
                    root = temp;
                }
                else
                {
                    if (!((l1 == null || l2 == null) && a ==0))
                    {
                        temp.next = new ListNode();
                        temp = temp.next;
                    }
                }
                
                if (l1 == null)
                {
                    l1Val = 0;
                    if (a == 0)
                    {
                        temp.next = l2;
                        break;
                    }
                }
                else
                {
                    l1Val = l1.val;
                }
 

                if (l2 == null)
                {
                    l2Val = 0;
                    if (a == 0)
                    {
                        temp.next = l1;
                        break;
                    }
                }
                else
                {
                    l2Val = l2.val;
                }
                
                
                temp.val = (l1Val + l2Val +a)%10;
                if (l1Val + l2Val +a > 9)
                {
                    a = 1;
                }
                else
                {
                    a = 0;
                }
                
                l1 = l1?.next;
                l2 = l2?.next;
            }

             
           
            return root;
        }
    }
}