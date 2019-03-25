using System.Collections.Generic;
using NUnit.Framework;
using Problems.DynamicProgramming;

namespace Problems.Tests
{
    public class TriangleProblemTest
    {
        [Test]
        public void MinimumTotalTest1()
        {
            var result = TriangleProblem.MinimumTotal(new List<IList<int>>
            {
                new List<int> {2},
                new List<int> {3, 4},
                new List<int> {6, 5, 7},
                new List<int> {4, 1, 8, 3}
            });
            Assert.AreEqual(result, 11);
        }

        [Test]
        public void MinimumTotalTest2()
        {
            var result = TriangleProblem.MinimumTotal(new List<IList<int>>
            {
                new List<int> {-1},
                new List<int> {2, 3},
                new List<int> {1, -1, -3}
            });
            Assert.AreEqual(result, -1);
        }
    }
}