# Exercise 05-01: User Information Collector

## Background

This exercise helps you practice getting input from users, converting between data types, and creating interactive programs that respond to user input.

## Instructions

Create a C# console application that collects various types of information from the user and displays a formatted summary.

## Requirements

1. Prompt the user for different types of information
2. Use `Console.ReadLine()` to get user input
3. Convert string input to appropriate data types using `Parse()` methods
4. Validate that numeric input is reasonable
5. Display a well-formatted summary of all collected information
6. Use string interpolation for clean output formatting

## Expected Output

Your program should produce an interaction similar to this:

```
User Information Collector
=========================

Please enter your information:

First name: Emma
Last name: Johnson
Age: 17
Height in cm: 165.5
Favorite number: 42
Are you a student? (yes/no): yes

Summary
=======
Name: Emma Johnson
Age: 17 years old
Height: 165.5 cm
Favorite Number: 42
Student Status: Yes

Thank you for using the User Information Collector!
```

## Hints

- Use `Console.ReadLine()` for all input
- Convert strings to numbers: `int.Parse()` for whole numbers, `double.Parse()` for decimals
- Check for "yes" answers: `input.ToLower() == "yes"`
- Use string interpolation: `$"Name: {firstName} {lastName}"`
- Add blank lines with `Console.WriteLine()` for better formatting

## Getting Started

1. Create a new console application:
   ```bash
   dotnet new console -n UserInfoCollector
   cd UserInfoCollector
   ```

2. Open `Program.cs` in your editor

3. Create prompts and collect user input

4. Run your program:
   ```bash
   dotnet run
   ```

## Testing Your Solution

Your program should:
- Compile without errors
- Prompt for all required information clearly
- Convert string input to appropriate data types
- Display a well-formatted summary
- Use string interpolation for output
- Handle the yes/no question appropriately