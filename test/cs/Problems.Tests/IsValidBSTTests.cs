using NUnit.Framework;

namespace Problems.Tests
{
    public class IsValidBSTTests
    {
        [Test]
        public void IsValidBSTTest1()
        {
            var result = new ValidateBinarySearchTree().IsValidBST(new ValidateBinarySearchTree.TreeNode(2)
            {
                left = new ValidateBinarySearchTree.TreeNode(1),
                right = new ValidateBinarySearchTree.TreeNode(3)
            });
            Assert.AreEqual(result, true);
        }

        [Test]
        public void IsValidBSTTest2()
        {
            var result = new ValidateBinarySearchTree().IsValidBST(new ValidateBinarySearchTree.TreeNode(5)
            {
                left = new ValidateBinarySearchTree.TreeNode(1),
                right = new ValidateBinarySearchTree.TreeNode(4)
                {
                    left = new ValidateBinarySearchTree.TreeNode(3),
                    right = new ValidateBinarySearchTree.TreeNode(6)
                }
            });
            Assert.AreEqual(result, false);
        }

        [Test]
        public void IsValidBSTTest3()
        {
            var result = new ValidateBinarySearchTree().IsValidBST(new ValidateBinarySearchTree.TreeNode(int.MaxValue));
            Assert.AreEqual(result, true);
        }

        [Test]
        public void IsValidBSTTest4()
        {
            var result = new ValidateBinarySearchTree().IsValidBST(new ValidateBinarySearchTree.TreeNode(1) {left = new ValidateBinarySearchTree.TreeNode(1)});
            Assert.AreEqual(result, false);
        }

        [Test]
        public void IsValidBSTTest5()
        {
            var result = new ValidateBinarySearchTree().IsValidBST(null);
            Assert.AreEqual(result, true);
        }

        [Test]
        public void IsValidBSTTest6()
        {
            var result = new ValidateBinarySearchTree().IsValidBST(new ValidateBinarySearchTree.TreeNode(int.MinValue) {right = new ValidateBinarySearchTree.TreeNode(int.MaxValue)});
            Assert.AreEqual(result, true);
        }

        [Test]
        public void IsValidBSTTest7()
        {
            var result = new ValidateBinarySearchTree().IsValidBST(new ValidateBinarySearchTree.TreeNode(int.MaxValue) {right = new ValidateBinarySearchTree.TreeNode(int.MaxValue)});
            Assert.AreEqual(result, false);
        }
    }
}