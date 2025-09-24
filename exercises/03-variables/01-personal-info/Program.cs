// Exercise 03-01: Personal Information
// Create a program that stores and displays personal information using variables

using System;

// TODO: Declare variables for personal information
// Use appropriate data types: string, int, double, bool

// Example:
// string firstName = "Your Name";

//Basic information about human writing this program.
string firstName = "Ludvig";
string lastName = "Lifbom";
int age = 18;
int favoriteNumber = 30;
bool isStudent = true;
double height = 181.1;

//Current year variable.
int currentYear = 2025;

//Birth year
int birthYear = currentYear - age;


Console.WriteLine("Personal Information");
Console.WriteLine("===================");
Console.WriteLine("Name: " + firstName + " " + lastName);
Console.WriteLine("Age: " + age + " years old.");
Console.WriteLine("Birth year: " + birthYear);
Console.WriteLine("Height: " + height + " cm.");
Console.WriteLine("Student: " + isStudent);
Console.WriteLine("Favorite Number: " + favoriteNumber);

// TODO: Display the information using the variables
// Format: "Name: " + firstName + " " + lastName

// TODO: Calculate and display birth year
// int currentYear = 2024;
// int birthYear = currentYear - age;