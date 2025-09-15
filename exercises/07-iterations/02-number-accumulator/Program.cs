// Exercise 07-02: Number Accumulator
// Create a program that accumulates numbers using while loops

using System;

Console.WriteLine("Number Accumulator");
Console.WriteLine("=================");
Console.WriteLine("");
Console.WriteLine("Enter numbers one at a time (type 'done' to finish):");
Console.WriteLine("");

// TODO: Initialize variables to track statistics
int count = 0;
double sum = 0;
double highest = double.MinValue;
double lowest = double.MaxValue;
bool continueInput = true;

// TODO: Use while loop to continuously get input
while (continueInput)
{
    Console.WriteLine("Enter a number:");
    string input = Console.ReadLine();
    
    // TODO: Check if user wants to stop
    // if (input.ToLower() == "done")
    // {
    //     continueInput = false;
    // }
    // else if (double.TryParse(input, out double number))
    // {
    //     // TODO: Update statistics
    //     count++;
    //     sum += number;
    //     
    //     if (count == 1) // First number
    //     {
    //         highest = number;
    //         lowest = number;
    //     }
    //     else
    //     {
    //         if (number > highest) highest = number;
    //         if (number < lowest) lowest = number;
    //     }
    //     
    //     // TODO: Display running statistics
    //     double average = sum / count;
    //     Console.WriteLine($"Numbers entered: {count}, Sum: {sum}, Average: {average:F1}, Highest: {highest}, Lowest: {lowest}");
    // }
    // else
    // {
    //     Console.WriteLine("Invalid input! Please enter a number or 'done'.");
    // }
    
    Console.WriteLine("");
}

// TODO: Display final statistics
// if (count > 0)
// {
//     Console.WriteLine("Final Statistics:");
//     Console.WriteLine("================");
//     Console.WriteLine($"Total numbers entered: {count}");
//     Console.WriteLine($"Sum: {sum}");
//     Console.WriteLine($"Average: {sum / count:F1}");
//     Console.WriteLine($"Highest number: {highest}");
//     Console.WriteLine($"Lowest number: {lowest}");
// }
// else
// {
//     Console.WriteLine("No numbers were entered.");
// }

Console.WriteLine("");
Console.WriteLine("Thank you for using the Number Accumulator!");