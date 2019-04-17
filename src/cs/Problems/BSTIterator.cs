using System.Collections.Generic;

namespace Problems
{
    // https://leetcode.com/problems/binary-search-tree-iterator/
    public class BSTIterator
    {
        private Stack<TreeNode> _stack = new Stack<TreeNode>();

        public BSTIterator(TreeNode root)
        {
            var node = root;
            while (node != null)
            {
                _stack.Push(node);
                node = node.left;
            }
        }

        public int Next()
        {
            if (_stack.Count != 0)
            {
                var node = _stack.Pop();
                var val = node.val;

                if (node.right != null)
                {
                    node = node.right;
                    while (node != null)
                    {
                        _stack.Push(node);
                        node = node.left;
                    }
                }

                return val;
            }

            return 0;
        }

        public bool HasNext()
        {
            return _stack.Count != 0;
        }
    }
}