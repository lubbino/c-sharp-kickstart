# Exercise 10-01: Code Review

## Background

Code review is a critical skill in software development. It involves analyzing existing code to identify problems and suggest improvements. This exercise presents you with working but poorly written C# code that needs significant quality improvements.

## Instructions

Analyze the code in [`Program.cs`](Program.cs) and create an improved version. The current code works functionally but has numerous quality issues that make it hard to read, maintain, and extend.

## Current Code Problems

The provided code has intentional quality issues across multiple categories:

### 1. Naming Issues
- **Method names**: `M1()`, `M2()`, `M3()` are meaningless
- **Variable names**: `cnt`, `fn`, `nums`, `s`, `mx`, `mn`, `x` are unclear abbreviations
- **Magic numbers**: Hard-coded values like `-1`, `3`, `50` without explanation

### 2. Structure Issues
- **Static variables**: Unnecessary use of static state
- **Large methods**: `M2()` does too many different things
- **Poor separation**: Input, processing, and output mixed together
- **No modularity**: Difficult to test or reuse individual parts

### 3. Formatting Issues
- **Inconsistent spacing**: Around operators and in statements
- **Poor indentation**: Some blocks not properly indented
- **Bracket placement**: Inconsistent style
- **Output formatting**: Missing spaces in console output

### 4. Comment Issues
- **No documentation**: Methods lack purpose explanation
- **No algorithm explanation**: Complex logic unexplained
- **No parameter documentation**: Method inputs/outputs unclear

### 5. Error Handling Issues
- **File operations**: No checking if file operations succeed
- **Input validation**: No validation of user input in `M1()`
- **Division by zero**: Potential issue if no numbers entered
- **Resource management**: Files not properly disposed

### 6. Modern C# Issues
- **Using statements**: Not using `using` for file operations
- **LINQ**: Using loops instead of LINQ where appropriate
- **String interpolation**: Using concatenation instead of interpolation
- **Nullable reference types**: Not handling null values properly

## Your Task

Create an improved version of this code that addresses all identified issues. Your improved code should:

### Naming Requirements
- Use descriptive method names that explain what they do
- Use clear variable names that indicate their purpose
- Replace magic numbers with named constants
- Follow C# naming conventions (PascalCase for methods, camelCase for variables)

### Structure Requirements
- Eliminate static variables where inappropriate
- Break large methods into smaller, focused methods
- Separate input, processing, and output concerns
- Create reusable, testable methods

### Formatting Requirements
- Use consistent indentation (4 spaces recommended)
- Add appropriate spacing around operators
- Format output clearly and consistently
- Follow C# bracket placement conventions

### Documentation Requirements
- Add XML documentation comments for methods
- Comment complex algorithms and business logic
- Explain any remaining magic numbers or constants
- Add file header with program description

### Error Handling Requirements
- Validate all user input
- Check file operation success
- Handle edge cases (empty input, invalid filenames)
- Provide clear, helpful error messages

### Modern C# Requirements
- Use `using` statements for resource management
- Use LINQ where appropriate
- Apply string interpolation
- Handle nullable reference types properly

## Expected Functionality

Your improved code should maintain the same functionality:

1. **Input Collection**: Prompt user for filename and collect numbers until -1 is entered
2. **Statistics Calculation**: Calculate count, sum, average, minimum, and maximum
3. **Sorting**: Sort the numbers in ascending order
4. **Display Results**: Show all statistics on console
5. **File Output**: Save results to the specified file
6. **Validation**: Validate filename format (3-50 characters, alphanumeric plus . and _)

## Sample Improved Structure

Consider organizing your improved code like this:

