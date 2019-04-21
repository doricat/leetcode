using System.Collections.Generic;

namespace Problems
{
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

        /// <summary>
        /// 1,2,3
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static ListNode Parse(string str)
        {
            ListNode result = null;
            ListNode node = null;
            foreach (var s in str.Split(','))
            {
                if (node == null)
                {
                    node = new ListNode(int.Parse(s));
                    result = node;
                }
                else
                {
                    node.next = new ListNode(int.Parse(s));
                    node = node.next;
                }
            }

            return result;
        }
    }
}