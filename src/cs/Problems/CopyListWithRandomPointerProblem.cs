using System.Collections.Generic;

namespace Problems
{
    public class CopyListWithRandomPointerProblem
    {
        // https://leetcode.com/problems/copy-list-with-random-pointer/
        public static Node CopyRandomList(Node head)
        {
            var map = new Dictionary<Node, Node>();
            var node = head;
            var current = new Node();
            var result = head == null ? null : current;
            while (node != null && current != null)
            {
                current.val = node.val;
                current.next = node.next == null ? null : new Node();
                current.random = node.random;
                map.Add(node, current);
                node = node.next;
                current = current.next;
            }

            current = result;
            while (current != null)
            {
                if (current.random != null)
                {
                    current.random = map[current.random];
                }

                current = current.next;
            }

            return result;
        }

        public class Node
        {
            public int val;
            public Node next;
            public Node random;

            public Node()
            {
            }

            public Node(int _val, Node _next, Node _random)
            {
                val = _val;
                next = _next;
                random = _random;
            }
        }
    }
}