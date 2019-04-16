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

        // https://leetcode.com/problems/path-sum-ii
        public static IList<IList<int>> PathSum(TreeNode root, int sum)
        {
            var result = new List<IList<int>>();
            var list = new List<int>();
            PathSum(root, sum, list, result);
            return result;
        }

        private static void PathSum(TreeNode node, int sum, IList<int> list, IList<IList<int>> result)
        {
            if (node != null)
            {
                list.Add(node.val);
                PathSum(node.left, sum, list, result);
                if (node.right == null && node.left == null && list.Sum() == sum)
                {
                    result.Add(list.Select(x => x).ToList());
                }

                PathSum(node.right, sum, list, result);
                list.RemoveAt(list.Count - 1);
            }
        }

        // https://leetcode.com/problems/flatten-binary-tree-to-linked-list
        public static void Flatten(TreeNode root)
        {
            if (root == null)
            {
                return;
            }

            var stack = new Stack<TreeNode>();
            stack.Push(root);
            var node = new TreeNode(0);

            while (stack.Any())
            {
                var n = stack.Pop();
                node.right = n;
                node = n;

                if (node.right != null)
                {
                    stack.Push(n.right);
                    n.right = null;
                }

                if (node.left != null)
                {
                    stack.Push(n.left);
                    n.left = null;
                }
            }
        }

        // https://leetcode.com/problems/populating-next-right-pointers-in-each-node
        public static Node Connect(Node root)
        {
            var list = new List<IList<Node>>();
            Connect(root, list, 0);
            foreach (var nodes in list)
            {
                for (var i = 0; i < nodes.Count - 1; i++)
                {
                    nodes[i].next = nodes[i + 1];
                }
            }

            return root;
        }

        private static void Connect(Node node, IList<IList<Node>> list, int depth)
        {
            if (node != null)
            {
                if (list.Count > depth)
                {
                    list[depth].Add(node);
                }
                else
                {
                    list.Add(new List<Node> {node});
                }

                Connect(node.left, list, depth + 1);
                Connect(node.right, list, depth + 1);
            }
        }
    }

    public class Node
    {
        public int val;
        public Node left;
        public Node right;
        public Node next;

        public Node(int x)
        {
            val = x;
        }
    }
}