using System;
using System.Collections.Generic;
using System.Linq;

namespace UnitTesting
{
    /// <summary>
    /// A simple calculator class with basic arithmetic and memory operations.
    /// </summary>
    public class Calculator
    {
        private double memory;

        /// <summary>
        /// Initializes a new instance of the Calculator class.
        /// </summary>
        public Calculator()
        {
            memory = 0.0;
        }

        /// <summary>
        /// Adds two numbers.
        /// </summary>
        public double Add(double a, double b)
        {
            return a + b;
        }

        /// <summary>
        /// Subtracts the second number from the first.
        /// </summary>
        public double Subtract(double a, double b)
        {
            return a - b;
        }

        /// <summary>
        /// Multiplies two numbers.
        /// </summary>
        public double Multiply(double a, double b)
        {
            return a * b;
        }

        /// <summary>
        /// Divides the first number by the second.
        /// </summary>
        /// <exception cref="DivideByZeroException">Thrown when divisor is zero.</exception>
        public double Divide(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException("Cannot divide by zero");
            
            return a / b;
        }

        /// <summary>
        /// Calculates the power of a base number raised to an exponent.
        /// </summary>
        public double Power(double baseNumber, double exponent)
        {
            return Math.Pow(baseNumber, exponent);
        }

        /// <summary>
        /// Stores a value in memory.
        /// </summary>
        public void StoreInMemory(double value)
        {
            memory = value;
        }

        /// <summary>
        /// Recalls the value stored in memory.
        /// </summary>
        public double RecallFromMemory()
        {
            return memory;
        }

        /// <summary>
        /// Clears the memory (sets it to zero).
        /// </summary>
        public void ClearMemory()
        {
            memory = 0.0;
        }
    }

    /// <summary>
    /// A calculator for grade-related operations.
    /// </summary>
    public class GradeCalculator
    {
        /// <summary>
        /// Converts a percentage to a letter grade.
        /// </summary>
        /// <param name="percentage">The percentage (0-100)</param>
        /// <returns>Letter grade (A, B, C, D, or F)</returns>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when percentage is not between 0 and 100.</exception>
        public char GetLetterGrade(double percentage)
        {
            if (percentage < 0 || percentage > 100)
                throw new ArgumentOutOfRangeException(nameof(percentage), "Percentage must be between 0 and 100");

            if (percentage >= 90) return 'A';
            if (percentage >= 80) return 'B';
            if (percentage >= 70) return 'C';
            if (percentage >= 60) return 'D';
            return 'F';
        }

        /// <summary>
        /// Calculates GPA from a list of letter grades.
        /// </summary>
        /// <param name="grades">List of letter grades</param>
        /// <returns>GPA on a 4.0 scale</returns>
        /// <exception cref="ArgumentException">Thrown when grades list is empty or contains invalid grades.</exception>
        public double CalculateGPA(List<char> grades)
        {
            if (grades == null || grades.Count == 0)
                throw new ArgumentException("Grades list cannot be null or empty");

            double totalPoints = 0;
            foreach (char grade in grades)
            {
                totalPoints += GetGradePoints(grade);
            }

            return totalPoints / grades.Count;
        }

        /// <summary>
        /// Determines if a letter grade is passing.
        /// </summary>
        /// <param name="grade">The letter grade</param>
        /// <returns>True if the grade is passing (A, B, C, or D), false if failing (F)</returns>
        public bool IsPassingGrade(char grade)
        {
            return grade != 'F';
        }

        /// <summary>
        /// Converts a letter grade to grade points.
        /// </summary>
        /// <param name="grade">The letter grade</param>
        /// <returns>Grade points on a 4.0 scale</returns>
        /// <exception cref="ArgumentException">Thrown when grade is not a valid letter grade.</exception>
        private double GetGradePoints(char grade)
        {
            return grade switch
            {
                'A' => 4.0,
                'B' => 3.0,
                'C' => 2.0,
                'D' => 1.0,
                'F' => 0.0,
                _ => throw new ArgumentException($"Invalid grade: {grade}")
            };
        }
    }
}