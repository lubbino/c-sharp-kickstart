// Exercise 03-02: Type Conversion
// Create a program that demonstrates converting between different data types

using System;

Console.WriteLine("Type Conversion Demonstration");
Console.WriteLine("============================");
Console.WriteLine("");

Console.WriteLine("String to Number Conversion:");
// TODO: Create string variables and convert them to numbers
// Example:
string ageText = "25";
int age = int.Parse(ageText);
Console.WriteLine("Age as text: \"" + ageText + "\"");
Console.WriteLine("Age as number: " + age);

Console.WriteLine("");
Console.WriteLine("Number to String Conversion:");
// TODO: Create number variables and convert them to strings
// Example:
int score = 95;
string scoreText = score.ToString();

Console.WriteLine("");
Console.WriteLine("Explicit Casting:");
// TODO: Demonstrate casting from double to int
// Example:
double originalPrice = 29.99;
int roundedPrice = (int)originalPrice;

Console.WriteLine("");
Console.WriteLine("Mixed Type Calculations:");
// TODO: Perform calculations with different data types
// Example: multiply int quantity by decimal price
int items = 5;
double price = 14.99;
Console.WriteLine("Items: " + items);
Console.WriteLine("Price per item: $" + price);
Console.WriteLine("Total cost: $" + (price * items));