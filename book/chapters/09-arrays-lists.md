# Chapter 09: Arrays and Lists

## Learning Objectives

By the end of this chapter, you will be able to:

- Understand what arrays and lists are and when to use them
- Create and initialize arrays and lists in C#
- Access and modify elements using indexes
- Use loops to process arrays and lists efficiently
- Implement common algorithms: search, find minimum/maximum, calculate averages
- Choose between arrays and lists for different scenarios
- Work with collections of data in real-world applications

## Introduction

So far, you've worked with individual variables that store single values. But what if you need to store many related values, like test scores for a class, names of students, or temperatures for each day of the week? **Arrays** and **Lists** let you store collections of related data.

## Arrays

An array is a collection of elements of the same type, stored in a fixed-size container.

### Creating Arrays

```csharp
using System;

// Declare and initialize with values
int[] scores = {85, 92, 78, 96, 88};
string[] names = {"Alice", "Bob", "Charlie", "Diana"};

// Declare with specific size
int[] numbers = new int[5];  // Array of 5 integers (all start as 0)
string[] cities = new string[3];  // Array of 3 strings (all start as null)
```

### Accessing Array Elements

Arrays use **zero-based indexing** - the first element is at index 0:

```csharp
using System;

int[] scores = {85, 92, 78, 96, 88};

Console.WriteLine($"First score: {scores[0]}");   // 85
Console.WriteLine($"Second score: {scores[1]}");  // 92
Console.WriteLine($"Last score: {scores[4]}");    // 88

// Modify elements
scores[2] = 80;  // Change third score from 78 to 80
Console.WriteLine($"Updated third score: {scores[2]}");  // 80
```

### Array Properties

```csharp
using System;

int[] numbers = {10, 20, 30, 40, 50};

Console.WriteLine($"Array length: {numbers.Length}");  // 5
Console.WriteLine($"Last index: {numbers.Length - 1}"); // 4
Console.WriteLine($"Last element: {numbers[numbers.Length - 1]}"); // 50
```

### Processing Arrays with Loops

```csharp
using System;

int[] scores = {85, 92, 78, 96, 88};

// Using for loop
Console.WriteLine("Scores using for loop:");
for (int i = 0; i < scores.Length; i++)
{
    Console.WriteLine($"Score {i + 1}: {scores[i]}");
}

// Using foreach loop (cleaner for reading)
Console.WriteLine("\nScores using foreach loop:");
foreach (int score in scores)
{
    Console.WriteLine($"Score: {score}");
}
```

## Lists

Lists are like arrays but can grow and shrink in size. They're more flexible but slightly slower than arrays.

### Creating Lists

```csharp
using System;
using System.Collections.Generic;

// Create empty list
List<int> numbers = new List<int>();

// Create list with initial values
List<string> names = new List<string> {"Alice", "Bob", "Charlie"};

// Create list with capacity (optimization)
List<double> temperatures = new List<double>(7);  // Expect 7 items
```

### Adding and Removing Elements

```csharp
using System;
using System.Collections.Generic;

List<string> fruits = new List<string>();

// Add elements
fruits.Add("Apple");
fruits.Add("Banana");
fruits.Add("Orange");

Console.WriteLine($"Fruits count: {fruits.Count}");  // 3

// Insert at specific position
fruits.Insert(1, "Grape");  // Insert at index 1

// Remove elements
fruits.Remove("Banana");     // Remove by value
fruits.RemoveAt(0);         // Remove by index

// Display remaining fruits
foreach (string fruit in fruits)
{
    Console.WriteLine(fruit);
}
```

### List Methods

```csharp
using System;
using System.Collections.Generic;

List<int> numbers = new List<int> {5, 2, 8, 1, 9, 3};

Console.WriteLine($"Original: {string.Join(", ", numbers)}");

// Check if list contains a value
bool hasEight = numbers.Contains(8);
Console.WriteLine($"Contains 8: {hasEight}");

// Find index of a value
int indexOfFive = numbers.IndexOf(5);
Console.WriteLine($"Index of 5: {indexOfFive}");

// Sort the list
numbers.Sort();
Console.WriteLine($"Sorted: {string.Join(", ", numbers)}");

// Reverse the list
numbers.Reverse();
Console.WriteLine($"Reversed: {string.Join(", ", numbers)}");

// Clear all elements
numbers.Clear();
Console.WriteLine($"After clear, count: {numbers.Count}");
```

