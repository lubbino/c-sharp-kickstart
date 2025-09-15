# Exercise 06-02: Menu System

## Background

This exercise helps you practice using switch statements to create menu-driven programs and handle multiple user choices efficiently.

## Instructions

Create a C# console application that displays a menu of options and performs different actions based on the user's choice using switch statements.

## Requirements

1. Display a main menu with at least 4 options
2. Use a switch statement to handle user choices
3. Implement each menu option with appropriate functionality
4. Handle invalid menu choices with a default case
5. Use clear, formatted output for all menu options

## Menu Options

Your menu should include:
1. Calculate area of rectangle
2. Calculate area of circle
3. Convert temperature (Celsius to Fahrenheit)
4. Exit program

## Expected Output

Your program should produce output similar to this:

```
Main Menu
=========
1. Calculate area of rectangle
2. Calculate area of circle
3. Convert temperature (C to F)
4. Exit

Enter your choice (1-4): 2

Circle Area Calculator
=====================
Enter radius: 5
Area of circle: 78.54

Thank you for using the calculator!
```

**Invalid Choice Example:**
```
Enter your choice (1-4): 7

Invalid choice! Please select 1, 2, 3, or 4.
```

## Hints

- Use `switch (choice)` with `case 1:`, `case 2:`, etc.
- Don't forget `break;` after each case
- Use `default:` for invalid choices
- For circle area: `Math.PI * radius * radius`
- For temperature: `(celsius * 9/5) + 32`
- Use `Console.WriteLine()` for spacing and formatting

## Getting Started

1. Create a new console application:
   ```bash
   dotnet new console -n MenuSystem
   cd MenuSystem
   ```

2. Open `Program.cs` in your editor

3. Implement the menu system with switch statement

4. Run your program:
   ```bash
   dotnet run
   ```

## Testing Your Solution

Your program should:
- Compile without errors
- Display a clear, formatted menu
- Use switch statement for choice handling
- Implement all 4 menu options correctly
- Handle invalid choices with default case
- Include break statements in all cases
- Perform calculations accurately
- Display results clearly