using NUnit.Framework;

namespace Problems.Tests
{
    public class HouseRobberProblemTest
    {
        [Test]
        public void Rob2Test1()
        {
            Assert.AreEqual(HouseRobberProblem.Rob2(new[] {2, 3, 2}), 3);
        }

        [Test]
        public void Rob2Test2()
        {
            Assert.AreEqual(HouseRobberProblem.Rob2(new[] {1, 2, 3, 1, 5, 4}), 9);
        }

        [Test]
        public void Rob2Test3()
        {
            Assert.AreEqual(HouseRobberProblem.Rob2(new[] {1, 2, 3, 1}), 4);
        }

        [Test]
        public void Rob2Test4()
        {
            Assert.AreEqual(HouseRobberProblem.Rob2(new[] {1, 2, 3, 1, 5}), 8);
        }

        [Test]
        public void Rob2Test5()
        {
            Assert.AreEqual(HouseRobberProblem.Rob2(new[] {1, 2, 3, 1, 5, 4, 2}), 10);
        }

        [Test]
        public void Rob2Test6()
        {
            Assert.AreEqual(HouseRobberProblem.Rob2(new[] {1, 1, 3, 6, 7, 10, 7, 1, 8, 5, 9, 1, 4, 4, 3}), 41);
        }
    }
}