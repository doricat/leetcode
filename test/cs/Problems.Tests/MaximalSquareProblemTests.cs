using NUnit.Framework;

namespace Problems.Tests
{
    public class MaximalSquareProblemTests
    {
        [Test]
        public void MaximalSquareTest1()
        {
            Assert.AreEqual(MaximalSquareProblem.MaximalSquare(new[]
            {
                "10100".ToCharArray(),
                "10111".ToCharArray(),
                "11111".ToCharArray(),
                "10010".ToCharArray()
            }), 4);
        }

        [Test]
        public void MaximalSquareTest2()
        {
            Assert.AreEqual(MaximalSquareProblem.MaximalSquare(new[]
            {
                "111".ToCharArray(),
                "111".ToCharArray(),
                "111".ToCharArray()
            }), 9);
        }

        [Test]
        public void MaximalSquareTest3()
        {
            Assert.AreEqual(MaximalSquareProblem.MaximalSquare(new[]
            {
                "01".ToCharArray(),
                "10".ToCharArray()
            }), 1);
        }
    }
}