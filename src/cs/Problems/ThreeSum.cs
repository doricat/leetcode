using System.Collections.Generic;
using System.Linq;

namespace Problems
{
    public partial class Solution
    {
        public static IList<IList<int>> ThreeSum(int[] nums)
        {
            var result = new List<IList<int>>();
            nums = nums.OrderBy(x => x).ToArray();
            for (var i = 0; i < nums.Length - 2; i++)
            {
                var j = i + 1;
                var k = nums.Length - 1;
                while (j < k)
                {
                    if (nums[i] + nums[j] + nums[k] == 0)
                    {
                        result.Add(new List<int> {nums[i], nums[j], nums[k]});
                        j++;
                        k--;

                        while (j < k && nums[j - 1] == nums[j])
                        {
                            j++;
                        }

                        while (j < k && nums[k] == nums[k + 1])
                        {
                            k--;
                        }
                    }
                    else if (nums[i] + nums[j] + nums[k] < 0)
                    {
                        j++;
                    }
                    else
                    {
                        k--;
                    }
                }

                while (i < nums.Length - 1 && nums[i] == nums[i + 1])
                {
                    i++;
                }
            }

            return result;
        }
    }
}