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