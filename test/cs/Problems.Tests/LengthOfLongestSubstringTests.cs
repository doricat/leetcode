using NUnit.Framework;

namespace Problems.Tests
{
    public class LengthOfLongestSubstringTests
    {
        [Test]
        public void LengthOfLongestSubstringTest1()
        {
            var result = Solution.LengthOfLongestSubstring("pwwkew");
            Assert.AreEqual(result, 3);
        }

        [Test]
        public void LengthOfLongestSubstringTest2()
        {
            var result = Solution.LengthOfLongestSubstring("abcabcbb");
            Assert.AreEqual(result, 3);
        }

        [Test]
        public void LengthOfLongestSubstringTest3()
        {
            var result = Solution.LengthOfLongestSubstring("aa");
            Assert.AreEqual(result, 1);
        }

        [Test]
        public void LengthOfLongestSubstringTest4()
        {
            var result = Solution.LengthOfLongestSubstring("ab");
            Assert.AreEqual(result, 2);
        }

        [Test]
        public void LengthOfLongestSubstringTest5()
        {
            var result = Solution.LengthOfLongestSubstring("aab");
            Assert.AreEqual(result, 2);
        }

        [Test]
        public void LengthOfLongestSubstringTest6()
        {
            var result = Solution.LengthOfLongestSubstring("abab");
            Assert.AreEqual(result, 2);
        }
    }
}