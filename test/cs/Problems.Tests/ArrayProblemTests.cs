using NUnit.Framework;

namespace Problems.Tests
{
    public class ArrayProblemTests
    {
        [Test]
        public void NextPermutationTest1()
        {
            var nums = new[] {1, 2, 3};
            ArrayProblem.NextPermutation(nums);
            Assert.AreEqual(nums, new[] {1, 3, 2});
        }

        [Test]
        public void NextPermutationTest2()
        {
            var nums = new[] {3, 2, 1};
            ArrayProblem.NextPermutation(nums);
            Assert.AreEqual(nums, new[] {1, 2, 3});
        }

        [Test]
        public void NextPermutationTest3()
        {
            var nums = new[] {1, 3, 2};
            ArrayProblem.NextPermutation(nums);
            Assert.AreEqual(nums, new[] {2, 1, 3});
        }
    }
}