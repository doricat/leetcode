using System;
using System.Linq;

namespace Problems
{
    public class MaximalSquareProblem
    {
        // https://leetcode.com/problems/maximal-square
        public static int MaximalSquare(char[][] matrix)
        {
            if (matrix.Length <= 1)
            {
                if (matrix.Length == 0)
                {
                    return 0;
                }

                return matrix[0].Any(x => x == '1') ? 1 : 0;
            }

            var row = matrix.Length;
            var col = matrix[0].Length;
            var max = 0;
            var dp = new int[row, col];

            for (var i = 0; i < row; i++)
            {
                if (matrix[i][0] == '1')
                {
                    dp[i, 0] = 1;
                    max = 1;
                }
            }

            for (var i = 0; i < col; i++)
            {
                if (matrix[0][i] == '1')
                {
                    dp[0, i] = 1;
                    max = 1;
                }
            }

            for (var i = 1; i < row; i++)
            {
                for (var j = 1; j < col; j++)
                {
                    if (matrix[i][j] == '1')
                    {
                        dp[i, j] = Math.Min(dp[i - 1, j - 1], Math.Min(dp[i - 1, j], dp[i, j - 1])) + 1;
                        max = Math.Max(max, dp[i, j]);
                    }
                }
            }

            return max * max;
        }
    }
}