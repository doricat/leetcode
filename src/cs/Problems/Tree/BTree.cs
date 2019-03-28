using System;
using System.Collections.Generic;
using System.Linq;

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

        // https://leetcode.com/problems/binary-tree-zigzag-level-order-traversal
        public static IList<IList<int>> ZigzagLevelOrder(TreeNode root)
        {
            var result = new List<IList<int>>();
            ZigzagLevelOrder(root, result, 0);
            return result;
        }

        private static void ZigzagLevelOrder(TreeNode node, IList<IList<int>> list, int depth)
        {
            if (node != null)
            {
                if (list.Count > depth)
                {
                    if (depth % 2 == 0)
                    {
                        list[depth].Add(node.val);
                    }
                    else
                    {
                        list[depth].Insert(0, node.val);
                    }
                }
                else
                {
                    list.Add(new List<int> {node.val});
                }

                ZigzagLevelOrder(node.left, list, depth + 1);
                ZigzagLevelOrder(node.right, list, depth + 1);
            }
        }

        // https://leetcode.com/problems/construct-binary-tree-from-preorder-and-inorder-traversal
        public static TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            if (preorder.Length == 0)
            {
                return null;
            }

            var rootValue = preorder[0];
            var lIn = inorder.Skip(0).Take(Array.IndexOf(inorder, rootValue)).ToArray();
            var lPre = preorder.Skip(1).Take(lIn.Length).ToArray();

            var rIn = inorder.Skip(lIn.Length + 1).ToArray();
            var rPre = preorder.Skip(lIn.Length + 1).ToArray();

            var root = new TreeNode(preorder[0])
            {
                left = BuildTree(lPre, lIn),
                right = BuildTree(rPre, rIn)
            };
            return root;
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