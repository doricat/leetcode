using System.Linq;

namespace Problems
{
    public partial class Solution
    {
        public static int ThreeSumClosest(int[] nums, int target)
        {
            nums = nums.OrderBy(x => x).ToArray();
            var distance = int.MaxValue;
            var result = 0;
            for (var i = 0; i < nums.Length - 2; i++)
            {
                var j = i + 1;
                var k = nums.Length - 1;
                while (j < k)
                {
                    var value = nums[i] + nums[j] + nums[k];
                    int tempDistance;
                    if (value < target)
                    {
                        tempDistance = target - value;
                        if (tempDistance < distance)
                        {
                            distance = tempDistance;
                            result = value;
                        }

                        j++;
                    }
                    else if (value > target)
                    {
                        tempDistance = value - target;
                        if (tempDistance < distance)
                        {
                            distance = tempDistance;
                            result = value;
                        }

                        k--;
                    }
                    else
                    {
                        result = value;
                        return result;
                    }
                }
            }

            return result;
        }
    }
}