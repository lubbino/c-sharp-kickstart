// Exercise 04-02: Number Analyzer - Reference Solution
// Create a program that analyzes number properties using various operators

using System;

Console.WriteLine("Number Analyzer");
Console.WriteLine("==============");
Console.WriteLine("");

// Create a variable with a number to analyze
int number = 42;

Console.WriteLine("Analyzing number: " + number);
Console.WriteLine("");

Console.WriteLine("Basic Properties:");
// Use comparison operators to check basic properties
bool isPositive = number > 0;
bool isNegative = number < 0;
bool isZero = number == 0;
bool isEven = number % 2 == 0;
bool isOdd = !isEven;

Console.WriteLine("Is Positive: " + isPositive);
Console.WriteLine("Is Negative: " + isNegative);
Console.WriteLine("Is Zero: " + isZero);
Console.WriteLine("Is Even: " + isEven);
Console.WriteLine("Is Odd: " + isOdd);

Console.WriteLine("");
Console.WriteLine("Divisibility Tests:");
// Use modulus operator to check divisibility
bool divisibleBy2 = number % 2 == 0;
bool divisibleBy3 = number % 3 == 0;
bool divisibleBy5 = number % 5 == 0;
bool divisibleBy10 = number % 10 == 0;

Console.WriteLine("Divisible by 2: " + divisibleBy2);
Console.WriteLine("Divisible by 3: " + divisibleBy3);
Console.WriteLine("Divisible by 5: " + divisibleBy5);
Console.WriteLine("Divisible by 10: " + divisibleBy10);

Console.WriteLine("");
Console.WriteLine("Number Categories:");
// Use logical operators to categorize the number
bool isSingleDigit = number >= 0 && number <= 9;
bool isDoubleDigit = number >= 10 && number <= 99;
bool isTripleDigit = number >= 100 && number <= 999;

Console.WriteLine("Single Digit (0-9): " + isSingleDigit);
Console.WriteLine("Double Digit (10-99): " + isDoubleDigit);
Console.WriteLine("Triple Digit (100-999): " + isTripleDigit);

Console.WriteLine("");
Console.WriteLine("Special Properties:");
// Calculate special properties
int lastDigit = number % 10;
int square = number * number;
int doubled = number * 2;

Console.WriteLine("Last Digit: " + lastDigit);
Console.WriteLine("Square: " + square);
Console.WriteLine("Doubled: " + doubled);
Console.WriteLine("Half (integer division): " + (number / 2));