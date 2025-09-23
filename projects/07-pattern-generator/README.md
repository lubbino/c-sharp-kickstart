# Pattern Generator Project

## Overview
This project demonstrates iteration concepts (for, while, do-while loops) by creating a pattern generator program. Students will create various number and character patterns using different types of loops.

## Learning Objectives
- Practice using for loops
- Work with while and do-while loops
- Understand nested loops
- Practice loop control with break and continue
- Work with pattern generation algorithms

## Requirements
Create a program that:

1. **Displays a welcome message** and shows a menu of pattern options

2. **Offers the following pattern types**:
   - 1. Number Triangle (ascending)
   - 2. Number Triangle (descending)
   - 3. Star Pyramid
   - 4. Diamond Pattern
   - 5. Multiplication Table
   - 6. Fibonacci Sequence
   - 7. Prime Numbers
   - 8. Exit

3. **For each pattern, asks for size/limit**:
   - Triangle patterns: number of rows
   - Multiplication table: which table and up to what number
   - Fibonacci: how many numbers to generate
   - Prime numbers: upper limit

4. **Generates and displays the requested pattern**

5. **Validates all inputs** (positive numbers, reasonable limits)

6. **Continues until user chooses to exit**

## Sample Output
```
=== Pattern Generator ===

Available Patterns:
1. Number Triangle (ascending)
2. Number Triangle (descending)
3. Star Pyramid
4. Diamond Pattern
5. Multiplication Table
6. Fibonacci Sequence
7. Prime Numbers
8. Exit

Choose a pattern (1-8): 1

Enter number of rows: 5

Number Triangle (ascending):
1
1 2
1 2 3
1 2 3 4
1 2 3 4 5

Choose a pattern (1-8): 3

Enter number of rows: 4

Star Pyramid:
   *
  ***
 *****
*******

Choose a pattern (1-8): 6

Enter how many Fibonacci numbers: 8

Fibonacci Sequence:
0, 1, 1, 2, 3, 5, 8, 13

Choose a pattern (1-8): 8

Thank you for using Pattern Generator!
```

## Pattern Examples

### Number Triangle (ascending)
```
1
1 2
1 2 3
1 2 3 4
1 2 3 4 5
```

### Number Triangle (descending)
```
5 4 3 2 1
4 3 2 1
3 2 1
2 1
1
```

### Star Pyramid
```
   *
  ***
 *****
*******
```

### Diamond Pattern
```
  *
 ***
*****
 ***
  *
```

## Tips
- Use nested loops for 2D patterns
- Consider using `Console.Write()` vs `Console.WriteLine()`
- Use string multiplication or loops for spacing
- Break down complex patterns into smaller parts
- Test with small sizes first

## Challenge Extensions
- Add more complex patterns (Pascal's triangle, spiral numbers)
- Allow custom characters instead of just stars
- Add color to patterns using `Console.ForegroundColor`
- Save patterns to a text file
- Add animation (patterns appearing line by line with delays)