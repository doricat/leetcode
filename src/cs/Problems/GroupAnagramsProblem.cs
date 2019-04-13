using System.Collections.Generic;
using System.Linq;

namespace Problems
{
    public class GroupAnagramsProblem
    {
        // https://leetcode.com/problems/group-anagrams/
        public static IList<IList<string>> GroupAnagrams(string[] strs)
        {
            var dict = new Dictionary<string, IList<string>>();
            foreach (var str in strs)
            {
                var s = new string(str.OrderBy(x => x).ToArray());
                if (dict.ContainsKey(s))
                {
                    dict[s].Add(str);
                }
                else
                {
                    dict.Add(s, new List<string> {str});
                }
            }

            return dict.Select(x => x.Value).ToList();
        }
    }
}