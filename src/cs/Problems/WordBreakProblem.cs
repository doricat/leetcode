using System.Collections.Generic;
using System.Linq;

namespace Problems
{
    public class WordBreakProblem
    {
        // https://leetcode.com/problems/word-break/
        public static bool WordBreak(string s, IList<string> wordDict)
        {
            var array = new bool[s.Length + 1];
            array[0] = true;
            for (var i = 1; i <= s.Length; i++)
            {
                for (var j = i - 1; j >= 0; j--)
                {
                    if (array[j] && wordDict.Any(x => x == s.Substring(j, i - j)))
                    {
                        array[i] = true;
                        break;
                    }
                }
            }

            return array[s.Length];
        }
    }
}