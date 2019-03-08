using System;
using System.Collections.Generic;
using System.Linq;

namespace Problems
{
    public partial class Solution
    {
        public static IList<IList<int>> ThreeSum(int[] nums)
        {
            var result = new List<IList<int>>();
            var list = nums.ToList();
            for (var i = 0; i < list.Count - 2; i++)
            {
                for (var j = i + 1; j < list.Count - 1; j++)
                {
                    var o = 0 - list[i] - list[j];
                    var index = list.IndexOf(o, j + 1);
                    if (index != - 1)
                    {
                        result.Add(new List<int> {list[i], list[j], o});
                    }
                }
            }

            return result;
        }
    }
}