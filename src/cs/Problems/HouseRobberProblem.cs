using System;
using System.Linq;

namespace Problems
{
    public class HouseRobberProblem
    {
        // https://leetcode.com/problems/house-robber-ii/
        public static int Rob2(int[] nums)
        {
            if (nums.Length <= 1)
            {
                return nums.Length == 0 ? 0 : nums[0];
            }

            return Math.Max(Rob2(nums, 0, nums.Length - 1), Rob2(nums, 1, nums.Length));
        }

        private static int Rob2(int[] nums, int l, int r)
        {
            if (r - l <= 1)
            {
                return nums[l];
            }

            var array = new int[r];
            array[l] = nums[l];
            array[l + 1] = Math.Max(nums[l], nums[l + 1]);
            for (var i = l + 2; i < r; i++)
            {
                array[i] = Math.Max(nums[i] + array[i - 2], array[i - 1]);
            }

            return array.Last();
        }
    }
}