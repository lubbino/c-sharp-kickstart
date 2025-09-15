# Chapter 03: Variables and Data Types

## Learning Objectives

By the end of this chapter, you will be able to:

- Understand what variables are and why they are useful
- Declare and initialize variables in C#
- Use the basic data types: `int`, `double`, `decimal`, `string`, and `bool`
- Choose appropriate data types for different kinds of information
- Understand type conversion and casting
- Follow C# naming conventions for variables

## Introduction

In previous chapters, you worked with fixed values like `5`, `"Hello"`, and `3.14`. But what if you want to store information that can change? That's where **variables** come in.

A variable is like a labeled box that can hold different values. You can put something in the box, look at what's inside, or replace it with something else.

## What Are Variables?

Think of variables as containers with names:

```csharp
int age = 17;           // A box labeled "age" containing the number 17
string name = "Anna";   // A box labeled "name" containing the text "Anna"
```

### Why Use Variables?

Variables make programs more flexible and powerful:

```csharp
// Without variables - fixed values
Console.WriteLine("Hello, Anna!");
Console.WriteLine("Anna is 17 years old.");

// With variables - flexible values
string name = "Anna";
int age = 17;
Console.WriteLine("Hello, " + name + "!");
Console.WriteLine(name + " is " + age + " years old.");
```

The second version is better because you can easily change the name and age by modifying the variables.

## Declaring Variables

To create a variable in C#, you need to specify:
1. **Data type** - what kind of information it holds
2. **Name** - what you want to call it
3. **Value** - what to put in it (optional)

### Basic Syntax

```csharp
dataType variableName = value;
```

Examples:
```csharp
int studentCount = 25;
string schoolName = "Riverside High";
double temperature = 23.5;
```

### Declaration vs. Initialization

You can declare a variable without giving it a value:

```csharp
int score;              // Declaration only
score = 95;             // Assignment later

// Or do both at once:
int score = 95;         // Declaration and initialization
```

## Data Types

C# has several built-in data types for different kinds of information.

### Integer Types

**`int`** - Whole numbers (no decimal places)

```csharp
int age = 17;
int temperature = -5;
int studentsInClass = 28;
int year = 2024;
```

Range: approximately -2 billion to +2 billion

### Decimal Number Types

**`double`** - Numbers with decimal places (general purpose)

```csharp
double height = 175.5;
double price = 29.99;
double pi = 3.14159;
```

**`decimal`** - Numbers with decimal places (for money/precise calculations)

```csharp
decimal accountBalance = 1250.75m;  // Note the 'm' suffix
decimal taxRate = 0.25m;
decimal productPrice = 15.99m;
```

Use `decimal` for money, `double` for general calculations.

### Text Type

**`string`** - Text and characters

```csharp
string firstName = "Emma";
string lastName = "Johnson";
string fullName = firstName + " " + lastName;
string message = "Welcome to programming!";
```

Strings must be enclosed in double quotes.

### Boolean Type

**`bool`** - True or false values

```csharp
bool isStudent = true;
bool hasLicense = false;
bool isWeekend = true;
```

Only two possible values: `true` or `false`.

## Working with Variables

### Using Variables in Calculations

```csharp
int length = 10;
int width = 5;
int area = length * width;  // area becomes 50

Console.WriteLine("Area: " + area);
```

### Changing Variable Values

```csharp
int score = 0;
Console.WriteLine("Initial score: " + score);  // Displays 0

score = 10;
Console.WriteLine("New score: " + score);      // Displays 10

score = score + 5;  // Add 5 to current value
Console.WriteLine("Final score: " + score);    // Displays 15
```

### Combining Variables

```csharp
string firstName = "Alex";
string lastName = "Smith";
string fullName = firstName + " " + lastName;

int birthYear = 2006;
int currentYear = 2024;
int age = currentYear - birthYear;

Console.WriteLine(fullName + " is " + age + " years old.");
```

## Type Conversion

