using System;
using Xunit;

namespace UtilityMethods.Tests
{
    public class UtilityMethodsTests
    {
        [Theory]
        [InlineData(2, true)]
        [InlineData(4, true)]
        [InlineData(10, true)]
        [InlineData(1, false)]
        [InlineData(3, false)]
        [InlineData(7, false)]
        public void IsEven_ShouldReturnCorrectResult(int number, bool expected)
        {
            // Act
            bool result = Utilities.IsEven(number);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(5, 10, 10)]
        [InlineData(15, 3, 15)]
        [InlineData(-5, -10, -5)]
        [InlineData(0, 0, 0)]
        public void GetMax_ShouldReturnLargerNumber(int a, int b, int expected)
        {
            // Act
            int result = Utilities.GetMax(a, b);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("Hello", "olleH")]
        [InlineData("Programming", "gnimmargorP")]
        [InlineData("C#", "#C")]
        [InlineData("", "")]
        [InlineData("a", "a")]
        public void ReverseString_ShouldReturnReversedString(string input, string expected)
        {
            // Act
            string result = Utilities.ReverseString(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("Hello World", 3)]
        [InlineData("Programming", 3)]
        [InlineData("AEIOU", 5)]
        [InlineData("bcdfg", 0)]
        [InlineData("", 0)]
        public void CountVowels_ShouldReturnCorrectCount(string text, int expected)
        {
            // Act
            int result = Utilities.CountVowels(text);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(2, true)]
        [InlineData(3, true)]
        [InlineData(5, true)]
        [InlineData(7, true)]
        [InlineData(11, true)]
        [InlineData(13, true)]
        [InlineData(17, true)]
        [InlineData(19, true)]
        [InlineData(1, false)]
        [InlineData(4, false)]
        [InlineData(6, false)]
        [InlineData(8, false)]
        [InlineData(9, false)]
        [InlineData(10, false)]
        [InlineData(15, false)]
        [InlineData(20, false)]
        public void IsPrime_ShouldReturnCorrectResult(int number, bool expected)
        {
            // Act
            bool result = Utilities.IsPrime(number);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}