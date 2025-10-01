// Exercise 07-01: Multiplication Table
// Create a program that generates multiplication tables using for loops

using System;

Console.WriteLine("Multiplication Table Generator");
Console.WriteLine("=============================");
Console.WriteLine("");

string continueProgram = "yes";

// Use a while loop to allow multiple tables
while (continueProgram.ToLower() == "yes")
{
    Console.WriteLine("Which multiplication table would you like to see (0-20)?");
    int tableNumber = int.Parse(Console.ReadLine() ?? "");

    // Validate input
    if (tableNumber < 0 || tableNumber > 20)
    {
        Console.WriteLine("Please enter a number between 0 and 20.");
        continue;
    }

    Console.WriteLine("");
    Console.WriteLine($"Multiplication Table for {tableNumber}:");
    Console.WriteLine("===========================");

    // Use a for loop to generate the table
    for (int i = 1; i <= 10; i++)
    {
        int result = tableNumber * i;
        Console.WriteLine($"{tableNumber} x {i} = {result}");
    }

    Console.WriteLine("");
    Console.WriteLine("Would you like to see another table? (yes/no):");
    continueProgram = Console.ReadLine() ?? "";
}

Console.WriteLine("Thank you for using the Multiplication Table Generator!");