using System.Collections.Generic;
using NUnit.Framework;

namespace Problems.Tests
{
    public class GroupAnagramsProblemTests
    {
        [Test]
        public void GroupAnagramsTest1()
        {
            Assert.AreEqual(GroupAnagramsProblem.GroupAnagrams(new[] {"eat", "tea", "tan", "ate", "nat", "bat"}),
                new List<IList<string>> {new List<string> {"eat", "tea", "ate"}, new List<string> {"tan", "nat"}, new List<string> {"bat"}});
        }
    }
}