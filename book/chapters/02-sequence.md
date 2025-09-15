# Chapter 02: Sequence

## Learning Objectives

By the end of this chapter, you will be able to:

- Understand how programs execute statements in sequence (order)
- Write simple expressions using numbers and text
- Use basic arithmetic operations in C#
- Combine multiple operations in a single statement
- Predict the output of sequential programs

## Introduction

In the previous chapter, you learned to write simple programs with `Console.WriteLine()`. Now we'll explore how computers execute programs step by step and learn to work with numbers and basic calculations.

## Program Execution Order

Computers are very literal - they follow instructions exactly in the order you write them. This concept is called **sequence**.

### Sequential Execution

Consider this program:

```csharp
using System;

Console.WriteLine("First line");
Console.WriteLine("Second line");
Console.WriteLine("Third line");
```

The computer will execute these statements in order:
1. Display "First line"
2. Display "Second line"  
3. Display "Third line"

The output will always be:
```
First line
Second line
Third line
```

### Why Order Matters

The order of statements is crucial. If you change the order, you change the program's behavior:

```csharp
using System;

Console.WriteLine("Third line");
Console.WriteLine("First line");
Console.WriteLine("Second line");
```

Now the output becomes:
```
Third line
First line
Second line
```

## Working with Numbers

C# can work with numbers directly, not just text. You can perform calculations and display the results.

### Basic Number Operations

```csharp
using System;

Console.WriteLine(5 + 3);        // Addition: displays 8
Console.WriteLine(10 - 4);       // Subtraction: displays 6
Console.WriteLine(6 * 7);        // Multiplication: displays 42
Console.WriteLine(15 / 3);       // Division: displays 5
```

### Combining Text and Numbers

You can combine text and numbers in the same output:

```csharp
using System;

Console.WriteLine("The answer is: " + (5 + 3));
Console.WriteLine("10 minus 4 equals " + (10 - 4));
```

Output:
```
The answer is: 8
10 minus 4 equals 6
```

Notice the parentheses around `(5 + 3)` - they ensure the calculation happens before combining with text.

## Expressions

An **expression** is any piece of code that produces a value. Here are examples:

### Simple Expressions
```csharp
5                    // Number expression: value is 5
"Hello"              // Text expression: value is "Hello"
3 + 4                // Arithmetic expression: value is 7
"Age: " + 25         // Combined expression: value is "Age: 25"
```

### Complex Expressions
```csharp
using System;

Console.WriteLine(2 + 3 * 4);           // Displays 14 (not 20!)
Console.WriteLine((2 + 3) * 4);         // Displays 20
Console.WriteLine(100 / 4 / 5);         // Displays 5
Console.WriteLine("Result: " + (10 + 5)); // Displays "Result: 15"
```

### Order of Operations

C# follows mathematical order of operations (PEMDAS):
1. **Parentheses** first: `()`
2. **Multiplication and Division** left to right: `*` `/`
3. **Addition and Subtraction** left to right: `+` `-`

Examples:
```csharp
2 + 3 * 4     // = 2 + 12 = 14
(2 + 3) * 4   // = 5 * 4 = 20
10 / 2 + 3    // = 5 + 3 = 8
10 / (2 + 3)  // = 10 / 5 = 2
```

## Building Complex Programs

You can combine multiple statements to create more interesting programs. You'll practice this in the exercises where you'll build a complete calculator program that demonstrates sequential execution and arithmetic operations.

> **🏋️ Practice Now**: Complete [Exercise 02-01: Simple Calculator](../../exercises/02-sequence/01-simple-calculator/) to build a program that performs multiple calculations in sequence.

## Common Mistakes

### Forgetting Parentheses
```csharp
// Wrong - unclear order
Console.WriteLine("Answer: " + 5 + 3);  // Displays "Answer: 53"

// Correct - clear calculation
Console.WriteLine("Answer: " + (5 + 3)); // Displays "Answer: 8"
```

### Mixing Up Order of Operations
```csharp
// This might not do what you expect
Console.WriteLine(2 + 3 * 4);  // Displays 14, not 20

// Use parentheses to be clear
Console.WriteLine((2 + 3) * 4); // Displays 20
```

### Forgetting Quotes for Text
```csharp
// Wrong - C# thinks Hello is a variable name
Console.WriteLine(Hello);

// Correct - quotes make it text
Console.WriteLine("Hello");
```

## Hands-On Practice

Now it's time to apply what you've learned with practical exercises:

### Exercise Progression

1. **[Exercise 02-01: Simple Calculator](../../exercises/02-sequence/01-simple-calculator/)** - Practice arithmetic operations and sequential execution
2. **[Exercise 02-02: Order of Operations](../../exercises/02-sequence/02-order-of-operations/)** - Master mathematical precedence and parentheses usage

These exercises will help you understand how sequence and arithmetic operations work together to create useful programs.

> **💡 Learning Tip**: Try to predict the output of each calculation before running the program. This helps develop your understanding of how C# processes expressions.

## Real-World Applications

Sequential programming is everywhere:
- **Recipes**: Follow steps in order to cook
- **Assembly instructions**: Build furniture step by step
- **Morning routine**: Get dressed, eat breakfast, brush teeth
- **ATM transactions**: Insert card, enter PIN, select amount, take money

## Summary

In this chapter, you learned:

- Programs execute statements in **sequence** (top to bottom)
- The order of statements determines program behavior
- C# can perform arithmetic operations: `+`, `-`, `*`, `/`
- **Expressions** are code that produces values
- Order of operations follows mathematical rules (PEMDAS)
- Parentheses control the order of calculations
- You can combine text and numbers in output

## Next Steps

In the next chapter, we'll learn about **variables** - a way to store and reuse values in your programs. This will make your programs much more powerful and flexible.

## Key Terms

- **Sequence**: The order in which program statements execute
- **Expression**: Code that produces a value
- **Arithmetic Operations**: Mathematical calculations (`+`, `-`, `*`, `/`)
- **Order of Operations**: Rules determining calculation order (PEMDAS)
- **Parentheses**: Symbols `()` used to group operations and control order