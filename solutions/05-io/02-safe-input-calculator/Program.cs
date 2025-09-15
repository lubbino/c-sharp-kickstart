// Exercise 05-02: Safe Input Calculator - Reference Solution
// Create a calculator that safely handles invalid user input

using System;

Console.WriteLine("Safe Input Calculator");
Console.WriteLine("====================");
Console.WriteLine("");

// Get first number with basic validation
Console.WriteLine("Enter first number:");
string input1 = Console.ReadLine();
double firstNumber = double.Parse(input1);

// Get second number with basic validation
Console.WriteLine("Enter second number:");
string input2 = Console.ReadLine();
double secondNumber = double.Parse(input2);

// Get operation
Console.WriteLine("Enter operation (+, -, *, /):");
string operation = Console.ReadLine();

// Perform calculation
double result = 0;
bool validOperation = true;

if (operation == "+")
{
    result = firstNumber + secondNumber;
}
else if (operation == "-")
{
    result = firstNumber - secondNumber;
}
else if (operation == "*")
{
    result = firstNumber * secondNumber;
}
else if (operation == "/")
{
    if (secondNumber != 0)
    {
        result = firstNumber / secondNumber;
    }
    else
    {
        Console.WriteLine("Error: Cannot divide by zero!");
        validOperation = false;
    }
}
else
{
    Console.WriteLine("Error: Invalid operation!");
    validOperation = false;
}

// Display result
if (validOperation)
{
    Console.WriteLine($"Calculation: {firstNumber} {operation} {secondNumber} = {result:F2}");
}

Console.WriteLine("");
Console.WriteLine("Thank you for using the calculator!");