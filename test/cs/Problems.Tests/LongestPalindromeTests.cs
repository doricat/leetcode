using System;
using NUnit.Framework;

namespace Problems.Tests
{
    public class LongestPalindromeTests
    {
        [Test]
        public void LongestPalindromeTest1()
        {
            var result = Solution.LongestPalindrome("babad");
            Assert.AreEqual(result, "bab");
        }

        [Test]
        public void LongestPalindromeTest2()
        {
            var result = Solution.LongestPalindrome("cbbd");
            Assert.AreEqual(result, "bb");
        }

        [Test]
        public void LongestPalindromeTest3()
        {
            var result = Solution.LongestPalindrome("aaaaaa");
            Assert.AreEqual(result, "aaaaaa");
        }

        [Test]
        public void LongestPalindromeTest4()
        {
            var result = Solution.LongestPalindrome("ab");
            Assert.AreEqual(result, "a");
        }

        [Test]
        public void LongestPalindromeTest5()
        {
            var result = Solution.LongestPalindrome("abcba");
            Assert.AreEqual(result, "abcba");
        }

        [Test]
        public void LongestPalindromeTest6()
        {
            var result = Solution.LongestPalindrome("abcbdadba");
            Assert.AreEqual(result, "bdadb");
        }

        [Test]
        public void LongestPalindromeTest7()
        {
            var result = Solution.LongestPalindrome("bananas");
            Assert.AreEqual(result, "anana");
        }
    }
}