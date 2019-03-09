using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using NUnit.Framework;

namespace Problems.Tests
{
    public class ThreeSumTests
    {
        [Test]
        public void ThreeSumTest1()
        {
            var result = Solution.ThreeSum(new[] {-1, 0, 1, 2, -1, -4});
            Assert.AreEqual(result, new List<List<int>> {new List<int> {-1, 0, 1}, new List<int> {-1, 2, -1}});
        }

        [Test]
        public void ThreeSumTest2()
        {
            var result = Solution.ThreeSum(new[] {0, 0, 0, 0});
            Assert.AreEqual(result, new List<List<int>> {new List<int> {0, 0, 0}});
        }

        [Test]
        public void ThreeSumTest3()
        {
            var result = Solution.ThreeSum(new[] {-4, -2, -2, -2, 0, 1, 2, 2, 2, 3, 3, 4, 4, 6, 6});
            Assert.AreEqual(result, new List<List<int>>
            {
                new List<int> {-4, -2, 6},
                new List<int> {-4, 0, 4},
                new List<int> {-4, 1, 3},
                new List<int> {-4, 2, 2},
                new List<int> {-2, -2, 4},
                new List<int> {-2, 0, 2}
            });
        }

        [Test]
        public void ThreeSumTest4()
        {
            var result = Solution.ThreeSum(new[] {-4, -2, 1, -5, -4, -4, 4, -2, 0, 4, 0, -2, 3, 1, -5, 0});
            Assert.AreEqual(result, new List<List<int>>
            {
                new List<int> {-4, 1, 3},
                new List<int> {-4, 4, 0},
                new List<int> {-2, 1, 1},
                new List<int> {-2, 4, -2},
                new List<int> {1, -5, 4},
                new List<int> {0, 0, 0}
            });
        }
    }
}