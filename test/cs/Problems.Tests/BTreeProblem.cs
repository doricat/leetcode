using NUnit.Framework;
using Problems.DynamicProgramming;

namespace Problems.Tests
{
    public class BTreeProblemTests
    {
        [Test]
        public void NumTreesTest1()
        {
            var result = BTreeProblem.NumTrees(3);
            Assert.AreEqual(result, 5);
        }
    }
}