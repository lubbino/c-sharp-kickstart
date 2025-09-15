# Chapter 08: Functions

## Learning Objectives

By the end of this chapter, you will be able to:

- Understand what functions (methods) are and why they are useful
- Create your own methods with parameters and return values
- Call methods and use their return values
- Understand method signatures and overloading
- Organize code using methods to improve readability and reusability
- Debug programs that use multiple methods

## Introduction

As your programs become more complex, you'll find yourself writing similar code multiple times. Functions (called **methods** in C#) let you group code into reusable blocks that you can call whenever needed. This makes your programs cleaner, easier to understand, and easier to maintain.

## What Are Methods?

A method is a named block of code that performs a specific task. You've already been using methods like `Console.WriteLine()` and `int.Parse()`.

Think of methods like recipes:
- A recipe has a name ("Chocolate Chip Cookies")
- It might need ingredients (parameters)
- It produces something (return value)
- You can use the same recipe multiple times

## Creating Your First Method

### Basic Method Structure

```csharp
using System;

static void SayHello()
{
    Console.WriteLine("Hello from my method!");
}

static void Main(string[] args)
{
    SayHello();  // Call the method
    SayHello();  // Call it again
}
```

Output:
```
Hello from my method!
Hello from my method!
```

### Method Components

```csharp
static void SayHello()
//  ^    ^      ^
//  |    |      |
//  |    |      +-- Method name
//  |    +--------- Return type (void = returns nothing)
//  +-------------- Access modifier (static for now)
{
    // Method body - the code that runs
    Console.WriteLine("Hello!");
}
```

## Methods with Parameters

Parameters let you pass information into methods:

### Single Parameter

```csharp
using System;

static void SayHelloTo(string name)
{
    Console.WriteLine($"Hello, {name}!");
}

static void Main(string[] args)
{
    SayHelloTo("Alice");
    SayHelloTo("Bob");
    SayHelloTo("Charlie");
}
```

Output:
```
Hello, Alice!
Hello, Bob!
Hello, Charlie!
```

### Multiple Parameters

```csharp
using System;

static void DisplayPersonInfo(string name, int age, string city)
{
    Console.WriteLine($"Name: {name}");
    Console.WriteLine($"Age: {age}");
    Console.WriteLine($"City: {city}");
    Console.WriteLine();
}

static void Main(string[] args)
{
    DisplayPersonInfo("Emma", 17, "Stockholm");
    DisplayPersonInfo("Lars", 16, "Gothenburg");
}
```

## Methods with Return Values

Methods can calculate something and return the result:

### Returning Values

```csharp
using System;

static int AddNumbers(int a, int b)
{
    int sum = a + b;
    return sum;  // Send the result back
}

static void Main(string[] args)
{
    int result = AddNumbers(5, 3);
    Console.WriteLine($"5 + 3 = {result}");
    
    // You can use the result directly
    Console.WriteLine($"10 + 7 = {AddNumbers(10, 7)}");
}
```

### Different Return Types

```csharp
using System;

static double CalculateArea(double length, double width)
{
    return length * width;
}

static string GetGrade(int score)
{
    if (score >= 90) return "A";
    else if (score >= 80) return "B";
    else if (score >= 70) return "C";
    else if (score >= 60) return "D";
    else return "F";
}

static bool IsEven(int number)
{
    return number % 2 == 0;
}

static void Main(string[] args)
{
    double area = CalculateArea(5.5, 3.2);
    string grade = GetGrade(85);
    bool evenCheck = IsEven(42);
    
    Console.WriteLine($"Area: {area}");
    Console.WriteLine($"Grade: {grade}");
    Console.WriteLine($"Is 42 even? {evenCheck}");
}
```

## Practical Examples

### Calculator Methods

