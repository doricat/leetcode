namespace Problems.DynamicProgramming
{
    public class BTreeProblem
    {
        // https://leetcode.com/problems/unique-binary-search-tree
        public static int NumTrees(int n)
        {
            var array = new int[n + 1];
            array[0] = 1;
            array[1] = 1;
            for (var i = 2; i <= n; i++)
            {
                for (var j = 0; j < i; j++)
                {
                    array[i] += array[j] * array[i - j - 1];
                }
            }

            return array[n];
        }
    }
}