// Exercise 07-01: Multiplication Table - Reference Solution
// Create a program that generates multiplication tables using for loops

using System;

Console.WriteLine("Multiplication Table Generator");
Console.WriteLine("=============================");
Console.WriteLine("");

string continueProgram = "yes";

// Use a while loop to allow multiple tables
while (continueProgram.ToLower() == "yes")
{
    Console.WriteLine("Which multiplication table would you like to see (1-12)?");
    int tableNumber = int.Parse(Console.ReadLine());
    
    // Validate input
    if (tableNumber < 1 || tableNumber > 12)
    {
        Console.WriteLine("Please enter a number between 1 and 12.");
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
    continueProgram = Console.ReadLine();
}

Console.WriteLine("Thank you for using the Multiplication Table Generator!");