```csharp
using System;

static double Add(double a, double b)
{
    return a + b;
}

static double Subtract(double a, double b)
{
    return a - b;
}

static double Multiply(double a, double b)
{
    return a * b;
}

static double Divide(double a, double b)
{
    if (b != 0)
        return a / b;
    else
    {
        Console.WriteLine("Error: Division by zero!");
        return 0;
    }
}

static void Main(string[] args)
{
    Console.WriteLine("Simple Calculator");
    Console.WriteLine("================");
    
    Console.WriteLine("Enter first number:");
    double num1 = double.Parse(Console.ReadLine());
    
    Console.WriteLine("Enter second number:");
    double num2 = double.Parse(Console.ReadLine());
    
    Console.WriteLine("Choose operation (+, -, *, /):");
    string operation = Console.ReadLine();
    
    double result = 0;
    
    switch (operation)
    {
        case "+":
            result = Add(num1, num2);
            break;
        case "-":
            result = Subtract(num1, num2);
            break;
        case "*":
            result = Multiply(num1, num2);
            break;
        case "/":
            result = Divide(num1, num2);
            break;
        default:
            Console.WriteLine("Invalid operation!");
            return;
    }
    
    Console.WriteLine($"{num1} {operation} {num2} = {result}");
}
```

### Input Validation Methods

```csharp
using System;

static int GetValidInteger(string prompt, int min, int max)
{
    int value;
    bool valid = false;
    
    do
    {
        Console.WriteLine(prompt);
        string input = Console.ReadLine();
        
        if (int.TryParse(input, out value))
        {
            if (value >= min && value <= max)
            {
                valid = true;
            }
            else
            {
                Console.WriteLine($"Please enter a number between {min} and {max}.");
            }
        }
        else
        {
            Console.WriteLine("Please enter a valid number.");
        }
    } while (!valid);
    
    return value;
}

static string GetValidString(string prompt)
{
    string input;
    do
    {
        Console.WriteLine(prompt);
        input = Console.ReadLine();
        
        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Please enter some text.");
        }
    } while (string.IsNullOrWhiteSpace(input));
    
    return input;
}

static void Main(string[] args)
{
    string name = GetValidString("Enter your name:");
    int age = GetValidInteger("Enter your age (1-120):", 1, 120);
    int score = GetValidInteger("Enter your test score (0-100):", 0, 100);
    
    Console.WriteLine($"Hello {name}, age {age}, score {score}!");
}
```

## Hands-On Practice

Now it's time to apply what you've learned about methods and functions:

### Exercise Progression

1. **[Exercise 08-01: Calculator Methods](../../exercises/08-functions/01-calculator-methods/)** - Refactor a calculator program to use separate methods for each operation, demonstrating how methods improve code organization
2. **[Exercise 08-02: Utility Methods](../../exercises/08-functions/02-utility-methods/)** - Create a collection of reusable utility methods for common programming tasks

These exercises will help you understand how to organize code with methods and create reusable functions that make your programs more maintainable.

> **💡 Learning Tip**: Start by identifying repeated code patterns in your programs - these are perfect candidates for methods. Good methods do one thing well and have descriptive names.

## Method Overloading

You can create multiple methods with the same name but different parameters:

```csharp
using System;

static int Add(int a, int b)
{
    return a + b;
}

static double Add(double a, double b)
{
    return a + b;
}

static string Add(string a, string b)
{
    return a + b;
}

static void Main(string[] args)
{
    Console.WriteLine(Add(5, 3));           // Uses int version: 8
    Console.WriteLine(Add(5.5, 3.2));       // Uses double version: 8.7
    Console.WriteLine(Add("Hello", "World")); // Uses string version: HelloWorld
}
```

## Variable Scope

Variables declared inside methods are only available within that method:

```csharp
using System;

static void MethodA()
{
    int localVariable = 10;
    Console.WriteLine($"In MethodA: {localVariable}");
}

static void MethodB()
{
    // Console.WriteLine(localVariable);  // Error! localVariable doesn't exist here
    int localVariable = 20;  // This is a different variable
    Console.WriteLine($"In MethodB: {localVariable}");
}

static void Main(string[] args)
{
    MethodA();
    MethodB();
    // Console.WriteLine(localVariable);  // Error! localVariable doesn't exist here either
}
```

## Best Practices

### Method Naming

```csharp
// Good method names - describe what they do
static double CalculateCircleArea(double radius)
static bool IsValidEmail(string email)
static string FormatPhoneNumber(string phone)

// Poor method names - unclear purpose
static double DoStuff(double x)
static bool Check(string s)
static string Fix(string p)
```

