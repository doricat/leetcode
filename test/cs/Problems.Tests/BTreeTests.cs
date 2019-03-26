using System.Linq;
using NUnit.Framework;
using Problems.Tree;

namespace Problems.Tests
{
    public class BTreeTests
    {
        [Test]
        public void InorderTraversalTest1()
        {
            var result = BTree.InorderTraversal(new TreeNode(1)
            {
                right = new TreeNode(2)
                {
                    left = new TreeNode(3)
                }
            });
            Assert.AreEqual(result.ToArray(), new[] {1, 3, 2});
        }
    }
}