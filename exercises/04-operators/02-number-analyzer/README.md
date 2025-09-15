# Exercise 04-02: Number Analyzer

## Background

This exercise helps you practice using modulus, comparison, and logical operators to analyze properties of numbers.

## Instructions

Create a C# console application that analyzes a number and determines various mathematical properties using different operators.

## Requirements

1. Create a variable with a number to analyze
2. Use the modulus operator (%) to check divisibility
3. Use comparison operators to categorize the number
4. Use logical operators to combine multiple conditions
5. Display all analysis results clearly

## Expected Output

Your program should produce output similar to this:

```
Number Analyzer
==============

Analyzing number: 42

Basic Properties:
Is positive: True
Is negative: False
Is zero: False
Is even: True
Is odd: False

Divisibility Tests:
Divisible by 2: True
Divisible by 3: True
Divisible by 5: False
Divisible by 10: False

Number Categories:
Is single digit (0-9): False
Is double digit (10-99): True
Is triple digit (100-999): False
Is small (< 50): True
Is medium (50-100): False
Is large (> 100): False

Special Properties:
Is perfect square: False
Last digit: 2
```

## Hints

- Use modulus operator to check divisibility: `number % 2 == 0`
- Use comparison operators for ranges: `number >= 10 && number <= 99`
- Use logical operators to combine conditions: `number > 0 && number < 10`
- Get last digit: `number % 10`
- Check perfect squares by comparing with known squares

## Getting Started

1. Create a new console application:
   ```bash
   dotnet new console -n NumberAnalyzer
   cd NumberAnalyzer
   ```

2. Open `Program.cs` in your editor

3. Create analysis logic using various operators

4. Run your program:
   ```bash
   dotnet run
   ```

## Testing Your Solution

Your program should:
- Compile without errors
- Use modulus operator for divisibility tests
- Use comparison operators for number categorization
- Use logical operators to combine conditions
- Display all analysis results clearly
- Work correctly for different input numbers