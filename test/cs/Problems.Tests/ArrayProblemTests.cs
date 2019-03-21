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

        [Test]
        public void SearchInRotatedSortedArrayTest1()
        {
            var result = ArrayProblem.Search(new[] {4, 5, 6, 7, 0, 1, 2}, 0);
            Assert.AreEqual(result, 4);
        }

        [Test]
        public void SearchInRotatedSortedArrayTest2()
        {
            var result = ArrayProblem.Search(new[] {5, 1, 3}, 1);
            Assert.AreEqual(result, 1);
        }

        [Test]
        public void SearchInRotatedSortedArray2Test1()
        {
            var result = ArrayProblem.Search2(new[] { 2, 5, 6, 0, 0, 1, 2 }, 3);
            Assert.AreEqual(result, false);
        }
    }
}