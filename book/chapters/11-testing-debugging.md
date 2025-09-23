# Chapter 11: Testing and Debugging

## Learning Objectives

By the end of this chapter, you will be able to:
- Understand the importance of testing in software development
- Write unit tests using the MSTest testing framework
- Apply the AAA (Arrange, Act, Assert) testing pattern
- Create parameterized tests for comprehensive coverage
- Use debugging tools and techniques effectively
- Identify and fix common programming errors
- Implement test-driven development practices
- Debug programs using Visual Studio debugger and other tools

## Introduction

Testing and debugging are essential skills for any programmer. Testing helps ensure your code works correctly and continues to work as you make changes. Debugging helps you find and fix problems when things go wrong.

Think of testing like quality control in manufacturing - you check that each part works correctly before assembling the final product. Debugging is like being a detective, gathering clues to solve the mystery of why something isn't working as expected.

## Core Concepts

### Why Testing Matters

**Benefits of Testing:**
- **Confidence**: Know your code works correctly
- **Regression Prevention**: Catch bugs when making changes
- **Documentation**: Tests show how code should be used
- **Design Improvement**: Writing tests often reveals design issues
- **Maintenance**: Easier to modify code with good test coverage

**Types of Testing:**
- **Unit Tests**: Test individual methods or classes
- **Integration Tests**: Test how components work together
- **System Tests**: Test the complete application
- **Manual Testing**: Human testing of the user interface

### Introduction to MSTest

MSTest is Microsoft's testing framework for .NET applications. It makes writing tests easy and readable:

```csharp
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class BasicArithmeticTests
{
    [TestMethod]
    public void TestBasicArithmetic()
    {
        Assert.AreEqual(4, 2 + 2);
        Assert.AreEqual(2, 5 - 3);
        Assert.AreEqual(12, 3 * 4);
        Assert.AreEqual(4, 8 / 2);
    }
}
```

**Key MSTest Attributes and Methods:**
- `[TestClass]`: Marks a class containing tests
- `[TestMethod]`: Marks a method as a test
- `Assert.AreEqual(expected, actual)`: Verifies two values are equal
- `Assert.IsTrue(condition)`: Verifies a condition is true
- `Assert.ThrowsException<T>()`: Verifies an exception is thrown

### The AAA Pattern

The AAA pattern provides a clear structure for writing tests:

**Arrange**: Set up the test data and conditions
**Act**: Execute the code being tested
**Assert**: Verify the results

```csharp
[TestMethod]
public void Calculator_Add_ReturnsCorrectSum()
{
    // Arrange
    var calculator = new Calculator();
    int a = 5;
    int b = 3;
    int expected = 8;
    
    // Act
    int result = calculator.Add(a, b);
    
    // Assert
    Assert.AreEqual(expected, result);
}
```

### Writing Effective Unit Tests

#### Testing a Simple Method

```csharp
// Method to test
public static int Factorial(int n)
{
    if (n <= 1) return 1;
    return n * Factorial(n - 1);
}

// Test class
[TestClass]
public class MathUtilsTests
{
    [TestMethod]
    public void Factorial_BaseCases_ReturnsOne()
    {
        Assert.AreEqual(1, MathUtils.Factorial(0));
        Assert.AreEqual(1, MathUtils.Factorial(1));
    }
    
    [TestMethod]
    public void Factorial_PositiveNumbers_ReturnsCorrectValue()
    {
        Assert.AreEqual(2, MathUtils.Factorial(2));
        Assert.AreEqual(6, MathUtils.Factorial(3));
        Assert.AreEqual(24, MathUtils.Factorial(4));
        Assert.AreEqual(120, MathUtils.Factorial(5));
    }
    
    [TestMethod]
    public void Factorial_NegativeNumber_ThrowsException()
    {
        Assert.ThrowsException<ArgumentException>(() => MathUtils.Factorial(-1));
    }
}
```

#### Testing with Floating Point Numbers

```csharp
public static double CalculateCircleArea(double radius)
{
    const double PI = Math.PI;
    return PI * radius * radius;
}

[TestClass]
public class GeometryTests
{
    [TestMethod]
    public void CalculateCircleArea_UnitCircle_ReturnsPI()
    {
        double result = Geometry.CalculateCircleArea(1.0);
        Assert.AreEqual(Math.PI, result, 0.001);
    }
    
    [TestMethod]
    public void CalculateCircleArea_RadiusTwo_ReturnsCorrectArea()
    {
        double result = Geometry.CalculateCircleArea(2.0);
        double expected = Math.PI * 4;
        Assert.AreEqual(expected, result, 0.001);
    }
}
```

#### Testing Classes

