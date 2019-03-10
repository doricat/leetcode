using System.Collections.Generic;

namespace Problems
{
    public partial class Solution
    {
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var result = new ListNode(0);
            var node = result;
            var r = 0;
            while (true)
            {
                var v = (l1?.val ?? 0) + (l2?.val ?? 0) + r;
                if (v > 9)
                {
                    var tr = v % 10;
                    node.val = tr;
                    r = 1;
                }
                else
                {
                    node.val = v;
                    r = 0;
                }

                if (l1?.next != null || l2?.next != null)
                {
                    node.next = new ListNode(0);
                    node = node.next;

                    l1 = l1?.next;
                    l2 = l2?.next;
                }
                else
                {
                    break;
                }
            }

            if (r != 0)
            {
                node.next = new ListNode(r);
            }

            return result;
        }

        public class ListNode
        {
            public int val;
            public ListNode next;

            public ListNode(int x)
            {
                val = x;
            }

            public int[] ToNums()
            {
                var result = new List<int>();
                var node = this;
                while (node != null)
                {
                    result.Add(node.val);
                    node = node.next;
                }

                return result.ToArray();
            }
        }
    }
}