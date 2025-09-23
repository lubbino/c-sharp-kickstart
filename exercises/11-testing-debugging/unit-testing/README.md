# Exercise 11-01: Unit Testing

## Background

Unit testing is the practice of testing individual methods or classes in isolation to ensure they work correctly. This exercise provides you with a collection of functions and classes that need comprehensive test coverage using the MSTest testing framework.

## Instructions

Your task is to write thorough unit tests for all the functions and classes provided in [`MathLibrary.cs`](MathLibrary.cs) and [`Calculator.cs`](Calculator.cs). You'll create test files that cover normal cases, edge cases, and error conditions.

## Functions and Classes to Test

The code includes several categories of functions that need testing:

### 1. String Utilities (StringUtils class)
- **`Trim()`**: Removes leading and trailing whitespace
- **`ToUpper()`**: Converts string to uppercase
- **`Contains()`**: Checks if string contains substring

### 2. Mathematical Operations (MathUtils class)
- **`CalculateDistance()`**: Calculates distance between two points
- **`IsPerfectSquare()`**: Checks if number is a perfect square
- **`Fibonacci()`**: Calculates Fibonacci number (throws on negative input)

### 3. Collection Operations (CollectionUtils class)
- **`RemoveDuplicates()`**: Returns list with duplicates removed
- **`FindSecondLargest()`**: Finds second largest element (throws on insufficient data)
- **`IsSorted()`**: Checks if list is sorted in ascending order

### 4. Calculator Class
- Basic arithmetic operations (`Add`, `Subtract`, `Multiply`, `Divide`)
- Memory operations (`StoreInMemory`, `RecallFromMemory`, `ClearMemory`)
- Power calculation (`Power`)
- Error handling (division by zero)

### 5. Grade Calculator Class
- **`GetLetterGrade()`**: Converts percentage to letter grade
- **`CalculateGPA()`**: Calculates GPA from letter grades
- **`IsPassingGrade()`**: Determines if grade is passing

## Testing Requirements

### Test Project Structure

Create test files with the following structure:

```csharp
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace UnitTesting.Tests
{
    [TestClass]
    public class StringUtilsTests
    {
        [TestMethod]
        public void Trim_RemovesLeadingAndTrailingWhitespace()
        {
            // Your tests here
        }
        
        [TestMethod]
        public void ToUpper_ConvertsToUppercase()
        {
            // Your tests here
        }
        
        [TestMethod]
        public void Contains_FindsSubstring()
        {
            // Your tests here
        }
    }
    
    // More test classes...
}
```

### Testing Guidelines

#### Use the AAA Pattern
Structure each test with:
- **Arrange**: Set up test data
- **Act**: Execute the method
- **Assert**: Verify the results

```csharp
[TestMethod]
public void Calculator_Add_ReturnsSumOfTwoNumbers()
{
    // Arrange
    var calculator = new Calculator();
    double a = 5.0;
    double b = 3.0;
    double expected = 8.0;
    
    // Act
    double result = calculator.Add(a, b);
    
    // Assert
    Assert.AreEqual(expected, result);
}
```

#### Test Categories

**Normal Cases**: Test typical usage scenarios
```csharp
[TestMethod]
public void Add_NormalNumbers_ReturnsCorrectSum()
{
    var calc = new Calculator();
    Assert.AreEqual(5, calc.Add(2, 3));
    Assert.AreEqual(1, calc.Add(-2, 3));
    Assert.AreEqual(5, calc.Add(0, 5));
}
```

**Edge Cases**: Test boundary conditions
```csharp
[TestMethod]
public void Trim_EdgeCases_HandlesCorrectly()
{
    Assert.AreEqual("", StringUtils.Trim(""));
    Assert.AreEqual("", StringUtils.Trim("   "));
    Assert.AreEqual("0", StringUtils.Trim("0"));
    Assert.AreEqual("1", StringUtils.Trim("1"));
}
```

**Error Conditions**: Test exception handling
```csharp
[TestMethod]
public void Divide_ByZero_ThrowsException()
{
    var calculator = new Calculator();
    Assert.ThrowsException<DivideByZeroException>(() => calculator.Divide(5, 0));
}
```