```csharp
public class BankAccount
{
    private double balance;
    
    public BankAccount(double initialBalance = 0.0)
    {
        balance = initialBalance;
    }
    
    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance += amount;
        }
    }
    
    public bool Withdraw(double amount)
    {
        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
            return true;
        }
        return false;
    }
    
    public double GetBalance() => balance;
}

[TestClass]
public class BankAccountTests
{
    [TestMethod]
    public void BankAccount_InitialBalance_SetsCorrectly()
    {
        var account = new BankAccount(100.0);
        Assert.AreEqual(100.0, account.GetBalance());
    }
    
    [TestMethod]
    public void Deposit_ValidAmount_IncreasesBalance()
    {
        var account = new BankAccount(50.0);
        account.Deposit(25.0);
        Assert.AreEqual(75.0, account.GetBalance());
    }
    
    [TestMethod]
    public void Withdraw_ValidAmount_DecreasesBalance()
    {
        var account = new BankAccount(100.0);
        bool success = account.Withdraw(30.0);
        
        Assert.IsTrue(success);
        Assert.AreEqual(70.0, account.GetBalance());
    }
    
    [TestMethod]
    public void Withdraw_InsufficientFunds_ReturnsFalse()
    {
        var account = new BankAccount(50.0);
        bool success = account.Withdraw(75.0);
        
        Assert.IsFalse(success);
        Assert.AreEqual(50.0, account.GetBalance()); // Balance unchanged
    }
    
    [TestMethod]
    public void InvalidOperations_IgnoredOrRejected()
    {
        var account = new BankAccount(100.0);
        
        account.Deposit(-10.0); // Should be ignored
        Assert.AreEqual(100.0, account.GetBalance());
        
        bool success = account.Withdraw(-5.0); // Should fail
        Assert.IsFalse(success);
        Assert.AreEqual(100.0, account.GetBalance());
    }
}
```

### Parameterized Tests

Test the same logic with multiple inputs using `DataTestMethod`:

```csharp
public static bool IsPrime(int n)
{
    if (n < 2) return false;
    for (int i = 2; i * i <= n; i++)
    {
        if (n % i == 0) return false;
    }
    return true;
}

[TestClass]
public class PrimeTests
{
    [DataTestMethod]
    [DataRow(2, true)]
    [DataRow(3, true)]
    [DataRow(5, true)]
    [DataRow(7, true)]
    [DataRow(11, true)]
    [DataRow(13, true)]
    public void IsPrime_KnownPrimes_ReturnsTrue(int number, bool expected)
    {
        bool result = MathUtils.IsPrime(number);
        Assert.AreEqual(expected, result);
    }
    
    [DataTestMethod]
    [DataRow(1, false)]
    [DataRow(4, false)]
    [DataRow(6, false)]
    [DataRow(8, false)]
    [DataRow(9, false)]
    [DataRow(10, false)]
    public void IsPrime_KnownNonPrimes_ReturnsFalse(int number, bool expected)
    {
        bool result = MathUtils.IsPrime(number);
        Assert.AreEqual(expected, result);
    }
}

// Testing with multiple parameters
[DataTestMethod]
[DataRow(12, 8, 4)]
[DataRow(15, 10, 5)]
[DataRow(17, 13, 1)]
[DataRow(100, 25, 25)]
[DataRow(48, 18, 6)]
public void GCD_VariousInputs_ReturnsCorrectResult(int a, int b, int expected)
{
    int result = MathUtils.GCD(a, b);
    Assert.AreEqual(expected, result);
}
```

### Testing Error Conditions

```csharp
public static double Divide(double a, double b)
{
    if (b == 0.0)
    {
        throw new DivideByZeroException("Division by zero is not allowed");
    }
    return a / b;
}

[TestClass]
public class DivisionTests
{
    [TestMethod]
    public void Divide_NormalDivision_ReturnsCorrectResult()
    {
        Assert.AreEqual(5.0, MathUtils.Divide(10.0, 2.0));
        Assert.AreEqual(3.5, MathUtils.Divide(7.0, 2.0), 0.001);
    }
    
    [TestMethod]
    public void Divide_ByZero_ThrowsException()
    {
        var exception = Assert.ThrowsException<DivideByZeroException>(
            () => MathUtils.Divide(5.0, 0.0));
        
        Assert.AreEqual("Division by zero is not allowed", exception.Message);
    }
}
```

### Test Organization and Best Practices

#### Organizing Tests

