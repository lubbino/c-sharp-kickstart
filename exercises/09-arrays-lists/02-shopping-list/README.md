# Exercise 09-02: Shopping List Manager

## Background

This exercise helps you practice using lists with add, remove, and search operations to create a dynamic data management application.

## Instructions

Create a C# console application that manages a shopping list using List operations and provides a menu-driven interface.

## Requirements

1. Use a List<string> to store shopping items
2. Implement a menu system with multiple options
3. Allow adding, removing, and viewing items
4. Implement search functionality
5. Provide item counting and list management features

## Menu Options

Your program should support these commands:
1. Add item to list
2. Remove item from list
3. View all items
4. Search for item
5. Clear entire list
6. Show list statistics
7. Exit program

## Expected Output

Your program should produce output similar to this:

```
Shopping List Manager
====================

Menu:
1. Add item
2. Remove item
3. View all items
4. Search for item
5. Clear list
6. Show statistics
7. Exit

Enter your choice (1-7): 1

Enter item to add: Milk
Added "Milk" to the shopping list.

Enter your choice (1-7): 1

Enter item to add: Bread
Added "Bread" to the shopping list.

Enter your choice (1-7): 3

Shopping List:
=============
1. Milk
2. Bread

Enter your choice (1-7): 4

Enter item to search for: milk
Found "Milk" at position 1.

Enter your choice (1-7): 6

List Statistics:
===============
Total items: 2
List is not empty
Items: Milk, Bread

Enter your choice (1-7): 7

Thank you for using Shopping List Manager!
```

## Hints

- Use `List<string>` for dynamic item storage
- Use a while loop for the menu system
- Use `ToLower()` for case-insensitive searching
- Use `IndexOf()` to find items in the list
- Display items with numbered list format
- Validate menu choices and handle invalid input

## Getting Started

1. Create a new console application:
   ```bash
   dotnet new console -n ShoppingList
   cd ShoppingList
   ```

2. Open `Program.cs` in your editor

3. Create the menu system and list operations

4. Run your program:
   ```bash
   dotnet run
   ```

## Testing Your Solution

Your program should:
- Compile without errors
- Use List<string> for item storage
- Implement all 7 menu options correctly
- Handle case-insensitive searching
- Display items in a numbered format
- Validate user input appropriately
- Provide clear feedback for all operations