using System;
using System.Collections.Generic;

namespace Problems
{
    public class ValidParenthesesProblem
    {
        // https://leetcode.com/problems/valid-parentheses/
        public static bool IsValid(string s)
        {
            if (s.Length % 2 > 0)
            {
                return false;
            }

            var stack = new Stack<char>();
            for (var i = 0; i < s.Length; i++)
            {
                var c = s[i];
                if (c == '(' || c == '[' || c == '{')
                {
                    stack.Push(c);
                }
                else
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }

                    var t = stack.Pop();
                    switch (c)
                    {
                        case ')':
                            if (t != '(')
                            {
                                return false;
                            }
                            break;
                        case ']':
                            if (t != '[')
                            {
                                return false;
                            }
                            break;
                        case '}':
                            if (t != '{')
                            {
                                return false;
                            }
                            break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                }
            }

            return stack.Count == 0;
        }
    }
}