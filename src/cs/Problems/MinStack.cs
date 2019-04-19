using System;
using System.Collections.Generic;
using System.Linq;

namespace Problems
{
    // https://leetcode.com/problems/min-stack/
    public class MinStack
    {
        private readonly IList<int> _list = new List<int>();
        private int? _min;

        public MinStack()
        {

        }

        public void Push(int x)
        {
            _min = _min == null ? x : Math.Min(_min.Value, x);
            _list.Add(x);
        }

        public void Pop()
        {
            var value = _list[_list.Count - 1];
            _list.RemoveAt(_list.Count - 1);
            if (_list.Count == 0)
            {
                _min = null;
            }
            else
            {
                if (value == _min)
                {
                    _min = _list.Min();
                }
            }
        }

        public int Top()
        {
            return _list[_list.Count - 1];
        }

        public int GetMin()
        {
            if (_min == null)
            {
                throw new InvalidOperationException();
            }

            return _min.Value;
        }
    }
}