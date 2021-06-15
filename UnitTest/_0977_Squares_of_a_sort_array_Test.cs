﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using _0977.Squares_of_a_sort_array;
using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;

namespace _0977.Squares_of_a_sort_array.Tests
{
    [TestClass()]
    public class _0977_Squares_of_a_sort_array_Test
    {
        Solution solution = new Solution();

        [TestMethod()]
        public void SortedSquares_Test1()
        {
            // Arrange
            int[] nums = { -4, -1, 0, 3, 10 };
            var expected = new int[] { 0, 1, 9, 16, 100 };

            // Act
            var actual = solution.SortedSquares(nums);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }

        [TestMethod()]
        public void SortedSquares_Test2()
        {
            // Arrange
            int[] nums = { -7, -3, 2, 3, 11 };
            var expected = new int[] { 4, 9, 9, 49, 121 };

            // Act
            var actual = solution.SortedSquares(nums);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }
    }
}