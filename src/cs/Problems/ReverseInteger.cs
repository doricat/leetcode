using System;

namespace Problems
{
    public class ReverseInteger
    {
        // https://leetcode.com/problems/reverse-integer/
        public static int Reverse(int x)
        {
            var result = 0;
            while (x != 0)
            {
                if (Math.Abs(result) > int.MaxValue / 10)
                {
                    return 0;
                }

                result = result * 10 + x % 10;
                x /= 10;
            }

            return result;
        }
    }
}