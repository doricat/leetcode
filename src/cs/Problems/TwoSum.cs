using System.Linq;

namespace Problems
{
    public partial class Solution
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            var result = new int[2];
            var list = nums.ToList();
            for (var i = 0; i < list.Count - 1; i++)
            {
                var o = target - list[i];
                var index = list.IndexOf(o, i + 1);
                if (index != -1)
                {
                    result[0] = i;
                    result[1] = index;
                    break;
                }
            }

            return result;
        }
    }
}