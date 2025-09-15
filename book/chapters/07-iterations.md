# Chapter 07: Iterations

## Learning Objectives

By the end of this chapter, you will be able to:

- Use `for` loops to repeat actions a specific number of times
- Use `while` loops to repeat actions based on conditions
- Use `foreach` loops to process collections of data
- Control loop execution with `break` and `continue` statements
- Understand when to use different types of loops
- Create programs that process data efficiently using loops

## Introduction

So far, your programs execute each statement once. But what if you need to repeat an action multiple times? Loops let you repeat code efficiently without writing the same statements over and over.

## The for Loop

The `for` loop is perfect when you know how many times you want to repeat something.

### Basic for Loop

```csharp
using System;

for (int i = 1; i <= 5; i++)
{
    Console.WriteLine($"Count: {i}");
}
```

Output:
```
Count: 1
Count: 2
Count: 3
Count: 4
Count: 5
```

### for Loop Structure

```csharp
for (initialization; condition; increment)
{
    // Code to repeat
}
```

- **Initialization**: Runs once at the start (`int i = 1`)
- **Condition**: Checked before each iteration (`i <= 5`)
- **Increment**: Runs after each iteration (`i++`)

### Counting Examples

```csharp
using System;

// Count from 1 to 10
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}

// Count backwards from 10 to 1
for (int i = 10; i >= 1; i--)
{
    Console.WriteLine(i);
}

// Count by 2s
for (int i = 0; i <= 20; i += 2)
{
    Console.WriteLine(i);  // 0, 2, 4, 6, 8, 10, 12, 14, 16, 18, 20
}
```

### Practical for Loop Examples

```csharp
using System;

// Calculate sum of numbers 1 to 100
int sum = 0;
for (int i = 1; i <= 100; i++)
{
    sum += i;
}
Console.WriteLine($"Sum of 1 to 100: {sum}");

// Display multiplication table
int number = 7;
Console.WriteLine($"Multiplication table for {number}:");
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{number} x {i} = {number * i}");
}
```

## The while Loop

The `while` loop repeats as long as a condition is true. Use it when you don't know exactly how many times to repeat.

### Basic while Loop

```csharp
using System;

int count = 1;
while (count <= 5)
{
    Console.WriteLine($"Count: {count}");
    count++;  // Don't forget to update the condition!
}
```

### Input Validation with while

```csharp
using System;

int age = 0;
while (age < 1 || age > 120)
{
    Console.WriteLine("Enter your age (1-120):");
    if (int.TryParse(Console.ReadLine(), out age))
    {
        if (age < 1 || age > 120)
        {
            Console.WriteLine("Invalid age. Please try again.");
        }
    }
    else
    {
        Console.WriteLine("Please enter a valid number.");
        age = 0; // Reset to continue loop
    }
}
Console.WriteLine($"Your age is: {age}");
```

### Menu Loop Example

```csharp
using System;

string choice = "";
while (choice != "quit")
{
    Console.WriteLine("\nMenu:");
    Console.WriteLine("1. Say hello");
    Console.WriteLine("2. Show time");
    Console.WriteLine("Type 'quit' to exit");
    Console.WriteLine("Enter choice:");
    
    choice = Console.ReadLine().ToLower();
    
    if (choice == "1")
    {
        Console.WriteLine("Hello there!");
    }
    else if (choice == "2")
    {
        Console.WriteLine($"Current time: {DateTime.Now}");
    }
    else if (choice != "quit")
    {
        Console.WriteLine("Invalid choice!");
    }
}
Console.WriteLine("Goodbye!");
```

## The do-while Loop

The `do-while` loop runs at least once, then checks the condition.

```csharp
using System;

int number;
do
{
    Console.WriteLine("Enter a positive number:");
    int.TryParse(Console.ReadLine(), out number);
    
    if (number <= 0)
    {
        Console.WriteLine("That's not positive. Try again!");
    }
} while (number <= 0);

Console.WriteLine($"You entered: {number}");
```

## The foreach Loop

The `foreach` loop processes each item in a collection (like an array or list).

### foreach with Arrays

```csharp
using System;

string[] names = {"Alice", "Bob", "Charlie", "Diana"};

foreach (string name in names)
{
    Console.WriteLine($"Hello, {name}!");
}
```

### foreach with Lists

```csharp
using System;
using System.Collections.Generic;

List<int> scores = new List<int> {85, 92, 78, 96, 88};

int total = 0;
foreach (int score in scores)
{
    total += score;
    Console.WriteLine($"Score: {score}");
}

double average = (double)total / scores.Count;
Console.WriteLine($"Average score: {average:F1}");
```

## Loop Control Statements

### break Statement

The `break` statement exits the loop immediately:

```csharp
using System;

// Find first number divisible by 7
for (int i = 1; i <= 100; i++)
{
    if (i % 7 == 0)
    {
        Console.WriteLine($"First number divisible by 7: {i}");
        break;  // Exit the loop
    }
}
```

### continue Statement

The `continue` statement skips the rest of the current iteration:

```csharp
using System;

// Print odd numbers from 1 to 10
for (int i = 1; i <= 10; i++)
{
    if (i % 2 == 0)
    {
        continue;  // Skip even numbers
    }
    Console.WriteLine(i);  // Only prints odd numbers
}
```

## Nested Loops

You can put loops inside other loops:

### Multiplication Table

```csharp
using System;

Console.WriteLine("Multiplication Table (1-5):");
Console.WriteLine("   1  2  3  4  5");

for (int row = 1; row <= 5; row++)
{
    Console.Write($"{row}| ");
    for (int col = 1; col <= 5; col++)
    {
        Console.Write($"{row * col,2} ");
    }
    Console.WriteLine();
}
```

### Pattern Printing

```csharp
using System;

// Print a triangle pattern
for (int row = 1; row <= 5; row++)
{
    for (int col = 1; col <= row; col++)
    {
        Console.Write("* ");
    }
    Console.WriteLine();
}
```

Output:
```
* 
* * 
* * * 
* * * * 
* * * * * 
```

## Hands-On Practice

Now it's time to apply what you've learned about loops and iteration:

### Exercise Progression

1. **[Exercise 07-01: Multiplication Table](../../exercises/07-iterations/01-multiplication-table/)** - Practice `for` loops and `while` loops by building an interactive multiplication table generator
2. **[Exercise 07-02: Number Accumulator](../../exercises/07-iterations/02-number-accumulator/)** - Master advanced loop patterns by creating a program that processes multiple numbers and calculates statistics

### Major Project Integration

After completing these exercises, you'll be ready for **[Project 1: Number Guessing Game](../../projects/01-number-guessing-game/)** - a complete interactive game that combines all the concepts you've learned so far: variables, user input, conditional logic, and loops.

> **💡 Learning Tip**: Loops are powerful but can be tricky. Start with simple `for` loops for counting, then move to `while` loops for more complex conditions. The exercises will guide you through both patterns.
    {
        total += grade;
        if (grade > highest) highest = grade;
        if (grade < lowest) lowest = grade;
    }
    
    double average = (double)total / grades.Count;
    
    Console.WriteLine($"\nGrade Statistics:");
    Console.WriteLine($"Number of grades: {grades.Count}");
    Console.WriteLine($"Average: {average:F1}");
    Console.WriteLine($"Highest: {highest}");
    Console.WriteLine($"Lowest: {lowest}");
}
else
{
    Console.WriteLine("No grades entered.");
}
```

## When to Use Each Loop Type

### Use for when:
- You know the exact number of iterations
- You need a counter variable
- You're working with arrays or ranges

```csharp
// Good use of for loop
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i]);
}
```

### Use while when:
- The number of iterations depends on a condition
- You're validating input
- You're reading data until a condition is met

```csharp
// Good use of while loop
while (!validInput)
{
    // Keep asking until valid input
}
```

### Use foreach when:
- You need to process every item in a collection
- You don't need the index
- You want clean, readable code

```csharp
// Good use of foreach loop
foreach (string name in nameList)
{
    Console.WriteLine(name);
}
```

## Common Mistakes

### Infinite Loops

```csharp
// Wrong - infinite loop (i never changes)
int i = 1;
while (i <= 5)
{
    Console.WriteLine(i);
    // Missing: i++;
}

// Correct
int i = 1;
while (i <= 5)
{
    Console.WriteLine(i);
    i++;  // Don't forget to update the condition!
}
```

### Off-by-One Errors

```csharp
// Wrong - misses the last element
for (int i = 0; i < array.Length - 1; i++)  // Should be: i < array.Length

// Wrong - goes beyond array bounds
for (int i = 1; i <= array.Length; i++)     // Should start at 0
```

### Modifying Collections During foreach

```csharp
// Wrong - can't modify collection during foreach
foreach (int number in numbers)
{
    if (number < 0)
    {
        numbers.Remove(number);  // Error!
    }
}

// Correct - use for loop when modifying
for (int i = numbers.Count - 1; i >= 0; i--)
{
    if (numbers[i] < 0)
    {
        numbers.RemoveAt(i);
    }
}
```

## Summary

In this chapter, you learned:

- **`for` loops** repeat a specific number of times with a counter
- **`while` loops** repeat based on conditions
- **`do-while` loops** run at least once before checking conditions
- **`foreach` loops** process collections efficiently
- **`break`** exits loops early
- **`continue`** skips to the next iteration
- **Nested loops** allow complex patterns and data processing
- **When to use each loop type** for different scenarios

## Next Steps

In the next chapter, we'll combine everything you've learned to create a complete project that uses input/output, selections, and iterations together.

## Key Terms

- **Loop**: A structure that repeats code multiple times
- **Iteration**: One execution of the loop body
- **`for` loop**: Repeats a specific number of times
- **`while` loop**: Repeats based on a condition
- **`foreach` loop**: Processes each item in a collection
- **`break`**: Exits a loop immediately
- **`continue`**: Skips to the next iteration
- **Infinite loop**: A loop that never ends (usually a bug)
- **Nested loop**: A loop inside another loop