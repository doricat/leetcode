using NUnit.Framework;

namespace Problems.Tests
{
    public class ContainerWithMostWaterTests
    {
        [Test]
        public void MaxAreaTest1()
        {
            var result = ContainerWithMostWater.MaxArea(new[] {1, 8, 6, 2, 5, 4, 8, 3, 7});
            Assert.AreEqual(result, 49);
        }
    }
}