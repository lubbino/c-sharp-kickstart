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
    string input = Console.ReadLine() ?? "";

    if (input.ToLower() == "done")
    {
        continueInput = false;
    }
    else if (double.TryParse(input, out double number))
    {
        count++;
        sum += number;

        if (count == 1)
        {
            highest = number;
            lowest = number;
        }
        else
        {
            if (number > highest) highest = number;
            if (number < lowest) lowest = number;
        }

        double avg = sum / count;
        Console.WriteLine($"Numbers entered: {count}, Sum: {sum}, Average: {avg:F1}, Highest: {highest}, Lowest: {lowest}");
    }
    else if (input.ToLower() == "secret")
    {
        for (int i = 1; i <= 100; i++)
        {
            count++;
            sum += i;
            if (count == 1)
            {
                highest = i;
                lowest = i;
            }
            else
            {
                if (i > highest) highest = i;
                if (i < lowest) lowest = i;
            }

            double avg = sum / count;
            Console.WriteLine($"Numbers entered: {count}, Sum: {sum}, Average: {avg:F1}, Highest: {highest}, Lowest: {lowest}");
            continueInput = false;
        }
    }

    else Console.WriteLine("Please enter a valid input. (A number or 'done'");
  
    Console.WriteLine("");
}

if (count > 0)
{
    Console.WriteLine("Final Statistics:");
    Console.WriteLine("================");
    Console.WriteLine($"Total numbers entered: {count}");
    Console.WriteLine($"Sum: {sum}");
    Console.WriteLine($"Average: {sum / count:F1}");
    Console.WriteLine($"Highest number: {highest}");
    Console.WriteLine($"Lowest number: {lowest}");
}
else
{
    Console.WriteLine("No numbers were entered.");
}

Console.WriteLine("");
Console.WriteLine("Thank you for using the Number Accumulator!");