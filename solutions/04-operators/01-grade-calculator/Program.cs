// Exercise 04-01: Grade Calculator - Reference Solution
// Create a program that calculates grades using various operators

using System;

Console.WriteLine("Grade Calculator");
Console.WriteLine("===============");
Console.WriteLine("");

// Create variables for student information
string studentName = "Alex Johnson";
int pointsEarned = 425;
int totalPoints = 500;

// Calculate percentage using arithmetic operators
double percentage = (double)pointsEarned / totalPoints * 100;

Console.WriteLine("Student: " + studentName);
Console.WriteLine("Points Earned: " + pointsEarned);
Console.WriteLine("Total Points: " + totalPoints);
Console.WriteLine("Percentage: " + percentage.ToString("F1") + "%");
Console.WriteLine("");

Console.WriteLine("Grade Analysis:");

// Use comparison operators to determine letter grade
bool isA = percentage >= 90;
bool isB = percentage >= 80 && percentage < 90;
bool isC = percentage >= 70 && percentage < 80;
bool isD = percentage >= 60 && percentage < 70;

// Use logical operators for additional analysis
bool passedCourse = percentage >= 60;
bool honorRoll = percentage >= 90;
bool needsImprovement = percentage < 70;

// Determine letter grade
string letterGrade = "F";
if (isA)
{
    letterGrade = "A";
}
else if (isB)
{
    letterGrade = "B";
}
else if (isC)
{
    letterGrade = "C";
}
else if (isD)
{
    letterGrade = "D";
}

Console.WriteLine("Letter Grade: " + letterGrade);
Console.WriteLine("Passed Course: " + passedCourse);
Console.WriteLine("Honor Roll (90%+): " + honorRoll);
Console.WriteLine("Needs Improvement (<70%): " + needsImprovement);