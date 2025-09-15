# Exercise 03-01: Personal Information

## Background

This exercise helps you practice declaring variables with different data types and using them to store and display personal information.

## Instructions

Create a C# console application that stores personal information in variables and displays it in a formatted way.

## Requirements

1. Declare variables for the following information using appropriate data types:
   - First name (text)
   - Last name (text)
   - Age (whole number)
   - Height in centimeters (decimal number)
   - Is a student (true/false)
   - Favorite number (whole number)

2. Initialize each variable with your own information (or made-up data)

3. Display the information in a clear, formatted way

4. Calculate and display your birth year using the current year and your age

## Expected Output

Your program should produce output similar to this:

```
Personal Information
===================
Name: Emma Johnson
Age: 17 years old
Height: 165.5 cm
Student: True
Favorite Number: 42
Birth Year: 2007
```

## Hints

- Use `string` for text, `int` for whole numbers, `double` for decimals, `bool` for true/false
- You can combine variables with text using the `+` operator
- To calculate birth year: `currentYear - age`
- Use `Console.WriteLine()` for each line of output

## Getting Started

1. Create a new console application:
   ```bash
   dotnet new console -n PersonalInfo
   cd PersonalInfo
   ```

2. Open `Program.cs` in your editor

3. Declare your variables and assign values

4. Display the information using `Console.WriteLine()`

5. Run your program:
   ```bash
   dotnet run
   ```

## Testing Your Solution

Your program should:
- Compile without errors
- Use appropriate data types for each piece of information
- Display all required information clearly
- Calculate birth year correctly
- Follow proper C# variable naming conventions (camelCase)