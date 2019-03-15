using System;

namespace Problems
{
    public class ContainerWithMostWater
    {
        public static int MaxArea(int[] height)
        {
            var max = 0;
            for (int i = 0, j = height.Length - 1; i < j;)
            {
                max = Math.Max(max, Math.Min(height[i], height[j]) * (j - i));
                if (height[i] < height[j])
                {
                    i++;
                }
                else
                {
                    j--;
                }
            }

            return max;
        }
    }
}