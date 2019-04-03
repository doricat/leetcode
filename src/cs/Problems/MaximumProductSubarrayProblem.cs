using System;

namespace Problems
{
    public class MaximumProductSubarrayProblem
    {
        // https://leetcode.com/problems/maximum-product-subarray/
        public static int MaxProduct(int[] nums)
        {
            if (nums.Length == 1)
            {
                return nums[0];
            }

            var result = nums[0];
            var max = nums[0];
            var min = nums[0];
            for (var i = 1; i < nums.Length; i++)
            {
                var t = max;
                max = Math.Max(Math.Max(max * nums[i], nums[i]), min * nums[i]);
                min = Math.Min(Math.Min(t * nums[i], nums[i]), min * nums[i]);
                result = Math.Max(max, result);
            }

            return result;
        }
    }
}