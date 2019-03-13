namespace Problems
{
    public class ValidateBinarySearchTree
    {
        private TreeNode _prev;

        public bool IsValidBST(TreeNode root)
        {
            if (root != null)
            {
                if (!IsValidBST(root.left))
                {
                    return false;
                }

                if (_prev != null && root.val <= _prev.val)
                {
                    return false;
                }

                _prev = root;

                if (!IsValidBST(root.right))
                {
                    return false;
                }
            }

            return true;
        }

        /*private static bool IsValidBST(TreeNode node, int min, int max)
        {
            if (node == null)
            {
                return true;
            }

            if (node.val <= min || node.val >= max)
            {
                return false;
            }

            return IsValidBST(node.left, min, node.val) && IsValidBST(node.right, node.val, max);
        }*/

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
}