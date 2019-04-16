using NUnit.Framework;

namespace Problems.Tests
{
    public class ValidParenthesesProblemTests
    {
        [Test]
        public void IsValidTest1()
        {
            Assert.AreEqual(ValidParenthesesProblem.IsValid("()"), true);
        }

        [Test]
        public void IsValidTest2()
        {
            Assert.AreEqual(ValidParenthesesProblem.IsValid("()[]{}"), true);
        }

        [Test]
        public void IsValidTest3()
        {
            Assert.AreEqual(ValidParenthesesProblem.IsValid("{[]}"), true);
        }

        [Test]
        public void IsValidTest4()
        {
            Assert.AreEqual(ValidParenthesesProblem.IsValid("(]"), false);
        }

        [Test]
        public void IsValidTest5()
        {
            Assert.AreEqual(ValidParenthesesProblem.IsValid("([)]"), false);
        }

        [Test]
        public void IsValidTest6()
        {
            Assert.AreEqual(ValidParenthesesProblem.IsValid("(("), false);
        }
    }
}