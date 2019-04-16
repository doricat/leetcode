using System;

namespace Problems
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int x)
        {
            val = x;
        }

        public override string ToString()
        {
            return $"val={val}, left_val={left?.val}, right_val={right?.val}";
        }

        public static TreeNode Parse(int[] array)
        {
            foreach (var i in array)
            {
            }

            throw new NotImplementedException();
        }
    }
}