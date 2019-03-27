using System;
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

        // https://leetcode.com/problems/binary-tree-level-order-traversal
        public static IList<IList<int>> LevelOrder(TreeNode root)
        {
            var result = new List<IList<int>>();
            LevelOrderTraversal(root, result, 0);
            return result;
        }

        private static void LevelOrderTraversal(TreeNode node, IList<IList<int>> list, int depth)
        {
            if (node != null)
            {
                if (list.Count > depth)
                {
                    list[depth].Add(node.val);
                }
                else
                {
                    list.Add(new List<int> {node.val});
                }

                LevelOrderTraversal(node.left, list, depth + 1);
                LevelOrderTraversal(node.right, list, depth + 1);
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