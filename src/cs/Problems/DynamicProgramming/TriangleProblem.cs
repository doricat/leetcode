using System;
using System.Collections.Generic;
using System.Linq;

namespace Problems.DynamicProgramming
{
    public class TriangleProblem
    {
        // https://leetcode.com/problems/triangle
        public static int MinimumTotal(IList<IList<int>> triangle)
        {
            for (var i = 1; i < triangle.Count; i++)
            {
                for (var j = 0; j < triangle[i].Count; j++)
                {
                    int v;
                    if (j == 0)
                    {
                        v = triangle[i - 1][j];
                    }
                    else if (j == triangle[i].Count - 1)
                    {
                        v = triangle[i - 1][j - 1];
                    }
                    else
                    {
                        v = Math.Min(triangle[i - 1][j - 1], triangle[i - 1][j]);
                    }

                    triangle[i][j] += v;
                }
            }

            return triangle.Last().Min();
        }
    }
}