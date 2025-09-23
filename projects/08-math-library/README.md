# Math Library Project

## Overview
This project demonstrates function concepts by creating a comprehensive math library. Students will create various mathematical functions and learn about parameters, return values, method overloading, and code organization.

## Learning Objectives
- Practice creating methods with different parameter types
- Understand return values and void methods
- Learn method overloading
- Practice input validation in functions
- Organize code using static methods
- Work with different data types in functions

## Requirements
Create a program that:

1. **Displays a welcome message** and shows a menu of mathematical operations

2. **Offers the following mathematical functions**:
   - 1. Basic Operations (Add, Subtract, Multiply, Divide)
   - 2. Power and Root Operations
   - 3. Geometry Calculations (Area, Perimeter)
   - 4. Number Analysis (Prime, Perfect, Factorial)
   - 5. Statistics (Average, Min, Max)
   - 6. Number Conversions (Binary, Hex)
   - 7. Exit

3. **Implements each category with multiple functions**:
   - **Basic Operations**: Support for 2 or more numbers
   - **Power/Root**: Power, square root, nth root
   - **Geometry**: Circle, rectangle, triangle calculations
   - **Number Analysis**: Check if prime, perfect, calculate factorial
   - **Statistics**: Calculate from a series of numbers
   - **Conversions**: Convert between number systems

4. **Validates all inputs** and handles edge cases

5. **Uses proper function design**:
   - Clear parameter names
   - Appropriate return types
   - Input validation within functions
   - Method overloading where appropriate

## Sample Output
```
=== Math Library ===

Available Operations:
1. Basic Operations (Add, Subtract, Multiply, Divide)
2. Power and Root Operations
3. Geometry Calculations
4. Number Analysis
5. Statistics
6. Number Conversions
7. Exit

Choose an operation (1-7): 1

Basic Operations:
a) Add two numbers
b) Add multiple numbers
c) Subtract
d) Multiply
e) Divide

Choose operation (a-e): a

Enter first number: 15.5
Enter second number: 24.3
Result: 15.5 + 24.3 = 39.8

Choose an operation (1-7): 3

Geometry Calculations:
a) Circle area
b) Circle circumference
c) Rectangle area
d) Rectangle perimeter
e) Triangle area

Choose calculation (a-e): a

Enter radius: 5
Circle area: 78.54

Choose an operation (1-7): 7

Thank you for using Math Library!
```

## Function Examples

### Basic Operations
```csharp
static double Add(double a, double b)
static double Add(double[] numbers)  // Method overloading
static double Subtract(double a, double b)
static double Multiply(double a, double b)
static double Divide(double a, double b)
```

### Geometry Functions
```csharp
static double CircleArea(double radius)
static double CircleCircumference(double radius)
static double RectangleArea(double length, double width)
static double TriangleArea(double baseLength, double height)
```

### Number Analysis
```csharp
static bool IsPrime(int number)
static bool IsPerfect(int number)
static long Factorial(int number)
```

## Tips
- Use `static` methods so they can be called from `Main` without creating objects
- Consider using `Math.PI` for circle calculations
- Use appropriate data types (`int` for counting, `double` for measurements)
- Validate inputs (no negative values for areas, no division by zero)
- Use method overloading for functions that can work with different parameter counts
- Consider using `params` keyword for variable number of parameters

## Challenge Extensions
- Add trigonometric functions (sin, cos, tan)
- Implement matrix operations
- Add financial calculations (compound interest, loan payments)
- Create a function history feature
- Add unit conversion functions
- Implement complex number operations