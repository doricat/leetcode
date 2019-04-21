namespace Problems
{
    public class MergeTwoSortedLists
    {
        // https://leetcode.com/problems/merge-two-sorted-lists/
        public static ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            ListNode result = null;
            ListNode node = null;
            while (l1 != null || l2 != null)
            {
                int val;
                if (l1 != null && l2 != null)
                {
                    if (l1.val <= l2.val)
                    {
                        val = l1.val;
                        l1 = l1.next;
                    }
                    else
                    {
                        val = l2.val;
                        l2 = l2.next;
                    }
                }
                else if (l1 != null)
                {
                    val = l1.val;
                    l1 = l1.next;
                }
                else
                {
                    val = l2.val;
                    l2 = l2.next;
                }

                if (node == null)
                {
                    node = new ListNode(val);
                    result = node;
                }
                else
                {
                    node.next = new ListNode(val);
                    node = node.next;
                }
            }

            return result;
        }
    }
}