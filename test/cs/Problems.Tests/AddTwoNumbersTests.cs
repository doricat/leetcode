using NUnit.Framework;

namespace Problems.Tests
{
    public class AddTwoNumbersTests
    {
        [Test]
        public void AddTwoNumbersTest1()
        {
            var l1 = new ListNode(2) {next = new ListNode(4) {next = new ListNode(3)}};
            var l2 = new ListNode(5) {next = new ListNode(6) {next = new ListNode(4)}};
            var result = Solution.AddTwoNumbers(l1, l2);
            Assert.AreEqual(result.ToNums(), new[] {7, 0, 8});
        }

        [Test]
        public void AddTwoNumbersTest2()
        {
            var l1 = new ListNode(5);
            var l2 = new ListNode(5);
            var result = Solution.AddTwoNumbers(l1, l2);
            Assert.AreEqual(result.ToNums(), new[] {0, 1});
        }

        [Test]
        public void AddTwoNumbersTest3()
        {
            var l1 = new ListNode(1);
            var l2 = new ListNode(9) {next = new ListNode(9)};
            var result = Solution.AddTwoNumbers(l1, l2);
            Assert.AreEqual(result.ToNums(), new[] {0, 0, 1});
        }
    }
}