**Floating Point Comparisons**: Use delta for doubles
```csharp
[TestMethod]
public void CalculateDistance_ReturnsCorrectDistance()
{
    double result = MathUtils.CalculateDistance(0, 0, 3, 4);
    Assert.AreEqual(5.0, result, 0.001);
}
```

## Specific Test Requirements

### String Utilities Tests

**Trim() method:**
- Empty string
- String with only whitespace
- String with leading whitespace
- String with trailing whitespace
- String with both leading and trailing whitespace
- String with no whitespace
- String with internal whitespace (should be preserved)

**ToUpper() method:**
- Empty string
- All lowercase string
- All uppercase string
- Mixed case string
- String with numbers and symbols
- String with special characters

**Contains() method:**
- Substring found at beginning
- Substring found at end
- Substring found in middle
- Substring not found
- Empty substring (should return true)
- Empty text with non-empty substring
- Case sensitivity verification

### Mathematical Operations Tests

**CalculateDistance() method:**
- Same point (distance = 0)
- Unit distance (distance = 1)
- Pythagorean triple (3,4,5)
- Negative coordinates
- Large coordinates

**IsPerfectSquare() method:**
- Perfect squares: 0, 1, 4, 9, 16, 25, 100
- Non-perfect squares: 2, 3, 5, 8, 15
- Negative numbers (should return false)
- Large perfect squares

**Fibonacci() method:**
- Base cases: Fibonacci(0) = 0, Fibonacci(1) = 1
- Small values: Fibonacci(2) through Fibonacci(10)
- Negative input (should throw exception)

### Collection Operations Tests

**RemoveDuplicates() method:**
- List with no duplicates
- List with all duplicates
- Empty list
- List with some duplicates
- List with duplicates at different positions

**FindSecondLargest() method:**
- Normal case with distinct values
- List with duplicate largest values
- List with all same values (should throw)
- List with less than 2 elements (should throw)
- List with exactly 2 elements

**IsSorted() method:**
- Empty list (should return true)
- Single element list (should return true)
- Sorted list
- Reverse sorted list
- Partially sorted list
- List with duplicates

### Calculator Class Tests

**Basic Operations:**
- Addition: positive, negative, zero values
- Subtraction: positive, negative, zero values
- Multiplication: positive, negative, zero values
- Division: normal cases, division by zero (should throw)

**Memory Operations:**
- Store and recall values
- Clear memory
- Initial memory state (should be 0)
- Multiple store operations

**Power Function:**
- Positive exponents
- Zero exponent (should return 1)
- Negative exponents
- Base of zero
- Base of one

### Grade Calculator Tests

**GetLetterGrade() method:**
- Boundary values: 90, 80, 70, 60
- Values just above boundaries: 90.1, 80.1, 70.1, 60.1
- Values just below boundaries: 89.9, 79.9, 69.9, 59.9
- Perfect score: 100
- Failing score: 0
- Invalid percentages: negative, > 100 (should throw)

**CalculateGPA() method:**
- All A's (should be 4.0)
- All F's (should be 0.0)
- Mixed grades
- Empty grade list (should throw)
- Invalid grades (should throw)

**IsPassingGrade() method:**
- All valid grades: A, B, C, D, F
- Verify only F is failing

## Sample Test Implementation

