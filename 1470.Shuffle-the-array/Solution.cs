﻿using System;

namespace _1470.Shuffle_the_array
{
    public class Solution
    {
        public int[] Shuffle(int[] nums, int n)
        {
            if (nums.Length == 0) return null;
            if (nums.Length <= n) return nums;

            int[] res = new int[nums.Length];

            for (int i = 0; i < n; i++)
            {
                res[i * 2] = nums[i];
                res[i * 2 + 1] = nums[i + n];
            }

            return res;
        }
    }
}