```csharp
[TestClass]
public class StringUtilsTests
{
    [TestMethod]
    public void Trim_RemovesWhitespace()
    {
        Assert.AreEqual("hello", StringUtils.Trim("  hello  "));
        Assert.AreEqual("world", StringUtils.Trim("world"));
        Assert.AreEqual("", StringUtils.Trim("   "));
    }
    
    [TestMethod]
    public void ToUpper_ConvertsToUppercase()
    {
        Assert.AreEqual("HELLO", StringUtils.ToUpper("hello"));
        Assert.AreEqual("WORLD", StringUtils.ToUpper("World"));
        Assert.AreEqual("123", StringUtils.ToUpper("123"));
    }
    
    [TestMethod]
    public void Contains_FindsSubstring()
    {
        Assert.IsTrue(StringUtils.Contains("hello world", "world"));
        Assert.IsFalse(StringUtils.Contains("hello world", "foo"));
    }
}
```

#### Test Naming Conventions

```csharp
// Good test names describe what is being tested
[TestMethod]
public void Calculator_Add_HandlesBasicArithmetic() { }

[TestMethod]
public void BankAccount_Withdraw_PreventsOverdraftWhenInsufficientFunds() { }

[TestMethod]
public void UserValidator_ValidateUsername_RejectsEmptyUsername() { }

[TestMethod]
public void FileReader_ReadFile_ThrowsExceptionWhenFileDoesNotExist() { }
```

#### Test Data Management

```csharp
// Use helper methods for complex test data
private static List<int> CreateSortedList()
{
    return new List<int> { 1, 3, 5, 7, 9, 11, 13 };
}

private static List<int> CreateUnsortedList()
{
    return new List<int> { 7, 2, 9, 1, 5, 3, 8 };
}

[TestClass]
public class SearchAlgorithmTests
{
    [TestMethod]
    public void BinarySearch_FindsElementInSortedArray()
    {
        var data = CreateSortedList();
        int result = SearchAlgorithms.BinarySearch(data, 7);
        Assert.AreEqual(3, result); // Index of 7
    }
    
    [TestMethod]
    public void BinarySearch_MissingElement_ReturnsMinusOne()
    {
        var data = CreateSortedList();
        int result = SearchAlgorithms.BinarySearch(data, 6);
        Assert.AreEqual(-1, result);
    }
}
```

## Debugging Techniques

### Understanding Common Errors

#### Compilation Errors

```csharp
// Syntax error
static void Main()
{
    int x = 5  // Missing semicolon
    Console.WriteLine(x);
}

// Type mismatch
static void PrintNumber(int n)
{
    Console.WriteLine(n);
}

static void Main()
{
    PrintNumber("hello"); // Wrong type
}
```

#### Runtime Errors

```csharp
// Array bounds error
int[] numbers = {1, 2, 3, 4, 5};
Console.WriteLine(numbers[10]); // IndexOutOfRangeException

// Null reference exception
string text = null;
Console.WriteLine(text.Length); // NullReferenceException

// Division by zero
int a = 10, b = 0;
int result = a / b; // DivideByZeroException
```

#### Logic Errors

```csharp
// Off-by-one error
for (int i = 0; i <= 10; i++) // Should be i < 10
{
    array[i] = i; // May go out of bounds
}

// Wrong condition
if (score = 100) // Assignment instead of comparison
{
    Console.WriteLine("Perfect score!");
}
```

### Debugging with Console Output

```csharp
static int Factorial(int n)
{
    Console.WriteLine($"Factorial called with n = {n}");
    
    if (n <= 1)
    {
        Console.WriteLine("Base case reached, returning 1");
        return 1;
    }
    
    int result = n * Factorial(n - 1);
    Console.WriteLine($"Factorial({n}) = {result}");
    return result;
}
```

### Using Visual Studio Debugger

#### Setting Breakpoints and Stepping Through Code

```csharp
static void Main()
{
    var numbers = new List<int> { 3, 7, 2, 9, 1 };
    
    // Set breakpoint here
    int maximum = FindMax(numbers);
    Console.WriteLine($"Maximum: {maximum}");
    
    // Test with empty list - potential bug
    var empty = new List<int>();
    int maxEmpty = FindMax(empty); // Set breakpoint here
    Console.WriteLine($"Max of empty: {maxEmpty}");
}

static int FindMax(List<int> numbers)
{
    // Potential bug: what if list is empty?
    int max = numbers[0]; // Set breakpoint here
    
    for (int i = 1; i < numbers.Count; i++)
    {
        if (numbers[i] > max)
        {
            max = numbers[i];
        }
    }
    
    return max;
}
```

**Debugging Process:**
1. Set breakpoints by clicking in the left margin
2. Start debugging with F5
3. Use F10 to step over, F11 to step into
4. Examine variables in the Watch window
5. Use the Call Stack to see method calls

### Defensive Programming

Write code that fails gracefully:

