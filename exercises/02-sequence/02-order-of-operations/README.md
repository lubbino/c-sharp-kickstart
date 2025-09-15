# Exercise 02-02: Order of Operations

## Background

This exercise helps you practice understanding and applying the order of operations (PEMDAS) in C# expressions.

## Instructions

Create a C# console application that demonstrates the order of operations by showing calculations with and without parentheses.

## Requirements

1. Display a title explaining what the program demonstrates
2. Show at least 5 different expressions that demonstrate order of operations
3. For each expression, show both the calculation and the result
4. Include examples with and without parentheses to show the difference
5. Use a mix of addition, subtraction, multiplication, and division

## Expected Output

Your program should produce output similar to this:

```
Order of Operations Demonstration

Without parentheses:
2 + 3 * 4 = 14
10 - 6 / 2 = 7
5 * 2 + 3 = 13

With parentheses:
(2 + 3) * 4 = 20
10 - (6 / 2) = 7
(5 + 2) * 3 = 21

Complex expressions:
2 + 3 * 4 - 1 = 13
(2 + 3) * (4 - 1) = 15
```

## Hints

- Remember PEMDAS: Parentheses, Multiplication/Division (left to right), Addition/Subtraction (left to right)
- Use parentheses to group operations: `(2 + 3) * 4`
- Show expressions that give different results with and without parentheses
- Format output as: `"expression = " + (calculation)`

## Getting Started

1. Create a new console application:
   ```bash
   dotnet new console -n OrderOfOperations
   cd OrderOfOperations
   ```

2. Open `Program.cs` in your editor

3. Write your demonstration program

4. Run your program:
   ```bash
   dotnet run
   ```

## Testing Your Solution

Your program should:
- Compile without errors
- Display a clear title
- Show at least 5 different mathematical expressions
- Demonstrate the difference parentheses make
- Calculate all results correctly
- Use proper formatting for readability