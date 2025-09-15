// Exercise 03-02: Type Conversion - Reference Solution
// Create a program that demonstrates converting between different data types

using System;

Console.WriteLine("Type Conversion Demonstration");
Console.WriteLine("============================");
Console.WriteLine("");

Console.WriteLine("String to Number Conversion:");
string ageText = "25";
int age = int.Parse(ageText);
Console.WriteLine("Age as text: \"" + ageText + "\"");
Console.WriteLine("Age as number: " + age);

string priceText = "19.99";
double price = double.Parse(priceText);
Console.WriteLine("Price as text: \"" + priceText + "\"");
Console.WriteLine("Price as number: " + price);

Console.WriteLine("");
Console.WriteLine("Number to String Conversion:");
int score = 95;
string scoreText = score.ToString();
Console.WriteLine("Score as number: " + score);
Console.WriteLine("Score as text: \"" + scoreText + "\"");

double temperature = 23.5;
string tempText = temperature.ToString();
Console.WriteLine("Temperature as number: " + temperature);
Console.WriteLine("Temperature as text: \"" + tempText + "\"");

Console.WriteLine("");
Console.WriteLine("Explicit Casting:");
double originalPrice = 29.99;
int roundedPrice = (int)originalPrice;
Console.WriteLine("Original price: " + originalPrice);
Console.WriteLine("Rounded price: " + roundedPrice);

double pi = 3.14159;
int truncatedPi = (int)pi;
Console.WriteLine("Pi: " + pi);
Console.WriteLine("Truncated Pi: " + truncatedPi);

Console.WriteLine("");
Console.WriteLine("Mixed Type Calculations:");
int quantity = 3;
double unitPrice = 15.50;
double totalPrice = quantity * unitPrice;
Console.WriteLine("Quantity: " + quantity);
Console.WriteLine("Unit Price: $" + unitPrice);
Console.WriteLine("Total Price: $" + totalPrice);