Sometimes you need to convert between different data types.

### Automatic Conversion (Implicit)

C# automatically converts smaller types to larger types:

```csharp
int wholeNumber = 42;
double decimalNumber = wholeNumber;  // int → double (automatic)
Console.WriteLine(decimalNumber);    // Displays 42.0
```

### Manual Conversion (Explicit Casting)

To convert larger types to smaller types, you must cast explicitly:

```csharp
double price = 19.99;
int roundedPrice = (int)price;  // double → int (manual)
Console.WriteLine(roundedPrice); // Displays 19 (decimal part lost)
```

### Converting Strings to Numbers

```csharp
string ageText = "17";
int age = int.Parse(ageText);        // string → int
Console.WriteLine("Age: " + age);

string priceText = "29.99";
double price = double.Parse(priceText);  // string → double
Console.WriteLine("Price: " + price);
```

### Converting Numbers to Strings

```csharp
int score = 95;
string scoreText = score.ToString();  // int → string
Console.WriteLine("Your score is: " + scoreText);
```

## Naming Conventions

C# has specific rules and conventions for naming variables:

### Rules (Required)
- Must start with a letter or underscore
- Can contain letters, numbers, and underscores
- Cannot contain spaces or special characters
- Cannot be a C# keyword (like `int`, `string`, `if`)

### Conventions (Recommended)
- Use **camelCase** for variable names
- Start with a lowercase letter
- Use descriptive names
- Avoid abbreviations

```csharp
// Good variable names
int studentAge;
string firstName;
double accountBalance;
bool isLoggedIn;

// Poor variable names
int a;              // Not descriptive
string fName;       // Abbreviation
int student_age;    // Uses underscore (not camelCase)
double Price;       // Starts with capital letter
```

## Common Mistakes

### Wrong Data Type
```csharp
// Wrong - using int for decimal numbers
int price = 19.99;  // Error! int cannot hold decimals

// Correct
decimal price = 19.99m;
```

### Forgetting to Declare
```csharp
// Wrong - using variable without declaring
age = 17;  // Error! What type is age?

// Correct
int age = 17;
```

### Case Sensitivity
```csharp
int studentAge = 17;
Console.WriteLine(StudentAge);  // Error! C# is case-sensitive
```

### Using Keywords as Names
```csharp
// Wrong - 'string' is a keyword
int string = 5;  // Error!

// Correct
int length = 5;
```

## Hands-On Practice

Now it's time to apply what you've learned about variables and data types:

### Exercise Progression

1. **[Exercise 03-01: Personal Information](../../exercises/03-variables/01-personal-info/)** - Practice declaring variables with different data types and displaying personal information
2. **[Exercise 03-02: Type Conversion](../../exercises/03-variables/02-type-conversion/)** - Master converting between strings, integers, and decimal numbers

These exercises will help you understand how to choose appropriate data types and work with type conversion in real scenarios.

> **💡 Learning Tip**: Pay attention to when you use `int` vs `double` vs `decimal`. Each has specific use cases that will become clearer with practice.

## Summary

In this chapter, you learned:

- **Variables** are named containers that store values
- **Data types** specify what kind of information a variable can hold:
  - `int` for whole numbers
  - `double` for general decimal numbers
  - `decimal` for money and precise calculations
  - `string` for text
  - `bool` for true/false values
- **Type conversion** allows changing between data types
- **Naming conventions** make code readable and professional
- Variables make programs flexible and reusable

## Next Steps

In the next chapter, we'll explore **operators** - the symbols that let you perform calculations, comparisons, and logical operations with your variables.

## Key Terms

- **Variable**: A named container that stores a value
- **Data Type**: Specifies what kind of data a variable can hold
- **Declaration**: Creating a variable and specifying its type
- **Initialization**: Giving a variable its first value
- **Type Conversion**: Changing data from one type to another
- **Casting**: Explicitly converting between data types
- **camelCase**: Naming convention starting with lowercase letter