﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using _0066.Plus_one;
using System;
using System.Collections.Generic;
using System.Text;

namespace _0066.Plus_one.Tests
{
    [TestClass()]
    public class _0066_Plus_one_Test
    {
        Solution solution = new Solution();

        [TestMethod()]
        public void PlusOne_Test1()
        {
            // Arrange
            int[] digits = { 1, 2, 3 };
            int[] expected = { 1, 2, 4 };

            // Act
            var actual = solution.PlusOne(digits);

            // Assert
            Assert.ReferenceEquals(expected, actual);
        }

        [TestMethod()]
        public void PlusOne_Test2()
        {
            // Arrange
            int[] digits = { 4, 3, 2, 1 };
            int[] expected = { 4, 3, 2, 2 };

            // Act
            var actual = solution.PlusOne(digits);

            // Assert
            Assert.ReferenceEquals(expected, actual);
        }

        [TestMethod()]
        public void PlusOne_Test3()
        {
            // Arrange
            int[] digits = { 0 };
            int[] expected = { 1 };

            // Act
            var actual = solution.PlusOne(digits);

            // Assert
            Assert.ReferenceEquals(expected, actual);
        }
    }
}