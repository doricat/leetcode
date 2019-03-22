namespace Problems.DynamicProgramming
{
    public class UniquePathsProblem
    {
        // https://leetcode.com/problems/unique-paths/
        public static int UniquePaths(int m, int n)
        {
            var array = new int[m, n];
            for (var i = 0; i < m; i++)
            {
                array[i, 0] = 1;
            }

            for (var i = 0; i < n; i++)
            {
                array[0, i] = 1;
            }

            for (var i = 1; i < m; i++)
            {
                for (var j = 1; j < n; j++)
                {
                    array[i, j] = array[i - 1, j] + array[i, j - 1];
                }
            }

            return array[m - 1, n - 1];
        }
    }
}