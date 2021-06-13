﻿using System;
using System.Collections.Generic;

namespace _1431.Kids_with_the_greatest_number_of_candies
{
    public class Solution
    {
        public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            if (candies.Length == 0) return null;

            IList<bool> res = new List<bool>();
            int i;
            int max = 0;

            for (i = 0; i < candies.Length; i++)
            {
                if (max < candies[i])
                    max = candies[i];
            }

            for (i = 0; i < candies.Length; i++)
                res.Add(candies[i] + extraCandies >= max);

            return res;
        }
    }
}
