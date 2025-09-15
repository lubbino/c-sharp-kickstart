# Exercise 02-01: Simple Calculator

## Background

This exercise helps you practice writing expressions with arithmetic operations and understanding how programs execute in sequence.

## Instructions

Create a C# console application that acts as a simple calculator, performing several calculations and displaying the results in order.

## Requirements

1. Display a welcome message for your calculator
2. Perform and display at least 4 different arithmetic operations
3. Use all four basic operations: addition (+), subtraction (-), multiplication (*), and division (/)
4. Show both the calculation and the result (e.g., "5 + 3 = 8")
5. Display a closing message

## Expected Output

Your program should produce output similar to this:

```
Welcome to my Simple Calculator!

5 + 3 = 8
10 - 4 = 6
6 * 7 = 42
20 / 4 = 5

Thank you for using my calculator!
```

## Hints

- Use `Console.WriteLine()` for each line of output
- Combine text and calculations like this: `"5 + 3 = " + (5 + 3)`
- Remember to use parentheses around calculations when combining with text
- The program will execute statements from top to bottom

## Getting Started

1. Create a new console application:
   ```bash
   dotnet new console -n SimpleCalculator
   cd SimpleCalculator
   ```

2. Open `Program.cs` in your editor

3. Write your calculator program

4. Run your program:
   ```bash
   dotnet run
   ```

## Testing Your Solution

Your program should:
- Compile without errors
- Display a welcome message
- Show at least 4 calculations with correct results
- Use all four arithmetic operations (+, -, *, /)
- Display calculations in the format "number operation number = result"
- Display a closing message