using System.Collections.Generic;
using System.Linq;

namespace Problems
{
    public class LetterCombinationsOfAPhoneNumber
    {
        private static readonly IDictionary<char, string> Map = new Dictionary<char, string>
        {
            {'2', "abc"},
            {'3', "def"},
            {'4', "ghi"},
            {'5', "jkl"},
            {'6', "mno"},
            {'7', "pqrs"},
            {'8', "tuv"},
            {'9', "wxyz"}
        };

        public static IList<string> LetterCombinations(string digits)
        {
            if (digits.Length == 0)
            {
                return new List<string>(0);
            }

            var result = new List<char[]>();
            foreach (var c in Map[digits[0]])
            {
                result.Add(new[] {c});
            }

            for (var j = 1; j < digits.Length; j++)
            {
                var chars = Map[digits[j]];
                var len = result.Count;
                for (var k = 0; k < len; k++)
                {
                    var array = result[k];
                    foreach (var c in chars)
                    {
                        var arr = new char[array.Length + 1];
                        array.CopyTo(arr, 0);
                        arr[arr.Length - 1] = c;
                        result.Add(arr);
                    }
                }

                result.RemoveRange(0, len);
            }

            return result.Select(x => new string(x)).ToList();
        }
    }
}