using NUnit.Framework;

namespace Problems.Tests
{
    public class MergeTwoSortedListsTests
    {
        [Test]
        public void MergeTwoListsTest1()
        {
            Assert.AreEqual(MergeTwoSortedLists
                    .MergeTwoLists(ListNode.Parse("1,2,4"), ListNode.Parse("1,3,4")).ToNums(),
                ListNode.Parse("1,1,2,3,4,4").ToNums());
        }

        [Test]
        public void MergeTwoListsTest2()
        {
            Assert.AreEqual(MergeTwoSortedLists.MergeTwoLists(ListNode.Parse("5"), ListNode.Parse("1,2,3")).ToNums(), ListNode.Parse("1,2,3,5").ToNums());
        }
    }
}