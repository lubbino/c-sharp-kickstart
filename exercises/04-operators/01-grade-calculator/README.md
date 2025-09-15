# Exercise 04-01: Grade Calculator

## Background

This exercise helps you practice using arithmetic and comparison operators to calculate grades and determine pass/fail status.

## Instructions

Create a C# console application that calculates a student's grade percentage and determines their letter grade using various operators.

## Requirements

1. Create variables for student information and scores
2. Calculate the percentage using arithmetic operators
3. Use comparison operators to determine the letter grade
4. Use logical operators to determine pass/fail status
5. Display all calculations and results clearly

## Expected Output

Your program should produce output similar to this:

```
Grade Calculator
===============

Student: Alex Johnson
Points Earned: 425
Total Points: 500
Percentage: 85%

Grade Analysis:
Letter Grade: B
Passed Course: True
Honor Roll (90%+): False
Needs Improvement (<70%): False

Grade Breakdown:
A: 90% and above
B: 80% to 89%
C: 70% to 79%
D: 60% to 69%
F: Below 60%
```

## Hints

- Use arithmetic operators to calculate percentage: `(pointsEarned / totalPoints) * 100`
- Use comparison operators to check grade ranges: `percentage >= 90`
- Use logical operators to combine conditions: `percentage >= 60 && percentage < 70`
- Cast to double for decimal division: `(double)pointsEarned / totalPoints`

## Getting Started

1. Create a new console application:
   ```bash
   dotnet new console -n GradeCalculator
   cd GradeCalculator
   ```

2. Open `Program.cs` in your editor

3. Create variables for student data and calculate grades

4. Run your program:
   ```bash
   dotnet run
   ```

## Testing Your Solution

Your program should:
- Compile without errors
- Calculate percentage correctly using arithmetic operators
- Determine letter grade using comparison operators
- Show pass/fail status using logical operators
- Display all information in a clear, organized format
- Handle decimal calculations properly