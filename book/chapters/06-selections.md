# Chapter 06: Selections

## Learning Objectives

By the end of this chapter, you will be able to:

- Use `if` statements to make decisions in your programs
- Combine conditions with `else if` and `else` statements
- Write complex conditions using logical operators
- Use `switch` statements for multiple-choice decisions
- Understand when to use `if` vs `switch` statements
- Create programs that respond differently based on user input and conditions

## Introduction

So far, your programs have executed statements in order from top to bottom. But real programs need to make decisions - to do different things based on different conditions. This chapter teaches you how to make your programs "think" and choose different paths.

## The if Statement

The `if` statement lets your program make decisions based on conditions:

### Basic if Statement

```csharp
using System;

int age = 17;

if (age >= 18)
{
    Console.WriteLine("You are an adult.");
}

Console.WriteLine("Program continues...");
```

If the condition `age >= 18` is true, the code inside the braces runs. If it's false, the code is skipped.

### if with User Input

```csharp
using System;

Console.WriteLine("Enter your age:");
int age = int.Parse(Console.ReadLine());

if (age >= 18)
{
    Console.WriteLine("You can vote!");
}
```

## The if-else Statement

Use `else` to specify what happens when the condition is false:

```csharp
using System;

Console.WriteLine("Enter your age:");
int age = int.Parse(Console.ReadLine());

if (age >= 18)
{
    Console.WriteLine("You are an adult.");
}
else
{
    Console.WriteLine("You are a minor.");
}
```

## Multiple Conditions with else if

Use `else if` to check multiple conditions:

```csharp
using System;

Console.WriteLine("Enter your score (0-100):");
int score = int.Parse(Console.ReadLine());

if (score >= 90)
{
    Console.WriteLine("Grade: A");
}
else if (score >= 80)
{
    Console.WriteLine("Grade: B");
}
else if (score >= 70)
{
    Console.WriteLine("Grade: C");
}
else if (score >= 60)
{
    Console.WriteLine("Grade: D");
}
else
{
    Console.WriteLine("Grade: F");
}
```

The conditions are checked in order. Once one is true, the rest are skipped.

## Complex Conditions

### Using Logical Operators

```csharp
using System;

Console.WriteLine("Enter your age:");
int age = int.Parse(Console.ReadLine());

Console.WriteLine("Do you have a driver's license? (yes/no):");
string hasLicense = Console.ReadLine().ToLower();

if (age >= 16 && hasLicense == "yes")
{
    Console.WriteLine("You can drive!");
}
else if (age >= 16 && hasLicense == "no")
{
    Console.WriteLine("You're old enough, but you need a license.");
}
else
{
    Console.WriteLine("You're too young to drive.");
}
```

### Multiple Conditions with OR

```csharp
using System;

Console.WriteLine("Enter the day of the week:");
string day = Console.ReadLine().ToLower();

if (day == "saturday" || day == "sunday")
{
    Console.WriteLine("It's the weekend!");
}
else
{
    Console.WriteLine("It's a weekday.");
}
```

## Nested if Statements

You can put `if` statements inside other `if` statements:

```csharp
using System;

Console.WriteLine("Enter the temperature:");
double temp = double.Parse(Console.ReadLine());

Console.WriteLine("Is it raining? (yes/no):");
string raining = Console.ReadLine().ToLower();

if (temp > 20)
{
    if (raining == "yes")
    {
        Console.WriteLine("Warm but rainy - bring an umbrella!");
    }
    else
    {
        Console.WriteLine("Perfect weather for going outside!");
    }
}
else
{
    if (raining == "yes")
    {
        Console.WriteLine("Cold and rainy - stay inside!");
    }
    else
    {
        Console.WriteLine("Cold but dry - dress warmly!");
    }
}
```

## The switch Statement

When you have many possible values to check, `switch` can be cleaner than multiple `else if` statements:

### Basic switch Statement

```csharp
using System;

Console.WriteLine("Enter a number (1-7) for day of week:");
int dayNumber = int.Parse(Console.ReadLine());

switch (dayNumber)
{
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
    case 3:
        Console.WriteLine("Wednesday");
        break;
    case 4:
        Console.WriteLine("Thursday");
        break;
    case 5:
        Console.WriteLine("Friday");
        break;
    case 6:
        Console.WriteLine("Saturday");
        break;
    case 7:
        Console.WriteLine("Sunday");
        break;
    default:
        Console.WriteLine("Invalid day number!");
        break;
}
```

### switch with Strings

```csharp
using System;

Console.WriteLine("Enter your favorite color:");
string color = Console.ReadLine().ToLower();

switch (color)
{
    case "red":
        Console.WriteLine("Red is bold and energetic!");
        break;
    case "blue":
        Console.WriteLine("Blue is calm and peaceful!");
        break;
    case "green":
        Console.WriteLine("Green is natural and fresh!");
        break;
    case "yellow":
        Console.WriteLine("Yellow is bright and cheerful!");
        break;
    default:
        Console.WriteLine("That's an interesting color choice!");
        break;
}
```

### Multiple Cases with Same Action