### Single Responsibility

Each method should do one thing well:

```csharp
// Good - each method has one clear purpose
static double GetRadius()
{
    Console.WriteLine("Enter radius:");
    return double.Parse(Console.ReadLine());
}

static double CalculateCircleArea(double radius)
{
    return Math.PI * radius * radius;
}

static void DisplayResult(double area)
{
    Console.WriteLine($"Circle area: {area:F2}");
}

// Poor - method does too many things
static void DoEverything()
{
    Console.WriteLine("Enter radius:");
    double radius = double.Parse(Console.ReadLine());
    double area = Math.PI * radius * radius;
    Console.WriteLine($"Circle area: {area:F2}");
}
```

### Method Size

Keep methods short and focused:

```csharp
// Good - short and focused
static bool IsValidAge(int age)
{
    return age >= 0 && age <= 120;
}

// Good - breaks complex logic into steps
static string DetermineAgeCategory(int age)
{
    if (age < 13) return "Child";
    if (age < 20) return "Teenager";
    if (age < 65) return "Adult";
    return "Senior";
}
```

## Common Mistakes

### Forgetting to Return a Value

```csharp
// Wrong - method says it returns int but doesn't
static int AddNumbers(int a, int b)
{
    int sum = a + b;
    // Missing: return sum;
}

// Correct
static int AddNumbers(int a, int b)
{
    int sum = a + b;
    return sum;
}
```

### Wrong Parameter Types

```csharp
// Wrong - calling with wrong types
static int AddIntegers(int a, int b)
{
    return a + b;
}

// AddIntegers("5", "3");  // Error! Strings, not integers

// Correct
AddIntegers(5, 3);  // Integers
```

### Forgetting static Keyword

```csharp
// Wrong - missing static (for now)
void MyMethod()  // Error when called from Main
{
    Console.WriteLine("Hello");
}

// Correct
static void MyMethod()
{
    Console.WriteLine("Hello");
}
```

## Refactoring with Methods

Take existing code and improve it by extracting methods:

### Before (repetitive code)

```csharp
using System;

static void Main(string[] args)
{
    // Calculate rectangle area
    Console.WriteLine("Enter rectangle length:");
    double length = double.Parse(Console.ReadLine());
    Console.WriteLine("Enter rectangle width:");
    double width = double.Parse(Console.ReadLine());
    double rectArea = length * width;
    Console.WriteLine($"Rectangle area: {rectArea}");
    
    // Calculate circle area
    Console.WriteLine("Enter circle radius:");
    double radius = double.Parse(Console.ReadLine());
    double circleArea = Math.PI * radius * radius;
    Console.WriteLine($"Circle area: {circleArea:F2}");
}
```

### After (using methods)

```csharp
using System;

static double GetPositiveNumber(string prompt)
{
    double number;
    do
    {
        Console.WriteLine(prompt);
    } while (!double.TryParse(Console.ReadLine(), out number) || number <= 0);
    return number;
}

static double CalculateRectangleArea(double length, double width)
{
    return length * width;
}

static double CalculateCircleArea(double radius)
{
    return Math.PI * radius * radius;
}

static void DisplayArea(string shape, double area)
{
    Console.WriteLine($"{shape} area: {area:F2}");
}

static void Main(string[] args)
{
    // Calculate rectangle area
    double length = GetPositiveNumber("Enter rectangle length:");
    double width = GetPositiveNumber("Enter rectangle width:");
    double rectArea = CalculateRectangleArea(length, width);
    DisplayArea("Rectangle", rectArea);
    
    // Calculate circle area
    double radius = GetPositiveNumber("Enter circle radius:");
    double circleArea = CalculateCircleArea(radius);
    DisplayArea("Circle", circleArea);
}
```

## Advanced Method Concepts

### Methods Calling Other Methods

```csharp
using System;

static double GetCircumference(double radius)
{
    return 2 * Math.PI * radius;
}

static double GetArea(double radius)
{
    return Math.PI * radius * radius;
}

static void DisplayCircleInfo(double radius)
{
    double circumference = GetCircumference(radius);
    double area = GetArea(radius);
    
    Console.WriteLine($"Circle with radius {radius}:");
    Console.WriteLine($"Circumference: {circumference:F2}");
    Console.WriteLine($"Area: {area:F2}");
}

static void Main(string[] args)
{
    DisplayCircleInfo(5.0);
}
```