```csharp
static int FindMax(List<int> numbers)
{
    if (numbers == null)
    {
        throw new ArgumentNullException(nameof(numbers));
    }
    
    if (numbers.Count == 0)
    {
        throw new ArgumentException("Cannot find max of empty list", nameof(numbers));
    }
    
    int max = numbers[0];
    for (int i = 1; i < numbers.Count; i++)
    {
        if (numbers[i] > max)
        {
            max = numbers[i];
        }
    }
    
    return max;
}

// Alternative: return nullable value
static int? FindMaxSafe(List<int> numbers)
{
    if (numbers == null || numbers.Count == 0)
    {
        return null;
    }
    
    int max = numbers[0];
    for (int i = 1; i < numbers.Count; i++)
    {
        if (numbers[i] > max)
        {
            max = numbers[i];
        }
    }
    
    return max;
}
```

### Test-Driven Development (TDD)

TDD follows a simple cycle: Red → Green → Refactor

1. **Red**: Write a failing test
2. **Green**: Write minimal code to make it pass
3. **Refactor**: Improve the code while keeping tests passing

```csharp
// Step 1: Write failing test
[TestClass]
public class CalculatorTests
{
    [TestMethod]
    public void Calculator_Add_ReturnsSumOfTwoNumbers()
    {
        var calculator = new Calculator();
        int result = calculator.Add(2, 3);
        Assert.AreEqual(5, result);
    }
}

// Step 2: Write minimal implementation
public class Calculator
{
    public int Add(int a, int b)
    {
        return a + b; // Simplest implementation
    }
}

// Step 3: Add more tests and refactor as needed
[TestMethod]
public void Calculator_Add_HandlesEdgeCases()
{
    var calculator = new Calculator();
    
    Assert.AreEqual(5, calculator.Add(5, 0));
    Assert.AreEqual(5, calculator.Add(0, 5));
    Assert.AreEqual(1, calculator.Add(-2, 3));
    Assert.AreEqual(-5, calculator.Add(-2, -3));
}
```

## Common Debugging Scenarios

### Null Reference Issues

```csharp
// Common null reference problems
string text = GetUserInput(); // Might return null
int length = text.Length; // NullReferenceException if text is null

// Better: Check for null
string text = GetUserInput();
if (text != null)
{
    int length = text.Length;
}

// Or use null-conditional operator
int? length = text?.Length;
```

### Collection Issues

```csharp
// Index out of range
var list = new List<string> { "a", "b", "c" };
string item = list[5]; // IndexOutOfRangeException

// Better: Check bounds
if (index >= 0 && index < list.Count)
{
    string item = list[index];
}
```

### File and Resource Issues

```csharp
// Not checking file operations
var lines = File.ReadAllLines("data.txt"); // What if file doesn't exist?

// Better: Handle exceptions
try
{
    var lines = File.ReadAllLines("data.txt");
    ProcessLines(lines);
}
catch (FileNotFoundException)
{
    Console.WriteLine("Error: File 'data.txt' not found");
}
catch (UnauthorizedAccessException)
{
    Console.WriteLine("Error: Access denied to file 'data.txt'");
}
```

## Best Practices

### Testing Best Practices

1. **Write tests first** (or at least alongside code)
2. **Test one thing at a time** in each test method
3. **Use descriptive test names** that explain what's being tested
4. **Test edge cases** and error conditions
5. **Keep tests simple** and easy to understand
6. **Make tests independent** - they shouldn't depend on each other
7. **Use appropriate assertions** - choose the right Assert method

### Debugging Best Practices

1. **Reproduce the bug** consistently before trying to fix it
2. **Use version control** to track changes and revert if needed
3. **Add logging** to understand program flow
4. **Test your fixes** to ensure they work and don't break other things
5. **Learn your tools** - debugger, profiler, static analysis tools
6. **Read error messages carefully** - they often tell you exactly what's wrong

## Practice

Now that you understand testing and debugging, try the exercises to practice:

1. **Unit Testing** - Write comprehensive tests for existing methods
2. **Test-Driven Development** - Implement new features using TDD
3. **Debugging Challenge** - Find and fix bugs in provided code

Each exercise will help you develop the skills needed to write reliable, maintainable code.

## Summary

Testing and debugging are essential skills for creating reliable software:

**Testing helps you:**
- Verify code works correctly
- Catch regressions when making changes
- Document expected behavior
- Design better interfaces

**Debugging helps you:**
- Find and fix problems efficiently
- Understand how your code actually behaves
- Learn from mistakes
- Build more robust software

Key concepts to remember:
- Use the AAA pattern for clear test structure
- Test both normal cases and edge cases
- Write tests that are independent and repeatable
- Use debugging tools effectively
- Practice defensive programming
- Learn from every bug you encounter

Testing and debugging skills improve with practice. The more you test and debug, the better you become at writing code that works correctly the first time.

These skills will serve you throughout your programming career and are essential for professional software development.