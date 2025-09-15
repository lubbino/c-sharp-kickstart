# Chapter 04: Operators

## Learning Objectives

By the end of this chapter, you will be able to:

- Use arithmetic operators for mathematical calculations
- Apply comparison operators to compare values
- Combine conditions using logical operators
- Understand operator precedence and use parentheses effectively
- Use assignment operators to modify variables
- Choose appropriate operators for different programming tasks

## Introduction

Operators are symbols that tell the computer to perform specific operations on values or variables. You've already used some operators like `+` for addition and `=` for assignment. In this chapter, we'll explore all the different types of operators available in C#.

## Arithmetic Operators

Arithmetic operators perform mathematical calculations.

### Basic Arithmetic

```csharp
int a = 10;
int b = 3;

int sum = a + b;        // Addition: 13
int difference = a - b; // Subtraction: 7
int product = a * b;    // Multiplication: 30
int quotient = a / b;   // Division: 3 (integer division)
int remainder = a % b;  // Modulus (remainder): 1
```

### Division with Different Types

```csharp
// Integer division (truncates decimal part)
int result1 = 10 / 3;        // Result: 3

// Decimal division
double result2 = 10.0 / 3.0; // Result: 3.333...
double result3 = (double)10 / 3; // Cast to get decimal result
```

### Modulus Operator

The modulus operator (`%`) returns the remainder after division:

```csharp
int remainder1 = 10 % 3;  // 10 ÷ 3 = 3 remainder 1
int remainder2 = 15 % 4;  // 15 ÷ 4 = 3 remainder 3
int remainder3 = 20 % 5;  // 20 ÷ 5 = 4 remainder 0
```

Common uses:
- Check if a number is even: `number % 2 == 0`
- Get the last digit: `number % 10`

## Comparison Operators

Comparison operators compare two values and return `true` or `false`.

```csharp
int x = 5;
int y = 3;

bool isEqual = x == y;        // Equal to: false
bool isNotEqual = x != y;     // Not equal to: true
bool isGreater = x > y;       // Greater than: true
bool isLess = x < y;          // Less than: false
bool isGreaterEqual = x >= y; // Greater than or equal: true
bool isLessEqual = x <= y;    // Less than or equal: false
```

### Comparing Different Types

```csharp
string name1 = "Alice";
string name2 = "Bob";
bool sameNames = name1 == name2;  // false

double price1 = 19.99;
double price2 = 20.00;
bool cheaperPrice = price1 < price2;  // true
```

## Logical Operators

Logical operators combine boolean values or expressions.

### AND Operator (`&&`)

Returns `true` only if both conditions are true:

```csharp
int age = 17;
bool hasLicense = true;

bool canDrive = age >= 16 && hasLicense;  // true
bool canVote = age >= 18 && hasLicense;   // false (age < 18)
```

### OR Operator (`||`)

Returns `true` if at least one condition is true:

```csharp
bool isWeekend = true;
bool isHoliday = false;

bool noSchool = isWeekend || isHoliday;  // true
```

### NOT Operator (`!`)

Reverses a boolean value:

```csharp
bool isRaining = false;
bool isSunny = !isRaining;  // true

bool isAdult = age >= 18;
bool isMinor = !isAdult;    // true (if age < 18)
```

### Complex Logical Expressions

```csharp
int score = 85;
bool passedExam = score >= 60;
bool gotA = score >= 90;
bool gotB = score >= 80 && score < 90;

bool satisfactory = passedExam && (gotA || gotB);
```

## Assignment Operators

Assignment operators assign values to variables.

### Basic Assignment

```csharp
int number = 10;        // Assign 10 to number
string name = "Alice";  // Assign "Alice" to name
```

### Compound Assignment

These operators combine arithmetic with assignment:

```csharp
int score = 100;

score += 10;    // Same as: score = score + 10;  (110)
score -= 5;     // Same as: score = score - 5;   (105)
score *= 2;     // Same as: score = score * 2;   (210)
score /= 3;     // Same as: score = score / 3;   (70)
score %= 7;     // Same as: score = score % 7;   (0)
```

