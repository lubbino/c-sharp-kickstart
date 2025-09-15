# Exercise 08-01: Calculator Methods

## Background

This exercise helps you practice creating methods with parameters and return values by building a calculator with separate methods for each operation.

## Instructions

Create a C# console application that implements a calculator using separate methods for each mathematical operation.

## Requirements

1. Create methods for basic arithmetic operations: Add, Subtract, Multiply, Divide
2. Each method should take two parameters and return the result
3. Handle division by zero in the Divide method
4. Create a method to get valid numbers from the user
5. Create a method to display the result
6. Use these methods in your main program to build a complete calculator

## Method Signatures Required

```csharp
static double Add(double a, double b)
static double Subtract(double a, double b)
static double Multiply(double a, double b)
static double Divide(double a, double b)
static double GetValidNumber(string prompt)
static void DisplayResult(double num1, string operation, double num2, double result)
```

## Expected Output

Your program should produce output similar to this:

```
Method-Based Calculator
======================

Enter first number: 15.5
Enter second number: 3.2
Choose operation (+, -, *, /): *

Calculation: 15.5 * 3.2 = 49.60

Would you like to perform another calculation? (yes/no): yes

Enter first number: 10
Enter second number: 0
Choose operation (+, -, *, /): /

Error: Cannot divide by zero!

Would you like to perform another calculation? (yes/no): no

Thank you for using the calculator!
```

## Hints

- Each arithmetic method should be simple: `return a + b;`
- The Divide method should check if `b == 0` before dividing
- Use `double.TryParse()` in GetValidNumber for input validation
- Use a while loop to allow multiple calculations
- Call your methods from Main to perform the calculations

## Getting Started

1. Create a new console application:
   ```bash
   dotnet new console -n CalculatorMethods
   cd CalculatorMethods
   ```

2. Open `Program.cs` in your editor

3. Create all required methods first, then implement Main

4. Run your program:
   ```bash
   dotnet run
   ```

## Testing Your Solution

Your program should:
- Compile without errors
- Have separate methods for each arithmetic operation
- Use methods with appropriate parameters and return types
- Handle division by zero gracefully
- Validate user input using a dedicated method
- Allow multiple calculations in a loop
- Display results using a dedicated method