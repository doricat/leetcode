using NUnit.Framework;

namespace Problems.Tests
{
    public class RegularExpressionMatchingTests
    {
        [Test]
        public void IsMatchTest1()
        {
            var result = RegularExpressionMatching.IsMatch("aa", "a");
            Assert.AreEqual(result, false);
        }

        [Test]
        public void IsMatchTest2()
        {
            var result = RegularExpressionMatching.IsMatch("aa", "a*");
            Assert.AreEqual(result, true);
        }

        [Test]
        public void IsMatchTest3()
        {
            var result = RegularExpressionMatching.IsMatch("ab", ".*");
            Assert.AreEqual(result, true);
        }

        [Test]
        public void IsMatchTest4()
        {
            var result = RegularExpressionMatching.IsMatch("aab", "c*a*b");
            Assert.AreEqual(result, true);
        }

        [Test]
        public void IsMatchTest5()
        {
            var result = RegularExpressionMatching.IsMatch("mississippi", "mis*is*p*.");
            Assert.AreEqual(result, false);
        }

        [Test]
        public void IsMatchTest6()
        {
            var result = RegularExpressionMatching.IsMatch("aaa", "a*a");
            Assert.AreEqual(result, true);
        }

        [Test]
        public void IsMatchTest7()
        {
            var result = RegularExpressionMatching.IsMatch("aaa", "ab*a");
            Assert.AreEqual(result, false);
        }
    }
}