## Common Array and List Operations

### Finding Maximum and Minimum

```csharp
using System;

static int FindMaximum(int[] numbers)
{
    if (numbers.Length == 0) return 0;
    
    int max = numbers[0];
    for (int i = 1; i < numbers.Length; i++)
    {
        if (numbers[i] > max)
            max = numbers[i];
    }
    return max;
}

static int FindMinimum(int[] numbers)
{
    if (numbers.Length == 0) return 0;
    
    int min = numbers[0];
    foreach (int number in numbers)
    {
        if (number < min)
            min = number;
    }
    return min;
}

static void Main(string[] args)
{
    int[] scores = {85, 92, 78, 96, 88, 74, 91};
    
    Console.WriteLine($"Highest score: {FindMaximum(scores)}");
    Console.WriteLine($"Lowest score: {FindMinimum(scores)}");
}
```

### Calculating Statistics

```csharp
using System;

static double CalculateAverage(double[] numbers)
{
    if (numbers.Length == 0) return 0;
    
    double sum = 0;
    foreach (double number in numbers)
    {
        sum += number;
    }
    return sum / numbers.Length;
}

static int CountAboveAverage(double[] numbers, double average)
{
    int count = 0;
    foreach (double number in numbers)
    {
        if (number > average)
            count++;
    }
    return count;
}

static void Main(string[] args)
{
    double[] temperatures = {22.5, 25.1, 19.8, 23.7, 26.2, 21.9, 24.3};
    
    double average = CalculateAverage(temperatures);
    int aboveAverage = CountAboveAverage(temperatures, average);
    
    Console.WriteLine($"Average temperature: {average:F1}°C");
    Console.WriteLine($"Days above average: {aboveAverage}");
}
```

### Searching Arrays

```csharp
using System;

static int LinearSearch(int[] array, int target)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == target)
            return i;  // Return index where found
    }
    return -1;  // Not found
}

static bool Contains(string[] array, string target)
{
    foreach (string item in array)
    {
        if (item.ToLower() == target.ToLower())
            return true;
    }
    return false;
}

static void Main(string[] args)
{
    int[] numbers = {10, 25, 30, 45, 50};
    string[] colors = {"red", "blue", "green", "yellow"};
    
    int index = LinearSearch(numbers, 30);
    Console.WriteLine($"30 found at index: {index}");
    
    bool hasBlue = Contains(colors, "Blue");
    Console.WriteLine($"Contains blue: {hasBlue}");
}
```

## Working with User Input

### Building Arrays from Input

```csharp
using System;

static void Main(string[] args)
{
    Console.WriteLine("How many scores do you want to enter?");
    int count = int.Parse(Console.ReadLine());
    
    double[] scores = new double[count];
    
    // Fill array with user input
    for (int i = 0; i < scores.Length; i++)
    {
        Console.WriteLine($"Enter score {i + 1}:");
        scores[i] = double.Parse(Console.ReadLine());
    }
    
    // Display all scores
    Console.WriteLine("\nYour scores:");
    for (int i = 0; i < scores.Length; i++)
    {
        Console.WriteLine($"Score {i + 1}: {scores[i]}");
    }
    
    // Calculate average
    double sum = 0;
    foreach (double score in scores)
    {
        sum += score;
    }
    double average = sum / scores.Length;
    
    Console.WriteLine($"\nAverage score: {average:F1}");
}
```

### Dynamic Lists with User Input

