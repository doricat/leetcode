using NUnit.Framework;

namespace Problems.Tests
{
    public class TwoSumTests
    {
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
    }
}