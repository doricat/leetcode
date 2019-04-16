using System.Collections.Generic;
using NUnit.Framework;

namespace Problems.Tests
{
    public class BinaryTreePreOrderTraversalProblemTests
    {
        [Test]
        public void PreOrderTraversalTest1()
        {
            Assert.AreEqual(BinaryTreePreOrderTraversalProblem.PreOrderTraversal(new TreeNode(1) {right = new TreeNode(2) {left = new TreeNode(3)}}), new List<int> {1, 2, 3});
        }
    }
}