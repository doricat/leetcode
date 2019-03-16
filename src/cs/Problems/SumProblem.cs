using System.Collections.Generic;
using System.Linq;

namespace Problems
{
    public class SumProblem
    {
        public static IList<IList<int>> FourSum(int[] nums, int target)
        {
            var result = new List<IList<int>>();
            nums = nums.OrderBy(x => x).ToArray();

            for (var i = 0; i < nums.Length - 3; i++)
            {
                for (var j = i + 1; j < nums.Length - 2; j++)
                {
                    var k = j + 1;
                    var l = nums.Length - 1;
                    while (k < l)
                    {
                        var sum = nums[i] + nums[j] + nums[k] + nums[l];
                        if (sum == target)
                        {
                            result.Add(new List<int> {nums[i], nums[j], nums[k], nums[l]});
                            k++;
                            l--;

                            while (k < l && nums[k - 1] == nums[k])
                            {
                                k++;
                            }

                            while (k < l && nums[l] == nums[l + 1])
                            {
                                l--;
                            }
                        }
                        else if (sum < target)
                        {
                            k++;
                        }
                        else
                        {
                            l--;
                        }
                    }

                    while (j < nums.Length - 2 && nums[j] == nums[j + 1])
                    {
                        j++;
                    }
                }

                while (i < nums.Length - 3 && nums[i] == nums[i + 1])
                {
                    i++;
                }
            }

            return result;
        }
    }
}