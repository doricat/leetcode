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

        [Test]
        public void LevelOrderTest1()
        {
            var result = BTree.LevelOrder(new TreeNode(3)
            {
                left = new TreeNode(9),
                right = new TreeNode(20)
                {
                    left = new TreeNode(15),
                    right = new TreeNode(7)
                }
            });
            Assert.AreEqual(result.SelectMany(x => x.Select(y => y)), new[] {3, 9, 20, 15, 7});
        }

        [Test]
        public void ZigzagLevelOrderTest1()
        {
            var result = BTree.ZigzagLevelOrder(new TreeNode(3)
            {
                left = new TreeNode(9),
                right = new TreeNode(20)
                {
                    left = new TreeNode(15),
                    right = new TreeNode(7)
                }
            });
            Assert.AreEqual(result.SelectMany(x => x.Select(y => y)), new[] {3, 20, 9, 15, 7});
        }

        [Test]
        public void BuildTreeTest1()
        {
            var result = BTree.BuildTree(new [] { 3, 9, 20, 15, 7 }, new [] { 9, 3, 15, 20, 7 });
        }
    }
}