```csharp
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace NumberAnalyzer
{
    /// <summary>
    /// A program that collects numbers from user input, calculates statistics,
    /// and saves the results to a file.
    /// </summary>
    public class Program
    {
        // Constants
        private const int MinFilenameLength = 3;
        private const int MaxFilenameLength = 50;
        private const int StopInputValue = -1;

        /// <summary>
        /// Main entry point of the application.
        /// </summary>
        public static void Main(string[] args)
        {
            try
            {
                var analyzer = new NumberAnalyzer();
                analyzer.Run();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }

    /// <summary>
    /// Handles number collection, analysis, and file output.
    /// </summary>
    public class NumberAnalyzer
    {
        /// <summary>
        /// Runs the complete number analysis workflow.
        /// </summary>
        public void Run()
        {
            string filename = GetValidFilename();
            var numbers = CollectNumbers();
            
            if (numbers.Count == 0)
            {
                Console.WriteLine("No numbers were entered.");
                return;
            }
            
            var statistics = CalculateStatistics(numbers);
            DisplayStatistics(statistics);
            SaveStatisticsToFile(statistics, filename);
        }

        // Method declarations...
    }
}
```

## Compilation and Testing

Compile and test your improved code:

```bash
# From the c-sharp-kickstart directory
cd exercises/10-code-quality/code-review
dotnet run
```

Test with various inputs:
- Valid filenames and number sequences
- Invalid filenames (too short, too long, invalid characters)
- Empty number sequences
- Large number sequences
- Edge cases (single number, negative numbers)

## Evaluation Criteria

Your improved code will be evaluated on:

### Code Quality (40%)
- **Naming**: Clear, descriptive names throughout
- **Structure**: Well-organized, focused methods
- **Formatting**: Consistent, professional appearance
- **Comments**: Helpful XML documentation without over-commenting

### Error Handling (25%)
- **Input Validation**: Robust handling of invalid input
- **File Operations**: Proper error checking and reporting
- **Edge Cases**: Graceful handling of unusual situations
- **User Experience**: Clear, helpful error messages

### Modern C# Usage (20%)
- **LINQ**: Appropriate use of Language Integrated Query
- **Using Statements**: Proper resource management
- **String Interpolation**: Modern string formatting
- **Best Practices**: Following current C# conventions

### Functionality (15%)
- **Correctness**: Program works as specified
- **Completeness**: All features implemented
- **Reliability**: Handles various input scenarios
- **Performance**: Efficient implementation

## Learning Goals

This exercise helps you develop:
- **Code analysis skills**: Identifying quality issues in existing code
- **Refactoring techniques**: Systematically improving code structure
- **Professional standards**: Understanding industry-quality code expectations
- **Debugging mindset**: Thinking about edge cases and error conditions
- **Documentation skills**: Writing clear, helpful comments and documentation

## Common Refactoring Patterns

### Extract Method
Break large methods into smaller, focused ones:
```csharp
// Before: One large method doing everything
static void ProcessEverything() { /* 50+ lines */ }

// After: Multiple focused methods
static void CollectInput() { /* focused task */ }
static void CalculateStatistics() { /* focused task */ }
static void DisplayResults() { /* focused task */ }
```

### Replace Magic Numbers
Use named constants instead of hard-coded values:
```csharp
// Before: Magic numbers
if (filename.Length < 3 || filename.Length > 50) { }

// After: Named constants
const int MinLength = 3;
const int MaxLength = 50;
if (filename.Length < MinLength || filename.Length > MaxLength) { }
```

### Improve Error Handling
Add comprehensive validation and error reporting:
```csharp
// Before: No error checking
File.WriteAllText(filename, data);

// After: Proper error handling
try
{
    File.WriteAllText(filename, data);
}
catch (UnauthorizedAccessException)
{
    throw new InvalidOperationException($"Access denied to file: {filename}");
}
catch (DirectoryNotFoundException)
{
    throw new InvalidOperationException($"Directory not found for file: {filename}");
}
```

### Use Modern C# Features
```csharp
// Before: Traditional loops and concatenation
string result = "";
for (int i = 0; i < numbers.Count; i++)
{
    result += numbers[i].ToString() + ", ";
}

// After: LINQ and string interpolation
string result = string.Join(", ", numbers.Select(n => n.ToString()));
```

## Next Steps

After completing this exercise:
1. Compare your improved version with the original
2. Identify which changes had the biggest impact on readability
3. Consider how these improvements would help in a team environment
4. Think about how automated tools (linters, formatters) could help maintain quality

This exercise prepares you for real-world code review scenarios and helps develop the critical eye needed for maintaining high-quality codebases.