```csharp
using System;
using System.Collections.Generic;

static void Main(string[] args)
{
    List<string> todoList = new List<string>();
    string command = "";
    
    Console.WriteLine("Simple Todo List");
    Console.WriteLine("Commands: add, list, remove, quit");
    
    while (command != "quit")
    {
        Console.WriteLine("\nEnter command:");
        command = Console.ReadLine().ToLower();
        
        switch (command)
        {
            case "add":
                Console.WriteLine("Enter todo item:");
                string item = Console.ReadLine();
                todoList.Add(item);
                Console.WriteLine($"Added: {item}");
                break;
                
            case "list":
                Console.WriteLine("\nTodo List:");
                for (int i = 0; i < todoList.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {todoList[i]}");
                }
                break;
                
            case "remove":
                if (todoList.Count > 0)
                {
                    Console.WriteLine("Enter item number to remove:");
                    if (int.TryParse(Console.ReadLine(), out int index) && 
                        index >= 1 && index <= todoList.Count)
                    {
                        string removed = todoList[index - 1];
                        todoList.RemoveAt(index - 1);
                        Console.WriteLine($"Removed: {removed}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid item number.");
                    }
                }
                else
                {
                    Console.WriteLine("Todo list is empty.");
                }
                break;
                
            case "quit":
                Console.WriteLine("Goodbye!");
                break;
                
            default:
                Console.WriteLine("Unknown command. Use: add, list, remove, quit");
                break;
        }
    }
}
```

## Arrays vs Lists

### When to Use Arrays
- Fixed size collections
- Performance is critical
- Working with mathematical data
- Interfacing with older APIs

```csharp
// Good use of arrays
double[] coordinates = new double[3];  // x, y, z coordinates
int[] daysInMonth = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
```

### When to Use Lists
- Size changes during program execution
- Need to add/remove elements frequently
- Want convenient methods (Sort, Contains, etc.)
- Most general-purpose scenarios

```csharp
// Good use of lists
List<string> usernames = new List<string>();  // Will grow as users register
List<int> primeNumbers = new List<int>();     // Will add primes as found
```

## Multi-Dimensional Arrays

### Two-Dimensional Arrays

```csharp
using System;

// Create a 3x3 grid
int[,] grid = new int[3, 3];

// Initialize with values
int[,] matrix = {
    {1, 2, 3},
    {4, 5, 6},
    {7, 8, 9}
};

// Access elements
Console.WriteLine($"Center element: {matrix[1, 1]}");  // 5

// Process with nested loops
for (int row = 0; row < 3; row++)
{
    for (int col = 0; col < 3; col++)
    {
        Console.Write($"{matrix[row, col]} ");
    }
    Console.WriteLine();
}
```

## Common Mistakes

### Index Out of Bounds

```csharp
// Wrong - accessing beyond array bounds
int[] numbers = {1, 2, 3};
Console.WriteLine(numbers[3]);  // Error! Index 3 doesn't exist

// Correct - check bounds
if (index >= 0 && index < numbers.Length)
{
    Console.WriteLine(numbers[index]);
}
```

### Forgetting to Initialize

```csharp
// Wrong - using uninitialized array
int[] scores;
scores[0] = 85;  // Error! Array not created

// Correct - initialize first
int[] scores = new int[5];
scores[0] = 85;
```

### Modifying Array During foreach

```csharp
// Wrong - can't modify array elements in foreach
int[] numbers = {1, 2, 3, 4, 5};
foreach (int number in numbers)
{
    number = number * 2;  // Error! Can't modify
}

// Correct - use for loop for modifications
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = numbers[i] * 2;
}
```

## Hands-On Practice

Now it's time to apply what you've learned about arrays and lists in practical scenarios:

### Exercise Progression

1. **[Exercise 09-01: Grade Analyzer](../../exercises/09-arrays-lists/01-grade-analyzer/)** - Practice using lists and methods to analyze student grades with statistical calculations
2. **[Exercise 09-02: Shopping List Manager](../../exercises/09-arrays-lists/02-shopping-list/)** - Master dynamic list operations by building an interactive shopping list application

### Major Project Integration

