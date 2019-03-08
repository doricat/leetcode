using System;
using System.Linq;
using NUnit.Framework;

namespace Problems.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TwoSumTest1()
        {
            var result = Solution.TwoSum(new[] {2, 7, 11, 15}, 9);
            Assert.AreEqual(result, new[] {0, 1});
        }

        [Test]
        public void TwoSumTest2()
        {
            var result = Solution.TwoSum(new[] {3, 3}, 6);
            Assert.AreEqual(result, new[] {0, 1});
        }

        [Test]
        public void ThreeSumTest1()
        {
            var result = Solution.ThreeSum(new[] { -1, 0, 1, 2, -1, -4 });
            Console.Write(string.Join("\r\n", result.Select(x => string.Join(" ", x))));
//            Assert.AreEqual(result, new[] { 0, 1 });
        }
    }
}