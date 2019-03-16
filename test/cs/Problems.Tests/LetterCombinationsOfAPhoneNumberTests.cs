using System;
using System.Linq;
using NUnit.Framework;

namespace Problems.Tests
{
    public class LetterCombinationsOfAPhoneNumberTests
    {
        [Test]
        public void LetterCombinationsTest1()
        {
            var result = LetterCombinationsOfAPhoneNumber.LetterCombinations("23");
            Console.Write(string.Join(" ", result.Select(x => string.Join(",", x))));
        }

        [Test]
        public void LetterCombinationsTest2()
        {
            var result = LetterCombinationsOfAPhoneNumber.LetterCombinations("234");
            Console.Write(string.Join(" ", result.Select(x => string.Join(",", x))));
        }

        [Test]
        public void LetterCombinationsTest3()
        {
            var result = LetterCombinationsOfAPhoneNumber.LetterCombinations("5678");
            Console.Write(string.Join(" ", result.Select(x => string.Join(",", x))));
        }

        [Test]
        public void LetterCombinationsTest4()
        {
            var result = LetterCombinationsOfAPhoneNumber.LetterCombinations("2");
            Console.Write(string.Join(" ", result.Select(x => string.Join(",", x))));
        }
    }
}