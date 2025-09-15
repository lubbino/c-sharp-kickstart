# Exercise 05-02: Safe Input Calculator

## Background

This exercise helps you practice input validation using `TryParse()` methods to handle invalid user input gracefully and create robust interactive programs.

## Instructions

Create a C# console application that performs calculations with user input while safely handling invalid input using proper validation techniques.

## Requirements

1. Create a simple calculator that asks for two numbers and an operation
2. Use `TryParse()` methods to safely convert user input to numbers
3. Validate that the operation is one of the allowed options (+, -, *, /)
4. Handle division by zero appropriately
5. Display helpful error messages for invalid input
6. Show the calculation and result clearly

## Expected Output

Your program should handle both valid and invalid input like this:

**Valid Input Example:**
```
Safe Input Calculator
====================

Enter first number: 15
Enter second number: 3
Enter operation (+, -, *, /): *

Calculation: 15 * 3 = 45
```

**Invalid Input Examples:**
```
Enter first number: abc
That's not a valid number! Please enter a number: 15

Enter second number: 
You didn't enter anything! Please enter a number: 3

Enter operation (+, -, *, /): %
Invalid operation! Please enter +, -, *, or /: *

Enter second number: 0
Enter operation (+, -, *, /): /
Error: Cannot divide by zero!
```

## Hints

- Use `double.TryParse(input, out double number)` to safely convert input
- Check if input is empty with `string.IsNullOrWhiteSpace(input)`
- Use a loop to keep asking until valid input is received
- For operations, check: `operation == "+" || operation == "-" || operation == "*" || operation == "/"`
- Special case: check for division by zero before calculating

## Getting Started

1. Create a new console application:
   ```bash
   dotnet new console -n SafeInputCalculator
   cd SafeInputCalculator
   ```

2. Open `Program.cs` in your editor

3. Implement input validation and calculation logic

4. Run your program:
   ```bash
   dotnet run
   ```

## Testing Your Solution

Your program should:
- Compile without errors
- Handle invalid number input gracefully using `TryParse()`
- Validate operation input and reject invalid operations
- Handle division by zero appropriately
- Display clear error messages and re-prompt for input
- Perform calculations correctly with valid input
- Use proper formatting for the final result