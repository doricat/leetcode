using NUnit.Framework;

namespace Problems.Tests
{
    public class LinkedListProblemTests
    {
        [Test]
        public void RemoveNthFromEndTest1()
        {
            var result = LinkedListProblem.RemoveNthFromEnd(new LinkedListProblem.ListNode(1)
            {
                next = new LinkedListProblem.ListNode(2)
                {
                    next = new LinkedListProblem.ListNode(3)
                    {
                        next = new LinkedListProblem.ListNode(4)
                        {
                            next = new LinkedListProblem.ListNode(5)
                        }
                    }
                }
            }, 5);

            Assert.AreEqual(result.ToNums(), new[] {2, 3, 4, 5});
        }

        [Test]
        public void RemoveNthFromEndTest2()
        {
            var result = LinkedListProblem.RemoveNthFromEnd(new LinkedListProblem.ListNode(1)
            {
                next = new LinkedListProblem.ListNode(2)
                {
                    next = new LinkedListProblem.ListNode(3)
                    {
                        next = new LinkedListProblem.ListNode(4)
                        {
                            next = new LinkedListProblem.ListNode(5)
                        }
                    }
                }
            }, 1);

            Assert.AreEqual(result.ToNums(), new[] {1, 2, 3, 4});
        }

        [Test]
        public void RemoveNthFromEndTest3()
        {
            var result = LinkedListProblem.RemoveNthFromEnd(new LinkedListProblem.ListNode(1)
            {
                next = new LinkedListProblem.ListNode(2)
                {
                    next = new LinkedListProblem.ListNode(3)
                    {
                        next = new LinkedListProblem.ListNode(4)
                        {
                            next = new LinkedListProblem.ListNode(5)
                        }
                    }
                }
            }, 2);

            Assert.AreEqual(result.ToNums(), new[] {1, 2, 3, 5});
        }
    }
}