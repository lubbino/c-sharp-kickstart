# Exercise 09-01: Grade Analyzer

## Background

This exercise helps you practice working with arrays and lists to store, process, and analyze collections of data using loops and methods.

## Instructions

Create a C# console application that collects student grades and performs various statistical analyses using arrays and lists.

## Requirements

1. Collect an unknown number of grades from the user (until they type "done")
2. Store grades in a List<double> for dynamic sizing
3. Implement methods to calculate statistics
4. Display comprehensive analysis of the grades
5. Handle invalid input gracefully

## Required Methods

```csharp
static double CalculateAverage(List<double> grades)
static double FindHighest(List<double> grades)
static double FindLowest(List<double> grades)
static int CountPassingGrades(List<double> grades, double passingScore)
static List<double> GetGradesAboveAverage(List<double> grades, double average)
static void DisplayGradeDistribution(List<double> grades)
```

## Expected Output

Your program should produce output similar to this:

```
Grade Analyzer
=============

Enter grades one at a time (type 'done' when finished):

Enter grade: 85.5
Enter grade: 92.0
Enter grade: 78.5
Enter grade: 96.0
Enter grade: 88.0
Enter grade: abc
Invalid grade! Please enter a number.
Enter grade: 74.5
Enter grade: done

Grade Analysis Report
====================

Grades entered: [85.5, 92.0, 78.5, 96.0, 88.0, 74.5]
Number of grades: 6

Statistics:
----------
Average: 85.75
Highest: 96.0
Lowest: 74.5
Passing grades (≥70): 6
Failing grades (<70): 0

Grades above average (85.75):
92.0, 96.0, 88.0

Grade Distribution:
------------------
A (90-100): 2 grades
B (80-89): 2 grades
C (70-79): 2 grades
D (60-69): 0 grades
F (0-59): 0 grades
```

## Hints

- Use `List<double>` for dynamic grade storage
- Use `double.TryParse()` for input validation
- Use foreach loops to process the grade list
- For grades above average: compare each grade to the calculated average
- For grade distribution: use if/else statements to categorize grades
- Use `string.Join(", ", grades)` to display the list nicely

## Getting Started

1. Create a new console application:
   ```bash
   dotnet new console -n GradeAnalyzer
   cd GradeAnalyzer
   ```

2. Open `Program.cs` in your editor

3. Create all required methods first

4. Implement the main program logic

5. Run your program:
   ```bash
   dotnet run
   ```

## Testing Your Solution

Your program should:
- Compile without errors
- Use List<double> to store grades dynamically
- Implement all required statistical methods
- Handle invalid input gracefully
- Display comprehensive grade analysis
- Show grade distribution by letter grade
- Use appropriate loops for data processing