### Increment and Decrement

```csharp
int counter = 5;

counter++;      // Increment by 1: counter becomes 6
counter--;      // Decrement by 1: counter becomes 5

// These are equivalent to:
counter += 1;   // or counter = counter + 1;
counter -= 1;   // or counter = counter - 1;
```

## Operator Precedence

When multiple operators appear in an expression, C# follows specific rules for the order of operations:

### Precedence Order (highest to lowest)

1. **Parentheses**: `()`
2. **Unary operators**: `!`, `-`, `++`, `--`
3. **Multiplication, Division, Modulus**: `*`, `/`, `%`
4. **Addition, Subtraction**: `+`, `-`
5. **Comparison**: `<`, `>`, `<=`, `>=`
6. **Equality**: `==`, `!=`
7. **Logical AND**: `&&`
8. **Logical OR**: `||`
9. **Assignment**: `=`, `+=`, `-=`, etc.

### Examples

```csharp
int result1 = 2 + 3 * 4;        // 14 (not 20)
int result2 = (2 + 3) * 4;      // 20

bool test1 = 5 > 3 && 2 < 4;    // true && true = true
bool test2 = 5 > 3 || 2 > 4;    // true || false = true
bool test3 = !(5 > 3);          // !true = false
```

## Hands-On Practice

Now it's time to apply what you've learned about operators in practical scenarios:

### Exercise Progression

1. **[Exercise 04-01: Grade Calculator](../../exercises/04-operators/01-grade-calculator/)** - Practice arithmetic and comparison operators to calculate and analyze student grades
2. **[Exercise 04-02: Number Analyzer](../../exercises/04-operators/02-number-analyzer/)** - Master logical operators and modulus operations to analyze number properties

These exercises will help you understand how different operators work together to solve real-world problems.

> **💡 Learning Tip**: Pay special attention to the modulus operator (`%`) - it's incredibly useful for checking divisibility and extracting digits from numbers.

## Common Mistakes

### Confusing Assignment and Equality

```csharp
// Wrong - assignment instead of comparison
if (age = 18)  // Error! This assigns 18 to age

// Correct - comparison
if (age == 18)  // This compares age to 18
```

### Integer Division

```csharp
// Wrong - unexpected result
double average = 5 / 2;  // Result: 2.0 (not 2.5)

// Correct - ensure decimal division
double average = 5.0 / 2.0;  // Result: 2.5
// or
double average = (double)5 / 2;  // Result: 2.5
```

### Logical Operator Confusion

```csharp
// Wrong - using & instead of &&
bool result = true & false;  // Works but not recommended

// Correct - use logical operators
bool result = true && false;  // Preferred for boolean logic
```

## Summary

In this chapter, you learned:

- **Arithmetic operators** (`+`, `-`, `*`, `/`, `%`) perform mathematical calculations
- **Comparison operators** (`==`, `!=`, `<`, `>`, `<=`, `>=`) compare values
- **Logical operators** (`&&`, `||`, `!`) combine boolean expressions
- **Assignment operators** (`=`, `+=`, `-=`, etc.) assign and modify variables
- **Operator precedence** determines the order of operations
- **Parentheses** can override default precedence

## Next Steps

In the next chapter, we'll learn about **input and output** - how to get information from users and display results in more interactive ways.

## Key Terms

- **Operator**: A symbol that performs an operation on values
- **Arithmetic Operators**: Mathematical operations (`+`, `-`, `*`, `/`, `%`)
- **Comparison Operators**: Compare values and return true/false
- **Logical Operators**: Combine boolean expressions (`&&`, `||`, `!`)
- **Assignment Operators**: Assign values to variables (`=`, `+=`, etc.)
- **Precedence**: The order in which operations are performed
- **Modulus**: The remainder after division (`%`)