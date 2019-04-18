namespace Problems
{
    public class VerifyPreOrderSerializationOfABinaryTree
    {
        // https://leetcode.com/problems/verify-preorder-serialization-of-a-binary-tree/
        public static bool IsValidSerialization(string preorder)
        {
            var capacity = 1;
            preorder += ",";
            for (var i = 0; i < preorder.Length; ++i)
            {
                if (preorder[i] != ',') continue;
                if (--capacity < 0) return false;
                if (preorder[i - 1] != '#') capacity += 2;
            }

            return capacity == 0;
        }
    }
}