```csharp
using System;

Console.WriteLine("Enter a month (1-12):");
int month = int.Parse(Console.ReadLine());

switch (month)
{
    case 12:
    case 1:
    case 2:
        Console.WriteLine("Winter");
        break;
    case 3:
    case 4:
    case 5:
        Console.WriteLine("Spring");
        break;
    case 6:
    case 7:
    case 8:
        Console.WriteLine("Summer");
        break;
    case 9:
    case 10:
    case 11:
        Console.WriteLine("Fall");
        break;
    default:
        Console.WriteLine("Invalid month!");
        break;
}
```

## Hands-On Practice

Now it's time to apply what you've learned about conditional logic and decision-making:

### Exercise Progression

1. **[Exercise 06-01: Grade Classifier](../../exercises/06-selections/01-grade-classifier/)** - Practice using `if/else if/else` statements to classify test scores into letter grades
2. **[Exercise 06-02: Menu System](../../exercises/06-selections/02-menu-system/)** - Master `switch` statements by building an interactive menu-driven calculator

These exercises will help you understand when to use `if` statements versus `switch` statements and how to build interactive programs that respond to user choices.

> **💡 Learning Tip**: Use `if/else if` for ranges of values (like grade ranges) and `switch` for specific discrete values (like menu choices).
    category = "Invalid";
    description = "Age cannot be negative!";
}
else if (age <= 2)
{
    category = "Baby";
    description = "Learning to walk and talk";
}
else if (age <= 12)
{
    category = "Child";
    description = "Elementary school age";
}
else if (age <= 19)
{
    category = "Teenager";
    description = "High school age";
}
else if (age <= 64)
{
    category = "Adult";
    description = "Working age";
}
else
{
    category = "Senior";
    description = "Retirement age";
}

Console.WriteLine($"Category: {category}");
Console.WriteLine($"Description: {description}");
```

### Password Strength Checker

```csharp
using System;

Console.WriteLine("Enter a password:");
string password = Console.ReadLine();

int length = password.Length;
bool hasUpper = false;
bool hasLower = false;
bool hasDigit = false;

// Check for different character types
foreach (char c in password)
{
    if (char.IsUpper(c)) hasUpper = true;
    if (char.IsLower(c)) hasLower = true;
    if (char.IsDigit(c)) hasDigit = true;
}

// Determine strength
string strength;
if (length < 6)
{
    strength = "Weak - too short";
}
else if (length >= 6 && length < 10)
{
    if (hasUpper && hasLower && hasDigit)
    {
        strength = "Medium - good mix of characters";
    }
    else
    {
        strength = "Weak - needs uppercase, lowercase, and numbers";
    }
}
else // length >= 10
{
    if (hasUpper && hasLower && hasDigit)
    {
        strength = "Strong - long with good character mix";
    }
    else
    {
        strength = "Medium - long but needs character variety";
    }
}

Console.WriteLine($"Password strength: {strength}");
```

## When to Use if vs switch

### Use if when:
- You have complex conditions with logical operators
- You're comparing ranges of values
- You have different types of conditions

```csharp
// Good use of if
if (age >= 18 && hasLicense && eyesightGood)
{
    Console.WriteLine("Can drive");
}
```

### Use switch when:
- You're comparing one variable against many specific values
- You have many discrete options
- The code is cleaner and more readable

```csharp
// Good use of switch
switch (menuChoice)
{
    case 1: /* do something */ break;
    case 2: /* do something else */ break;
    // ... many more cases
}
```

## Common Mistakes

### Missing break in switch

```csharp
// Wrong - missing break statements
switch (choice)
{
    case 1:
        Console.WriteLine("Option 1");
        // Missing break - will fall through to case 2!
    case 2:
        Console.WriteLine("Option 2");
        break;
}

// Correct
switch (choice)
{
    case 1:
        Console.WriteLine("Option 1");
        break;  // Don't forget this!
    case 2:
        Console.WriteLine("Option 2");
        break;
}
```

### Using = instead of ==

```csharp
// Wrong - assignment instead of comparison
if (age = 18)  // This assigns 18 to age!

// Correct
if (age == 18)  // This compares age to 18
```

### Unreachable code

```csharp
// Wrong - the second condition will never be checked
if (score >= 80)
{
    Console.WriteLine("Good score");
}
else if (score >= 90)  // This will never execute!
{
    Console.WriteLine("Excellent score");
}

// Correct - check higher values first
if (score >= 90)
{
    Console.WriteLine("Excellent score");
}
else if (score >= 80)
{
    Console.WriteLine("Good score");
}
```

## Summary

In this chapter, you learned:

- **`if` statements** make decisions based on conditions
- **`else`** specifies what happens when conditions are false
- **`else if`** allows checking multiple conditions in sequence
- **Logical operators** (`&&`, `||`, `!`) combine conditions
- **`switch` statements** handle multiple discrete values cleanly
- **Nested conditions** allow complex decision-making
- **When to use `if` vs `switch`** for different scenarios

## Next Steps

In the next chapter, we'll learn about **iterations** - using loops to repeat actions multiple times, which is essential for processing data and creating interactive programs.

## Key Terms

- **Selection**: Choosing different paths based on conditions
- **Condition**: An expression that evaluates to true or false
- **`if` statement**: Executes code only if a condition is true
- **`else` statement**: Executes code when the if condition is false
- **`else if`**: Checks additional conditions in sequence
- **`switch` statement**: Compares one value against multiple possibilities
- **`case`**: A specific value to match in a switch statement
- **`default`**: The fallback case in a switch statement
- **Nested conditions**: if statements inside other if statements