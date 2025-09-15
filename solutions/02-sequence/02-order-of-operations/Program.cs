// Exercise 02-02: Order of Operations - Reference Solution
// Create a program that demonstrates how parentheses affect calculation order

using System;

Console.WriteLine("Order of Operations Demonstration");
Console.WriteLine("");

Console.WriteLine("Without parentheses:");
Console.WriteLine("2 + 3 * 4 = " + (2 + 3 * 4));           // = 14 (multiplication first)
Console.WriteLine("10 - 6 / 2 = " + (10 - 6 / 2));         // = 7 (division first)
Console.WriteLine("5 * 2 + 3 = " + (5 * 2 + 3));           // = 13 (multiplication first)

Console.WriteLine("");
Console.WriteLine("With parentheses:");
Console.WriteLine("(2 + 3) * 4 = " + ((2 + 3) * 4));       // = 20 (addition first)
Console.WriteLine("(10 - 6) / 2 = " + ((10 - 6) / 2));     // = 2 (subtraction first)
Console.WriteLine("5 * (2 + 3) = " + (5 * (2 + 3)));       // = 25 (addition first)

Console.WriteLine("");
Console.WriteLine("Complex expressions:");
Console.WriteLine("2 + 3 * 4 - 1 = " + (2 + 3 * 4 - 1));                 // = 13
Console.WriteLine("(2 + 3) * (4 - 1) = " + ((2 + 3) * (4 - 1)));         // = 15
Console.WriteLine("10 / 2 + 3 * 2 = " + (10 / 2 + 3 * 2));               // = 11
Console.WriteLine("(10 / 2 + 3) * 2 = " + ((10 / 2 + 3) * 2));           // = 16