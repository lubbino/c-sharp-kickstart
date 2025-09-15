// Exercise 09-01: Grade Analyzer - Reference Solution
// Create a program that analyzes student grades using lists and methods

using System;
using System.Collections.Generic;

// Create statistical analysis methods

static double CalculateAverage(List<double> grades)
{
    if (grades.Count == 0)
    {
        return 0;
    }
    
    double sum = 0;
    foreach (double grade in grades)
    {
        sum += grade;
    }
    return sum / grades.Count;
}

static double FindHighest(List<double> grades)
{
    if (grades.Count == 0)
    {
        return 0;
    }
    
    double highest = grades[0];
    foreach (double grade in grades)
    {
        if (grade > highest)
        {
            highest = grade;
        }
    }
    return highest;
}

static double FindLowest(List<double> grades)
{
    if (grades.Count == 0)
    {
        return 0;
    }
    
    double lowest = grades[0];
    foreach (double grade in grades)
    {
        if (grade < lowest)
        {
            lowest = grade;
        }
    }
    return lowest;
}

static int CountPassingGrades(List<double> grades, double passingScore)
{
    int count = 0;
    foreach (double grade in grades)
    {
        if (grade >= passingScore)
        {
            count++;
        }
    }
    return count;
}

static List<double> GetGradesAboveAverage(List<double> grades, double average)
{
    List<double> aboveAverage = new List<double>();
    foreach (double grade in grades)
    {
        if (grade > average)
        {
            aboveAverage.Add(grade);
        }
    }
    return aboveAverage;
}

static void DisplayGradeDistribution(List<double> grades)
{
    int countA = 0, countB = 0, countC = 0, countD = 0, countF = 0;
    
    foreach (double grade in grades)
    {
        if (grade >= 90)
        {
            countA++;
        }
        else if (grade >= 80)
        {
            countB++;
        }
        else if (grade >= 70)
        {
            countC++;
        }
        else if (grade >= 60)
        {
            countD++;
        }
        else
        {
            countF++;
        }
    }
    
    Console.WriteLine("Grade Distribution:");
    Console.WriteLine("------------------");
    Console.WriteLine($"A (90-100): {countA} grades");
    Console.WriteLine($"B (80-89): {countB} grades");
    Console.WriteLine($"C (70-79): {countC} grades");
    Console.WriteLine($"D (60-69): {countD} grades");
    Console.WriteLine($"F (0-59): {countF} grades");
}

Console.WriteLine("Grade Analyzer");
Console.WriteLine("=============");
Console.WriteLine("");

List<double> grades = new List<double>();

Console.WriteLine("Enter grades one at a time (type 'done' when finished):");
Console.WriteLine("");

// Collect grades from user
string input;
do
{
    Console.WriteLine("Enter grade:");
    input = Console.ReadLine() ?? "";
    
    if (input.ToLower() != "done")
    {
        // Validate and add grade to list
        if (double.TryParse(input, out double grade) && grade >= 0 && grade <= 100)
        {
            grades.Add(grade);
            Console.WriteLine($"Added grade: {grade}");
        }
        else
        {
            Console.WriteLine("Invalid grade! Please enter a number between 0 and 100.");
        }
    }
} while (input.ToLower() != "done");

// Display analysis if grades were entered
if (grades.Count > 0)
{
    Console.WriteLine("\nGrade Analysis Report");
    Console.WriteLine("====================");
    Console.WriteLine("");
    
    Console.WriteLine($"Grades entered: [{string.Join(", ", grades)}]");
    Console.WriteLine($"Number of grades: {grades.Count}");
    Console.WriteLine("");
    
    // Calculate and display statistics
    double average = CalculateAverage(grades);
    double highest = FindHighest(grades);
    double lowest = FindLowest(grades);
    int passing = CountPassingGrades(grades, 70);
    int failing = grades.Count - passing;
    
    Console.WriteLine("Statistics:");
    Console.WriteLine("----------");
    Console.WriteLine($"Average: {average:F2}");
    Console.WriteLine($"Highest: {highest}");
    Console.WriteLine($"Lowest: {lowest}");
    Console.WriteLine($"Passing grades (≥70): {passing}");
    Console.WriteLine($"Failing grades (<70): {failing}");
    Console.WriteLine("");
    
    // Show grades above average
    List<double> aboveAverage = GetGradesAboveAverage(grades, average);
    Console.WriteLine($"Grades above average ({average:F2}):");
    if (aboveAverage.Count > 0)
    {
        Console.WriteLine(string.Join(", ", aboveAverage));
    }
    else
    {
        Console.WriteLine("No grades above average.");
    }
    Console.WriteLine("");
    
    // Show grade distribution
    DisplayGradeDistribution(grades);
}
else
{
    Console.WriteLine("No grades were entered.");
}

Console.WriteLine("");
Console.WriteLine("Thank you for using the Grade Analyzer!");