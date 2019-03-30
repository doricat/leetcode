using System.Collections.Generic;
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
            var result = BTree.BuildTree(new[] {3, 9, 20, 15, 7}, new[] {9, 3, 15, 20, 7});
        }

        [Test]
        public void PathSumTest1()
        {
            var result = BTree.PathSum(new TreeNode(5)
            {
                left = new TreeNode(4)
                {
                    left = new TreeNode(11)
                    {
                        left = new TreeNode(7),
                        right = new TreeNode(2)
                    }
                },
                right = new TreeNode(8)
                {
                    left = new TreeNode(13),
                    right = new TreeNode(4)
                    {
                        left = new TreeNode(5),
                        right = new TreeNode(1)
                    }
                }
            }, 22);

            Assert.AreEqual(result, new List<IList<int>>
            {
                new List<int> {5, 4, 11, 2},
                new List<int> {5, 8, 4, 5}
            });
        }

        [Test]
        public void PathSumTest2()
        {
            var result = BTree.PathSum(new TreeNode(1)
            {
                left = new TreeNode(2)
            }, 1);

            Assert.AreEqual(result.Count, 0);
        }

        [Test]
        public void FlattenTest1()
        {
            var tree = new TreeNode(1)
            {
                left = new TreeNode(2)
                {
                    left = new TreeNode(3),
                    right = new TreeNode(4)
                },
                right = new TreeNode(5)
                {
                    right = new TreeNode(6)
                }
            };
            BTree.Flatten(tree);
        }
    }
}