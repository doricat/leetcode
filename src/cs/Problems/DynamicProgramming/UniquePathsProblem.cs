using System;

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

        // https://leetcode.com/problems/unique-paths-ii/
        public static int UniquePathsWithObstacles(int[,] obstacleGrid)
        {
            var m = obstacleGrid.GetLength(0);
            var n = obstacleGrid.GetLength(1);
            var array = new int[m, n];
            array[0, 0] = obstacleGrid[0, 0] == 0 ? 1 : 0;

            for (var i = 1; i < m; i++)
            {
                array[i, 0] = array[i - 1, 0] == 1 && obstacleGrid[i, 0] == 0 ? 1 : 0;
            }

            for (var i = 1; i < n; i++)
            {
                array[0, i] = array[0, i - 1] == 1 && obstacleGrid[0, i] == 0 ? 1 : 0;
            }

            for (var i = 1; i < m; i++)
            {
                for (var j = 1; j < n; j++)
                {
                    if (obstacleGrid[i, j] == 1)
                    {
                        array[i, j] = 0;
                    }
                    else
                    {
                        array[i, j] = array[i - 1, j] + array[i, j - 1];
                    }
                }
            }

            return array[m - 1, n - 1];
        }

        // https://leetcode.com/problems/minimum-path-sum
        public static int MinPathSum(int[,] grid)
        {
            var m = grid.GetLength(0);
            var n = grid.GetLength(1);
            var array = new int[m, n];
            array[0, 0] = grid[0, 0];

            for (var i = 1; i < m; i++)
            {
                array[i, 0] = array[i - 1, 0] + grid[i, 0];
            }

            for (var i = 1; i < n; i++)
            {
                array[0, i] = array[0, i - 1] + grid[0, i];
            }

            for (var i = 1; i < m; i++)
            {
                for (var j = 1; j < n; j++)
                {
                    array[i, j] = Math.Min(array[i - 1, j], array[i, j - 1]) + grid[i, j];
                }
            }

            return array[m - 1, n - 1];
        }
    }
}