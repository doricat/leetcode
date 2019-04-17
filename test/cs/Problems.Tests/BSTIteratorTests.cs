using System;
using NUnit.Framework;

namespace Problems.Tests
{
    public class BSTIteratorTests
    {
        [Test]
        public void NextTest1()
        {
            var iterator = new BSTIterator(new TreeNode(7)
            {
                left = new TreeNode(3),
                right = new TreeNode(15)
                {
                    left = new TreeNode(9),
                    right = new TreeNode(20)
                }
            });
            while (iterator.HasNext())
            {
                Console.WriteLine(iterator.Next());
            }
        }
    }
}