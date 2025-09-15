// Exercise 06-01: Grade Classifier
// Create a program that classifies test scores into letter grades

using System;

Console.WriteLine("Grade Classifier");
Console.WriteLine("===============");
Console.WriteLine("");

Console.WriteLine("Enter your test score (0-100):");
int score = int.Parse(Console.ReadLine());

// TODO: Validate input first
// if (score < 0 || score > 100)
// {
//     Console.WriteLine("Error: Score must be between 0 and 100.");
//     return; // Exit the program
// }

Console.WriteLine("");
Console.WriteLine("Results:");
Console.WriteLine($"Score: {score}");

// TODO: Determine letter grade using if/else if/else
string letterGrade = "";
string feedback = "";

// if (score >= 90)
// {
//     letterGrade = "A";
//     feedback = "Excellent work!";
// }
// else if (score >= 80)
// {
//     letterGrade = "B";
//     feedback = "Good job!";
// }
// else if (score >= 70)
// {
//     letterGrade = "C";
//     feedback = "Satisfactory";
// }
// else if (score >= 60)
// {
//     letterGrade = "D";
//     feedback = "Needs improvement";
// }
// else
// {
//     letterGrade = "F";
//     feedback = "Please see teacher";
// }

Console.WriteLine($"Letter Grade: {letterGrade}");
Console.WriteLine($"Feedback: {feedback}");