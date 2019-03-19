using System.Collections.Generic;

namespace Problems
{
    public class LinkedListProblem
    {
        public static ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            var len = 0;
            var node = head;
            while (node != null)
            {
                len++;
                node = node.next;
            }

            if (n == len)
            {
                return head.next;
            }

            node = head;
            for (var i = len; i > n; i--)
            {
                node = node.next;
            }

            var node2 = head;
            while (node2 != null)
            {
                if (node2.next == node)
                {
                    node2.next = node.next;
                    break;
                }

                node2 = node2.next;
            }

            return head;
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