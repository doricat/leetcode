using System.Collections.Generic;

namespace Problems.Tree
{
    public class BTree
    {
        // https://leetcode.com/problems/binary-tree-inorder-traversal
        public static IList<int> InorderTraversal(TreeNode root)
        {
            var result = new List<int>();
            InorderTraversal(root, result);
            return result;
        }

        private static void InorderTraversal(TreeNode node, IList<int> list)
        {
            if (node != null)
            {
                InorderTraversal(node.left, list);
                list.Add(node.val);
                InorderTraversal(node.right, list);
            }
        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int x)
        {
            val = x;
        }
    }
}