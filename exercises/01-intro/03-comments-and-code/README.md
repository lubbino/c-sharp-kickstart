# Exercise 01-03: Comments and Code

## Background

This exercise helps you practice using comments to document your code and understand the difference between code that runs and comments that are ignored by the computer.

## Instructions

Create a C# console application that demonstrates the use of comments alongside working code.

## Requirements

1. Include at least 3 single-line comments using `//`
2. Use at least 3 `Console.WriteLine()` statements
3. Add a comment above each `Console.WriteLine()` explaining what it does
4. Include a comment at the top explaining what the program does
5. Show that comments don't affect program output

## Expected Output

Your program should produce output similar to this:

```
Welcome to my first C# program!
This line shows how comments work.
Comments help explain code to humans.
```

The comments should not appear in the output - they are only visible in the source code.

## Example Structure

Your code should follow this pattern:

```csharp
// This program demonstrates the use of comments in C#

// Display a welcome message
Console.WriteLine("Welcome to my first C# program!");

// Show information about comments
Console.WriteLine("This line shows how comments work.");

// Explain the purpose of comments
Console.WriteLine("Comments help explain code to humans.");
```

## Hints

- Comments start with `//` and continue to the end of the line
- Comments are ignored by the computer when the program runs
- Good comments explain WHY you're doing something, not just WHAT
- You can also comment out code temporarily by putting `//` in front of it

## Getting Started

1. Create a new console application:
   ```bash
   dotnet new console -n CommentsAndCode
   cd CommentsAndCode
   ```

2. Open `Program.cs` in your editor

3. Write your program with comments and code

4. Run your program:
   ```bash
   dotnet run
   ```

## Testing Your Solution

Your program should:
- Compile without errors
- Display exactly 3 lines of output
- Have meaningful comments that explain the code
- Show that comments don't appear in the program output
- Use proper C# syntax for both code and comments