### Methods with Complex Logic

```csharp
using System;

static string GetPasswordStrength(string password)
{
    int score = 0;
    
    if (password.Length >= 8) score++;
    if (password.Length >= 12) score++;
    
    bool hasUpper = false, hasLower = false, hasDigit = false;
    foreach (char c in password)
    {
        if (char.IsUpper(c)) hasUpper = true;
        if (char.IsLower(c)) hasLower = true;
        if (char.IsDigit(c)) hasDigit = true;
    }
    
    if (hasUpper) score++;
    if (hasLower) score++;
    if (hasDigit) score++;
    
    switch (score)
    {
        case 0:
        case 1:
        case 2:
            return "Weak";
        case 3:
        case 4:
            return "Medium";
        case 5:
            return "Strong";
        default:
            return "Very Strong";
    }
}

static void Main(string[] args)
{
    Console.WriteLine("Enter a password:");
    string password = Console.ReadLine();
    string strength = GetPasswordStrength(password);
    Console.WriteLine($"Password strength: {strength}");
}
```

## Organizing Programs with Methods

### Game Example with Methods

```csharp
using System;

static int GetRandomNumber(int min, int max)
{
    Random random = new Random();
    return random.Next(min, max + 1);
}

static int GetValidGuess(int min, int max)
{
    int guess;
    bool valid = false;
    
    do
    {
        Console.WriteLine($"Enter your guess ({min}-{max}):");
        string input = Console.ReadLine();
        
        if (int.TryParse(input, out guess))
        {
            if (guess >= min && guess <= max)
            {
                valid = true;
            }
            else
            {
                Console.WriteLine($"Please enter a number between {min} and {max}.");
            }
        }
        else
        {
            Console.WriteLine("Please enter a valid number.");
        }
    } while (!valid);
    
    return guess;
}

static string GetFeedback(int guess, int secret)
{
    if (guess < secret) return "Too low!";
    if (guess > secret) return "Too high!";
    return "Correct!";
}

static bool PlayAgain()
{
    Console.WriteLine("Would you like to play again? (yes/no):");
    string response = Console.ReadLine().ToLower();
    return response == "yes" || response == "y";
}

static void Main(string[] args)
{
    Console.WriteLine("Number Guessing Game");
    Console.WriteLine("===================");
    
    do
    {
        int secret = GetRandomNumber(1, 100);
        int attempts = 0;
        bool won = false;
        
        Console.WriteLine("I'm thinking of a number between 1 and 100...");
        
        while (!won)
        {
            attempts++;
            int guess = GetValidGuess(1, 100);
            string feedback = GetFeedback(guess, secret);
            
            Console.WriteLine(feedback);
            
            if (guess == secret)
            {
                won = true;
                Console.WriteLine($"You won in {attempts} attempts!");
            }
        }
    } while (PlayAgain());
    
    Console.WriteLine("Thanks for playing!");
}
```

## Summary

In this chapter, you learned:

- **Methods** group related code into reusable blocks
- **Parameters** let you pass information into methods
- **Return values** let methods send results back
- **Method signatures** define the method's name, parameters, and return type
- **Method overloading** allows multiple methods with the same name
- **Variable scope** determines where variables can be used
- **Refactoring** improves code by extracting methods
- **Organization** makes programs easier to understand and maintain

## Next Steps

In the next chapter, we'll learn about **arrays and lists** - ways to store and work with collections of related data, which work perfectly with the methods you've learned.

## Key Terms

- **Method**: A named block of code that performs a specific task
- **Parameter**: Input that a method receives
- **Return Value**: Output that a method sends back
- **Method Signature**: The method's name, parameters, and return type
- **Method Overloading**: Multiple methods with the same name but different parameters
- **Variable Scope**: Where in the program a variable can be used
- **Refactoring**: Improving code structure without changing functionality
- **`static`**: Keyword that allows methods to be called without creating objects