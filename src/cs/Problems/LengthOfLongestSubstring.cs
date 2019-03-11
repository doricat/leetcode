using System;
using System.Collections.Generic;

namespace Problems
{
    public partial class Solution
    {
        public static int LengthOfLongestSubstring(string s)
        {
            if (s.Length == 0 || s.Length == 1)
            {
                return s.Length;
            }

            var result = 0;
            var dict = new Dictionary<char, int>();
            var j = -1;
            for (var i = 0; i < s.Length; i++)
            {
                if (dict.ContainsKey(s[i]) && dict[s[i]] > j)
                {
                    j = dict[s[i]];
                }

                dict[s[i]] = i;
                result = Math.Max(result, i - j);
            }

            return result;
        }
    }
}