After completing these exercises, you'll be ready for **[Project 2: Word Statistics Analyzer](../../projects/02-word-statistics/)** - a comprehensive text analysis application that combines all the concepts you've learned: methods, lists, string processing, and statistical analysis.

> **💡 Learning Tip**: Lists are incredibly powerful for managing dynamic data. Practice the common operations (Add, Remove, Contains, Count) as they form the foundation of most data processing applications.
            int index = uniqueWords.IndexOf(cleanWord);
            if (index >= 0)
            {
                wordCounts[index]++;  // Word already exists, increment count
            }
            else
            {
                uniqueWords.Add(cleanWord);  // New word
                wordCounts.Add(1);
            }
        }
    }
    
    // Display results
    Console.WriteLine("\nWord Frequency:");
    for (int i = 0; i < uniqueWords.Count; i++)
    {
        Console.WriteLine($"{uniqueWords[i]}: {wordCounts[i]}");
    }
}
```

## Advanced List Operations

### Sorting and Filtering

```csharp
using System;
using System.Collections.Generic;

static void Main(string[] args)
{
    List<int> numbers = new List<int> {45, 12, 78, 23, 56, 89, 34};
    
    Console.WriteLine($"Original: {string.Join(", ", numbers)}");
    
    // Sort numbers
    numbers.Sort();
    Console.WriteLine($"Sorted: {string.Join(", ", numbers)}");
    
    // Find even numbers
    List<int> evenNumbers = new List<int>();
    foreach (int number in numbers)
    {
        if (number % 2 == 0)
            evenNumbers.Add(number);
    }
    Console.WriteLine($"Even numbers: {string.Join(", ", evenNumbers)}");
    
    // Find numbers greater than 50
    List<int> largeNumbers = new List<int>();
    foreach (int number in numbers)
    {
        if (number > 50)
            largeNumbers.Add(number);
    }
    Console.WriteLine($"Numbers > 50: {string.Join(", ", largeNumbers)}");
}
```

### Working with Methods

```csharp
using System;
using System.Collections.Generic;

static void DisplayArray(int[] array, string title)
{
    Console.WriteLine($"{title}: [{string.Join(", ", array)}]");
}

static int[] GetEvenNumbers(int[] numbers)
{
    List<int> evens = new List<int>();
    foreach (int number in numbers)
    {
        if (number % 2 == 0)
            evens.Add(number);
    }
    return evens.ToArray();  // Convert list back to array
}

static double CalculateSum(double[] numbers)
{
    double sum = 0;
    foreach (double number in numbers)
    {
        sum += number;
    }
    return sum;
}

static void Main(string[] args)
{
    int[] allNumbers = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
    double[] prices = {19.99, 25.50, 12.75, 8.99, 15.25};
    
    DisplayArray(allNumbers, "All numbers");
    
    int[] evenNumbers = GetEvenNumbers(allNumbers);
    DisplayArray(evenNumbers, "Even numbers");
    
    double totalPrice = CalculateSum(prices);
    Console.WriteLine($"Total price: ${totalPrice:F2}");
}
```

## Summary

In this chapter, you learned:

- **Arrays** store fixed-size collections of the same data type
- **Lists** store variable-size collections with convenient methods
- **Zero-based indexing** means the first element is at index 0
- **Loops** are essential for processing arrays and lists
- **Common operations** include search, sort, find min/max, calculate averages
- **Methods** can work with arrays and lists as parameters and return values
- **When to use arrays vs lists** depends on your specific needs

## Next Steps

In the next chapter, we'll combine methods and collections to build a complete project that processes real-world data efficiently.

## Key Terms

- **Array**: Fixed-size collection of elements of the same type
- **List**: Variable-size collection with built-in methods
- **Index**: Position of an element in an array or list (starts at 0)
- **Zero-based indexing**: First element is at index 0, not 1
- **Element**: Individual item stored in an array or list
- **Collection**: General term for arrays, lists, and similar data structures
- **Linear Search**: Looking through elements one by one to find a value
- **Multi-dimensional Array**: Array with rows and columns (like a table)