namespace Problems
{
    public class ArrayProblem
    {
        public static void NextPermutation(int[] nums)
        {
            for (var i = nums.Length - 2; i >= 0; i--)
            {
                if (nums[i + 1] > nums[i])
                {
                    var j = nums.Length - 1;
                    for (; j > i; j--)
                    {
                        if (nums[j] > nums[i])
                        {
                            break;
                        }
                    }

                    Swap(nums, i, j);
                    Reverse(nums, i + 1, nums.Length);
                    return;
                }
            }

            Reverse(nums, 0, nums.Length);
        }

        // https://leetcode.com/problems/search-in-rotated-sorted-array/
        public static int Search(int[] nums, int target)
        {
            if (nums.Length == 0)
            {
                return -1;
            }

            var m = 0;
            while (m + 1 < nums.Length && nums[m] <= nums[m + 1])
            {
                m++;
            }

            int mid;
            var l = 0;
            var r = m;
            while (l <= r)
            {
                mid = (l + r) / 2;
                if (nums[mid] < target)
                {
                    l = mid + 1;
                }
                else if (nums[mid] > target)
                {
                    r = mid - 1;
                }
                else
                {
                    return mid;
                }
            }

            l = m + 1;
            r = nums.Length - 1;
            while (l <= r)
            {
                mid = (l + r) / 2;
                if (nums[mid] < target)
                {
                    l = mid + 1;
                }
                else if (nums[mid] > target)
                {
                    r = mid - 1;
                }
                else
                {
                    return mid;
                }
            }

            return -1;
        }

        private static void Reverse(int[] nums, int x, int y)
        {
            for (int i = x, j = y - 1; i < j; i++, j--)
            {
                Swap(nums, i, j);
            }
        }

        private static void Swap(int[] nums, int x, int y)
        {
            var i = nums[x];
            nums[x] = nums[y];
            nums[y] = i;
        }
    }
}