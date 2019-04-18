using NUnit.Framework;

namespace Problems.Tests
{
    public class VerifyPreOrderSerializationOfABinaryTreeTests
    {
        [Test]
        public void IsValidSerializationTest1()
        {
            Assert.AreEqual(VerifyPreOrderSerializationOfABinaryTree.IsValidSerialization("9,3,4,#,#,1,#,#,2,#,6,#,#"), true);
        }

        [Test]
        public void IsValidSerializationTest2()
        {
            Assert.AreEqual(VerifyPreOrderSerializationOfABinaryTree.IsValidSerialization("1,#"), false);
        }

        [Test]
        public void IsValidSerializationTest3()
        {
            Assert.AreEqual(VerifyPreOrderSerializationOfABinaryTree.IsValidSerialization("9,#,#,1"), false);
        }
    }
}