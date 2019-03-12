namespace Problems
{
    public partial class Solution
    {
        public static string LongestPalindrome(string s)
        {
            if (s.Length == 0 || s.Length == 1)
            {
                return s;
            }

            var len = 0;
            var left = 0;
            for (var i = 0; i < s.Length - 1; i++)
            {
                for (var j = s.Length - 1; j > i; j--)
                {
                    if (s[i] == s[j])
                    {
                        for (int k = i, l = j; k <= l; k++, l--)
                        {
                            if (s[k] != s[l])
                            {
                                break;
                            }

                            if (k == l || k + 1 == l)
                            {
                                var v = j - i + 1;
                                if (v > len)
                                {
                                    len = v;
                                    left = i;
                                }
                            }
                        }
                    }
                }

                if (len == s.Length)
                {
                    break;
                }
            }

            return len == 0 ? s[0].ToString() : len == s.Length ? s : s.Substring(left, len);
        }
    }
}