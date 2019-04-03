using NUnit.Framework;

namespace Problems.Tests
{
    public class MaximumProductSubarrayProblemTests
    {
        [Test]
        public void MaxProductTest1()
        {
            Assert.AreEqual(MaximumProductSubarrayProblem.MaxProduct(new[] {2, 3, -2, 4}), 6);
        }

        [Test]
        public void MaxProductTest2()
        {
            Assert.AreEqual(MaximumProductSubarrayProblem.MaxProduct(new[] {-2, 0, -1}), 0);
        }
    }
}