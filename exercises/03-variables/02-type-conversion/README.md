# Exercise 03-02: Type Conversion

## Background

This exercise helps you practice converting between different data types and understanding when and how to use type conversion in C#.

## Instructions

Create a C# console application that demonstrates various type conversions and calculations with different data types.

## Requirements

1. Create variables with different data types and convert between them
2. Demonstrate converting strings to numbers using `Parse()` methods
3. Show explicit casting from larger to smaller numeric types
4. Convert numbers back to strings using `ToString()`
5. Perform calculations that require type conversion
6. Display the original values, converted values, and calculation results

## Expected Output

Your program should produce output similar to this:

```
Type Conversion Demonstration
============================

String to Number Conversion:
Age as text: "25"
Age as number: 25
Price as text: "19.99"
Price as number: 19.99

Number to String Conversion:
Score as number: 95
Score as text: "95"

Explicit Casting:
Original price: 29.99
Rounded price: 29

Mixed Type Calculations:
Items: 3
Price per item: $12.50
Total cost: $37.50
```

## Hints

- Use `int.Parse()` to convert string to int
- Use `double.Parse()` to convert string to double
- Use `ToString()` to convert numbers to strings
- Use `(int)` to cast double to int (explicit casting)
- When mixing int and decimal in calculations, the result will be decimal

## Getting Started

1. Create a new console application:
   ```bash
   dotnet new console -n TypeConversion
   cd TypeConversion
   ```

2. Open `Program.cs` in your editor

3. Create variables and demonstrate conversions

4. Run your program:
   ```bash
   dotnet run
   ```

## Testing Your Solution

Your program should:
- Compile without errors
- Demonstrate string to number conversion using Parse methods
- Show number to string conversion using ToString()
- Include explicit casting examples
- Perform calculations with mixed data types
- Display clear labels for each conversion type