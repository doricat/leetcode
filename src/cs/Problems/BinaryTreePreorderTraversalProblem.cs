using System.Collections.Generic;

namespace Problems
{
    public class BinaryTreePreOrderTraversalProblem
    {
        // https://leetcode.com/problems/binary-tree-preorder-traversal/
        public static IList<int> PreOrderTraversal(TreeNode root)
        {
            var result = new List<int>();
            var stack = new Stack<TreeNode>();
            var node = root;

            while (node != null || stack.Count != 0)
            {
                while (node != null)
                {
                    result.Add(node.val);
                    stack.Push(node);
                    node = node.left;
                }

                if (stack.Count != 0)
                {
                    node = stack.Pop();
                    node = node.right;
                }
            }

            return result;
        }
    }
}