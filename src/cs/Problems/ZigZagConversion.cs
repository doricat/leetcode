using System;
using System.Collections.Generic;

namespace Problems
{
    public class ZigZagConversion
    {
        public static string Convert(string s, int numRows)
        {
            if (numRows == 1)
            {
                return s;
            }

            var result = new char[s.Length];
            var n = 2 * numRows - 1;
            var list = new List<List<char>>(numRows);
            var m = (int) Math.Ceiling(s.Length / (double) (n - 1));
            for (var i = 0; i < numRows; i++)
            {
                list.Add(new List<char>(numRows * m));
            }

            var j = 1;
            foreach (var c in s)
            {
                var k = j % n;
                if (k == 0)
                {
                    j = 1;
                    k = 1;
                }

                if (k <= numRows)
                {
                    list[k - 1].Add(c);
                }
                else
                {
                    list[numRows - 1 - k % numRows].Add(c);
                }

                j++;
            }

            var l = 0;
            foreach (var item in list)
            {
                item.CopyTo(0, result, l, item.Count);
                l += item.Count;
            }

            return new string(result);
        }
    }
}