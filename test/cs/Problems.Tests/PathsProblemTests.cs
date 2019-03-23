using NUnit.Framework;
using Problems.DynamicProgramming;

namespace Problems.Tests
{
    public class PathsProblemTests
    {
        [Test]
        public void UniquePathsTest1()
        {
            var result = PathsProblem.UniquePaths(3, 2);
            Assert.AreEqual(result, 3);
        }

        [Test]
        public void UniquePathsTest2()
        {
            var result = PathsProblem.UniquePaths(7, 3);
            Assert.AreEqual(result, 28);
        }

        [Test]
        public void UniquePathsWithObstaclesTest1()
        {
            var result = PathsProblem.UniquePathsWithObstacles(new[,] {{0}});
            Assert.AreEqual(result, 1);
        }

        [Test]
        public void UniquePathsWithObstaclesTest2()
        {
            var result = PathsProblem.UniquePathsWithObstacles(new[,] {{1, 0}});
            Assert.AreEqual(result, 0);
        }

        [Test]
        public void MinPathSumTest1()
        {
            var result = PathsProblem.MinPathSum(new[,] {{1, 3, 1}, {1, 5, 1}, {4, 2, 1}});
            Assert.AreEqual(result, 7);
        }
    }
}