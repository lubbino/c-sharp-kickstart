# Exercise 07-01: Multiplication Table

## Background

This exercise helps you practice using for loops to repeat calculations and create formatted output tables.

## Instructions

Create a C# console application that generates and displays multiplication tables using for loops.

## Requirements

1. Ask the user which multiplication table they want to see (1-12)
2. Use a for loop to calculate and display the multiplication table
3. Format the output clearly with proper alignment
4. Ask if they want to see another table and repeat if desired
5. Use appropriate loop types for different parts of the program

## Expected Output

Your program should produce output similar to this:

```
Multiplication Table Generator
=============================

Which multiplication table would you like to see (1-12)? 7

Multiplication Table for 7:
===========================
7 x 1 = 7
7 x 2 = 14
7 x 3 = 21
7 x 4 = 28
7 x 5 = 35
7 x 6 = 42
7 x 7 = 49
7 x 8 = 56
7 x 9 = 63
7 x 10 = 70

Would you like to see another table? (yes/no): no

Thank you for using the Multiplication Table Generator!
```

## Hints

- Use a for loop: `for (int i = 1; i <= 10; i++)`
- Format output: `$"{number} x {i} = {number * i}"`
- Use a while loop for the "repeat" functionality
- Validate that the table number is between 1 and 12
- Use `ToLower()` to handle "Yes", "YES", "yes", etc.

## Getting Started

1. Create a new console application:
   ```bash
   dotnet new console -n MultiplicationTable
   cd MultiplicationTable
   ```

2. Open `Program.cs` in your editor

3. Implement the multiplication table generator

4. Run your program:
   ```bash
   dotnet run
   ```

## Testing Your Solution

Your program should:
- Compile without errors
- Use for loops to generate multiplication tables
- Display tables in a clear, formatted way
- Validate input for table numbers (1-12)
- Allow users to generate multiple tables
- Use appropriate loop control for the repeat functionality