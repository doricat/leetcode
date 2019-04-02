using System.Collections.Generic;
using NUnit.Framework;

namespace Problems.Tests
{
    public class WordBreakProblemTests
    {
        [Test]
        public void WordBreakTest1()
        {
            Assert.AreEqual(WordBreakProblem.WordBreak("leetcode", new List<string>
            {
                "leet", "code"
            }), true);
        }

        [Test]
        public void WordBreakTest2()
        {
            Assert.AreEqual(WordBreakProblem.WordBreak("applepenapple", new List<string>
            {
                "apple", "pen"
            }), true);
        }

        [Test]
        public void WordBreakTest3()
        {
            Assert.AreEqual(WordBreakProblem.WordBreak("catsandog", new List<string>
            {
                "cats", "dog", "sand", "and", "cat"
            }), false);
        }

        [Test]
        public void WordBreakTest4()
        {
            Assert.AreEqual(WordBreakProblem.WordBreak("aaaaaaa", new List<string>
            {
                "aaaa", "aaa"
            }), true);
        }

        [Test]
        public void WordBreakTest5()
        {
            Assert.AreEqual(WordBreakProblem.WordBreak("cars", new List<string>
            {
                "car", "ca", "rs"
            }), true);
        }
    }
}