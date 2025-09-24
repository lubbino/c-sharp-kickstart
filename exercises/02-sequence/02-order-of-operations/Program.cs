// Exercise 02-02: Order of Operations
// Create a program that demonstrates how parentheses affect calculation order

using System;

Console.WriteLine("Order of Operations Demonstration");
Console.WriteLine("");

Console.WriteLine("Without parentheses:");
// TODO: Add expressions without parentheses
// Example: Console.WriteLine("2 + 3 * 4 = " + (2 + 3 * 4));
Console.WriteLine("2 + 3 * 4  = 14");
Console.WriteLine("10 - 6 / 2 = 7");
Console.WriteLine("5 * 2 + 3 = 13");

Console.WriteLine("");
Console.WriteLine("With parentheses:");
// TODO: Add the same expressions WITH parentheses to show the difference
// Example: Console.WriteLine("(2 + 3) * 4 = " + ((2 + 3) * 4));
Console.WriteLine("(2 + 3) * 4  = 20");
Console.WriteLine("(10 - 6) / 2 = 2");
Console.WriteLine("5 * (2 + 3) = 25");

Console.WriteLine("");
Console.WriteLine("Complex expressions:");
// TODO: Add more complex expressions to demonstrate order of operations
Console.WriteLine("2 + 3 * 4 - 1 = 13");
Console.WriteLine("(2 + 3) * (4 - 1) = 15");