// Exercise 06-02: Menu System
// Create a menu-driven program using switch statements

using System;

Console.WriteLine("Main Menu");
Console.WriteLine("=========");
Console.WriteLine("1. Calculate area of rectangle");
Console.WriteLine("2. Calculate area of circle");
Console.WriteLine("3. Convert temperature (C to F)");
Console.WriteLine("4. Exit");
Console.WriteLine("");
Console.WriteLine("Enter your choice (1-4):");

int choice = int.Parse(Console.ReadLine());

// TODO: Use switch statement to handle menu choices
switch (choice)
{
    case 1:
        // TODO: Rectangle area calculation
        // Console.WriteLine("Rectangle Area Calculator");
        // Console.WriteLine("========================");
        // Console.WriteLine("Enter length:");
        // double length = double.Parse(Console.ReadLine());
        // Console.WriteLine("Enter width:");
        // double width = double.Parse(Console.ReadLine());
        // double rectArea = length * width;
        // Console.WriteLine($"Area of rectangle: {rectArea}");
        break;
        
    case 2:
        // TODO: Circle area calculation
        // Console.WriteLine("Circle Area Calculator");
        // Console.WriteLine("=====================");
        // Console.WriteLine("Enter radius:");
        // double radius = double.Parse(Console.ReadLine());
        // double circleArea = Math.PI * radius * radius;
        // Console.WriteLine($"Area of circle: {circleArea:F2}");
        break;
        
    case 3:
        // TODO: Temperature conversion
        // Console.WriteLine("Temperature Converter (C to F)");
        // Console.WriteLine("==============================");
        // Console.WriteLine("Enter temperature in Celsius:");
        // double celsius = double.Parse(Console.ReadLine());
        // double fahrenheit = (celsius * 9/5) + 32;
        // Console.WriteLine($"{celsius}°C = {fahrenheit}°F");
        break;
        
    case 4:
        // TODO: Exit message
        // Console.WriteLine("Thank you for using the calculator!");
        break;
        
    default:
        // TODO: Invalid choice message
        // Console.WriteLine("Invalid choice! Please select 1, 2, 3, or 4.");
        break;
}