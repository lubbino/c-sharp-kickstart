// Exercise 03-01: Personal Information - Reference Solution
// Create a program that stores and displays personal information using variables

using System;

// Declare variables for personal information
string firstName = "Alice";
string lastName = "Johnson";
int age = 25;
double height = 5.6; // feet
bool isStudent = true;
string city = "Stockholm";

Console.WriteLine("Personal Information");
Console.WriteLine("===================");

// Display the information using the variables
Console.WriteLine("Name: " + firstName + " " + lastName);
Console.WriteLine("Age: " + age + " years old");
Console.WriteLine("Height: " + height + " feet");
Console.WriteLine("Student: " + isStudent);
Console.WriteLine("City: " + city);

// Calculate and display birth year
int currentYear = 2024;
int birthYear = currentYear - age;
Console.WriteLine("Birth Year: " + birthYear);