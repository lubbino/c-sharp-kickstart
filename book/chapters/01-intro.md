# Chapter 01: Introduction & Hello World

## Learning Objectives

By the end of this chapter, you will be able to:

- Set up a C# development environment with .NET SDK and Visual Studio Code
- Create your first C# console application
- Understand the basic structure of a C# program
- Compile and run C# programs using the command line
- Explain what happens when a C# program executes

## Introduction

Welcome to programming with C#! C# (pronounced "C-sharp") is a modern, powerful programming language created by Microsoft. It's used to build everything from desktop applications to web services to mobile apps.

In this course, you'll learn programming fundamentals using C# console applications. Console applications are programs that run in a text-based interface - they're perfect for learning because they let you focus on programming concepts without worrying about complex user interfaces.

## What is Programming?

Programming is the process of creating instructions for a computer to follow. These instructions are written in a programming language that both humans can read and computers can understand.

Think of it like writing a recipe:
- A recipe has ingredients (data) and steps (instructions)
- A program has variables (data) and statements (instructions)
- Both must be precise and in the correct order to work

## Setting Up Your Environment

Before we can write our first program, we need to set up our development environment.

### Install .NET SDK

The .NET SDK (Software Development Kit) contains everything needed to build and run C# programs.

1. Go to [dotnet.microsoft.com/download](https://dotnet.microsoft.com/download)
2. Download the latest LTS (Long Term Support) version
3. Run the installer and follow the instructions
4. Verify installation by opening a terminal and typing:
   ```bash
   dotnet --version
   ```
   You should see a version number like `8.0.100`

### Install Visual Studio Code

Visual Studio Code is a free, powerful code editor that works great with C#.

1. Go to [code.visualstudio.com](https://code.visualstudio.com)
2. Download and install VS Code
3. Install the C# Dev Kit extension:
   - Open VS Code
   - Press `Ctrl+Shift+X` (or `Cmd+Shift+X` on Mac)
   - Search for "C# Dev Kit"
   - Click Install

## Your First C# Program

The traditional first program in any language is "Hello, World!" - a simple program that displays text on the screen. Instead of walking through it here, you'll create it yourself in **Exercise 01-01: Hello World**.

### Key Concepts You'll Learn

When you complete Exercise 01-01, you'll understand:

- `Console.WriteLine()` - a method that displays text on the screen
- **Strings** - text enclosed in double quotes like `"Hello, World!"`
- **Statements** - instructions that end with a semicolon `;`
- **Comments** - lines starting with `//` that explain code to humans

> **🏋️ Practice Now**: Complete [Exercise 01-01: Hello World](../../exercises/01-intro/01-hello-world/) to create your first C# program.

## Understanding Program Structure

Let's look at a more complete C# program structure:

```csharp
using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
```

Don't worry about understanding everything yet. Here's what each part does:

- `using System;` - Tells the program to use the System library
- `namespace HelloWorld` - Groups related code together
- `class Program` - Defines a class (a container for code)
- `static void Main(string[] args)` - The entry point where the program starts
- The curly braces `{}` group code together

The modern template uses a simplified version, but both work the same way.

## The Development Process

When you write C# programs, you follow these steps:

1. **Write** the code in a `.cs` file
2. **Compile** the code using `dotnet build`
3. **Run** the program using `dotnet run`
4. **Debug** any errors and repeat

### Compilation

C# is a compiled language, which means your human-readable code is translated into machine code before it runs. This happens automatically when you use `dotnet run`, but you can also compile separately:

```bash
dotnet build    # Compile the program
dotnet run      # Run the compiled program
```

## Common Mistakes

Here are some common mistakes beginners make:

### Missing Semicolon
```csharp
// Wrong - missing semicolon
Console.WriteLine("Hello")

// Correct
Console.WriteLine("Hello");
```

### Wrong Quotes
```csharp
// Wrong - using single quotes for strings
Console.WriteLine('Hello');

// Correct - use double quotes for strings
Console.WriteLine("Hello");
```

### Case Sensitivity
```csharp
// Wrong - C# is case-sensitive
console.writeline("Hello");

// Correct
Console.WriteLine("Hello");
```

## Hands-On Practice

Now that you understand the basics, it's time to practice with hands-on exercises:

### Exercise Progression

1. **[Exercise 01-01: Hello World](../../exercises/01-intro/01-hello-world/)** - Create your first C# program
2. **[Exercise 01-02: Multiple Outputs](../../exercises/01-intro/02-multiple-outputs/)** - Practice using multiple `Console.WriteLine()` statements
3. **[Exercise 01-03: Comments and Code](../../exercises/01-intro/03-comments-and-code/)** - Learn to document your code with comments

Each exercise builds on the previous one and reinforces the concepts you've learned in this chapter.

> **💡 Tip**: Complete the exercises in order. Each one introduces new concepts while reinforcing what you've already learned.

## Summary

In this chapter, you learned:

- How to set up a C# development environment
- The basic structure of a C# program
- How to create, compile, and run a simple console application
- The development process: write, compile, run, debug

Programming is like learning a new language - it takes practice. Don't worry if everything doesn't make perfect sense yet. Each chapter will build on what you've learned.

## Next Steps

In the next chapter, we'll explore how programs execute step by step and learn about the concept of sequence - the order in which instructions are carried out.

## Key Terms

- **C#**: A programming language created by Microsoft
- **Console Application**: A program that runs in a text-based interface
- **Compilation**: Converting human-readable code into machine code
- **.NET SDK**: Software Development Kit for building .NET applications
- **Statement**: A single instruction in a program
- **String**: Text enclosed in double quotes
- **Method**: A block of code that performs a specific task