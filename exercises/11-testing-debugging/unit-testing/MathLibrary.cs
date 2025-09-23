using System;
using System.Collections.Generic;
using System.Linq;

namespace UnitTesting
{
    /// <summary>
    /// Utility class for string operations.
    /// </summary>
    public static class StringUtils
    {
        /// <summary>
        /// Removes leading and trailing whitespace from a string.
        /// </summary>
        public static string Trim(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input ?? "";
            
            return input.Trim();
        }

        /// <summary>
        /// Converts a string to uppercase.
        /// </summary>
        public static string ToUpper(string input)
        {
            return input?.ToUpper() ?? "";
        }

        /// <summary>
        /// Checks if a string contains a substring.
        /// </summary>
        public static bool Contains(string text, string substring)
        {
            if (text == null || substring == null)
                return false;
            
            if (substring == "")
                return true;
                
            return text.Contains(substring);
        }
    }

    /// <summary>
    /// Utility class for mathematical operations.
    /// </summary>
    public static class MathUtils
    {
        /// <summary>
        /// Calculates the distance between two points.
        /// </summary>
        public static double CalculateDistance(double x1, double y1, double x2, double y2)
        {
            double dx = x2 - x1;
            double dy = y2 - y1;
            return Math.Sqrt(dx * dx + dy * dy);
        }

        /// <summary>
        /// Checks if a number is a perfect square.
        /// </summary>
        public static bool IsPerfectSquare(int number)
        {
            if (number < 0)
                return false;
            
            int sqrt = (int)Math.Sqrt(number);
            return sqrt * sqrt == number;
        }

        /// <summary>
        /// Calculates the nth Fibonacci number.
        /// </summary>
        public static long Fibonacci(int n)
        {
            if (n < 0)
                throw new ArgumentException("Fibonacci number cannot be calculated for negative values");
            
            if (n == 0) return 0;
            if (n == 1) return 1;
            
            long a = 0, b = 1;
            for (int i = 2; i <= n; i++)
            {
                long temp = a + b;
                a = b;
                b = temp;
            }
            return b;
        }
    }

    /// <summary>
    /// Utility class for collection operations.
    /// </summary>
    public static class CollectionUtils
    {
        /// <summary>
        /// Removes duplicates from a list while preserving order.
        /// </summary>
        public static List<T> RemoveDuplicates<T>(List<T> list)
        {
            if (list == null)
                throw new ArgumentNullException(nameof(list));
            
            return list.Distinct().ToList();
        }

        /// <summary>
        /// Finds the second largest element in a list.
        /// </summary>
        public static int FindSecondLargest(List<int> numbers)
        {
            if (numbers == null)
                throw new ArgumentNullException(nameof(numbers));
            
            if (numbers.Count < 2)
                throw new ArgumentException("List must contain at least 2 elements");
            
            var distinctNumbers = numbers.Distinct().OrderByDescending(x => x).ToList();
            
            if (distinctNumbers.Count < 2)
                throw new ArgumentException("List must contain at least 2 distinct values");
            
            return distinctNumbers[1];
        }

        /// <summary>
        /// Checks if a list is sorted in ascending order.
        /// </summary>
        public static bool IsSorted<T>(List<T> list) where T : IComparable<T>
        {
            if (list == null)
                throw new ArgumentNullException(nameof(list));
            
            if (list.Count <= 1)
                return true;
            
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i].CompareTo(list[i - 1]) < 0)
                    return false;
            }
            return true;
        }
    }
}