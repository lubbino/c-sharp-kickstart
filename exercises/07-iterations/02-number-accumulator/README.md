# Exercise 07-02: Number Accumulator

## Background

This exercise helps you practice using while loops to process user input until a specific condition is met, and accumulate values over multiple iterations.

## Instructions

Create a C# console application that continuously asks the user for numbers and calculates running statistics until they choose to stop.

## Requirements

1. Use a while loop to continuously ask for numbers
2. Allow the user to enter "done" to stop entering numbers
3. Keep track of the count, sum, average, highest, and lowest numbers
4. Validate that input is either a valid number or "done"
5. Display running statistics after each valid number
6. Display final statistics when the user is finished

## Expected Output

Your program should produce output similar to this:

```
Number Accumulator
=================

Enter numbers one at a time (type 'done' to finish):

Enter a number: 15
Numbers entered: 1, Sum: 15, Average: 15.0, Highest: 15, Lowest: 15

Enter a number: 8
Numbers entered: 2, Sum: 23, Average: 11.5, Highest: 15, Lowest: 8

Enter a number: 22
Numbers entered: 3, Sum: 45, Average: 15.0, Highest: 22, Lowest: 8

Enter a number: abc
Invalid input! Please enter a number or 'done'.

Enter a number: done

Final Statistics:
================
Total numbers entered: 3
Sum: 45
Average: 15.0
Highest number: 22
Lowest number: 8

Thank you for using the Number Accumulator!
```

## Hints

- Use a while loop with a boolean condition: `while (continueInput)`
- Check for "done": `input.ToLower() == "done"`
- Use `double.TryParse()` to validate numeric input
- Keep track of count, sum, highest, and lowest in variables
- Update statistics after each valid number
- Calculate average: `(double)sum / count`

## Getting Started

1. Create a new console application:
   ```bash
   dotnet new console -n NumberAccumulator
   cd NumberAccumulator
   ```

2. Open `Program.cs` in your editor

3. Implement the number accumulator with while loop

4. Run your program:
   ```bash
   dotnet run
   ```

## Testing Your Solution

Your program should:
- Compile without errors
- Use while loop for continuous input
- Validate input properly (numbers or "done")
- Track all required statistics (count, sum, average, min, max)
- Display running statistics after each number
- Handle invalid input gracefully
- Display comprehensive final statistics