```csharp
[TestClass]
public class StringUtilsTests
{
    [TestMethod]
    public void Trim_RemovesLeadingAndTrailingWhitespace()
    {
        Assert.AreEqual("hello", StringUtils.Trim("  hello  "));
        Assert.AreEqual("world", StringUtils.Trim("\t\nworld\r\n"));
        Assert.AreEqual("test", StringUtils.Trim("  test"));
        Assert.AreEqual("test", StringUtils.Trim("test  "));
    }
    
    [TestMethod]
    public void Trim_HandlesEmptyAndWhitespaceOnlyStrings()
    {
        Assert.AreEqual("", StringUtils.Trim(""));
        Assert.AreEqual("", StringUtils.Trim("   "));
        Assert.AreEqual("", StringUtils.Trim("\t\n\r"));
    }
    
    [TestMethod]
    public void Trim_PreservesStringsWithoutWhitespace()
    {
        Assert.AreEqual("hello", StringUtils.Trim("hello"));
        Assert.AreEqual("a", StringUtils.Trim("a"));
    }
    
    [TestMethod]
    public void Trim_PreservesInternalWhitespace()
    {
        Assert.AreEqual("hello world", StringUtils.Trim("  hello world  "));
        Assert.AreEqual("a b c", StringUtils.Trim("a b c"));
    }
}

[TestClass]
public class CalculatorTests
{
    [TestMethod]
    public void Divide_NormalDivision_ReturnsCorrectResult()
    {
        var calc = new Calculator();
        Assert.AreEqual(5.0, calc.Divide(10, 2));
        Assert.AreEqual(3.5, calc.Divide(7, 2), 0.001);
        Assert.AreEqual(-5.0, calc.Divide(-10, 2));
    }
    
    [TestMethod]
    public void Divide_ByZero_ThrowsException()
    {
        var calc = new Calculator();
        Assert.ThrowsException<DivideByZeroException>(() => calc.Divide(5, 0));
    }
}
```

## Project Setup

### Create Test Project

```bash
# From the exercises/11-testing-debugging/unit-testing directory
dotnet new mstest -n UnitTesting.Tests
cd UnitTesting.Tests

# Add reference to the main project
dotnet add reference ../UnitTesting.csproj
```

### Run Tests

```bash
# Run all tests
dotnet test

# Run tests with detailed output
dotnet test --logger "console;verbosity=detailed"

# Run specific test class
dotnet test --filter "TestCategory=StringUtils"
```

## Evaluation Criteria

Your tests will be evaluated on:

### Coverage (30%)
- **Completeness**: All methods and classes tested
- **Edge Cases**: Boundary conditions and special cases covered
- **Error Conditions**: Exception handling properly tested

### Quality (25%)
- **AAA Pattern**: Clear arrange, act, assert structure
- **Test Names**: Descriptive names that explain what's being tested
- **Assertions**: Appropriate use of Assert methods

### Organization (25%)
- **Logical Grouping**: Related tests grouped in classes
- **Test Independence**: Tests don't depend on each other
- **Clear Structure**: Easy to understand and maintain

### Correctness (20%)
- **Accurate Tests**: Tests correctly verify expected behavior
- **Proper Assertions**: Right assertions for the data types
- **Exception Testing**: Correct testing of error conditions

## Learning Goals

This exercise develops:
- **Testing Mindset**: Thinking about how code can fail
- **MSTest Proficiency**: Using the testing framework effectively
- **Edge Case Identification**: Finding boundary conditions and special cases
- **Test Organization**: Structuring tests for maintainability
- **Quality Assurance**: Understanding the role of testing in software quality

## Common Testing Patterns

### Testing Exceptions
```csharp
// Test that exception is thrown
Assert.ThrowsException<ArgumentException>(() => method());

// Test specific exception type and message
var ex = Assert.ThrowsException<ArgumentException>(() => method());
Assert.AreEqual("Expected message", ex.Message);
```

### Testing Collections
```csharp
// Compare entire lists
var expected = new List<int> { 1, 2, 3 };
var actual = SomeMethod();
CollectionAssert.AreEqual(expected, actual);

// Check list properties
Assert.AreEqual(3, result.Count);
Assert.IsFalse(result.Any(x => x < 0));
```

### Parameterized Tests
```csharp
[DataTestMethod]
[DataRow(2, true)]
[DataRow(3, true)]
[DataRow(4, false)]
[DataRow(5, true)]
public void IsPrime_VariousInputs_ReturnsExpectedResult(int number, bool expected)
{
    bool result = MathUtils.IsPrime(number);
    Assert.AreEqual(expected, result);
}
```

## Next Steps

After completing this exercise:
1. Run your tests and ensure they all pass
2. Try breaking the implementation to see if your tests catch the bugs
3. Consider what additional edge cases you might have missed
4. Think about how comprehensive testing helps with code confidence

This exercise prepares you for professional development where thorough testing is essential for maintaining code quality and preventing regressions.