# Exercise 10-02: Refactoring

## Background

Refactoring is the process of improving code structure and quality without changing its functionality. This exercise presents a working Student Grade Management System that needs significant structural improvements to make it more maintainable, readable, and extensible.

## Instructions

Analyze the code in [`Program.cs`](Program.cs) and refactor it to follow best practices. The current code works correctly but has poor structure that makes it difficult to maintain and extend.

## Current Code Issues

The provided Student Grade Management System has several structural problems:

### 1. Monolithic Main Method
- **Problem**: The entire program logic is crammed into `Main()`
- **Impact**: Difficult to test, understand, and modify individual features
- **Solution**: Extract methods for each major operation

### 2. Code Duplication
- **Problem**: Average calculation logic is repeated throughout
- **Impact**: Changes require updates in multiple places, increasing error risk
- **Solution**: Create reusable methods for common operations

### 3. Poor Data Organization
- **Problem**: Student data is stored in separate parallel lists
- **Impact**: Data can become inconsistent, hard to manage
- **Solution**: Create a Student class to encapsulate related data

### 4. Lack of Input Validation
- **Problem**: No validation of user input (grades, menu choices)
- **Impact**: Program can crash or behave unexpectedly with invalid input
- **Solution**: Add comprehensive input validation

### 5. Mixed Concerns
- **Problem**: Data processing and display logic are intertwined
- **Impact**: Difficult to change output format or add new features
- **Solution**: Separate data processing from presentation

### 6. Magic Numbers
- **Problem**: Hard-coded values like grade boundaries (90, 80, 70, 60)
- **Impact**: Difficult to modify grading scale
- **Solution**: Use named constants

## Refactoring Tasks

### Task 1: Extract Methods
Break the monolithic `Main()` method into focused methods:

```csharp
// Input methods
static int GetNumberOfStudents();
static string GetStudentName(int studentNumber);
static double GetGradeForSubject(string studentName, string subject);
static List<Student> InputAllStudentData();

// Processing methods
static double CalculateStudentAverage(Student student);
static double CalculateSubjectAverage(List<Student> students, int subjectIndex);
static double CalculateOverallAverage(List<Student> students);
static Student FindTopStudent(List<Student> students);

// Display methods
static void DisplayMenu();
static int GetMenuChoice();
static void DisplayAllStudents(List<Student> students);
static void DisplayStudentAverages(List<Student> students);
static void DisplaySubjectAverages(List<Student> students);
static void DisplayGradeDistribution(List<Student> students);
```

### Task 2: Create Student Data Structure
Replace parallel lists with a proper data structure:

```csharp
public class Student
{
    public string Name { get; set; }
    public List<double> Grades { get; set; }
    
    public Student(string name)
    {
        Name = name;
        Grades = new List<double>();
    }
    
    // Methods
    public double CalculateAverage()
    {
        return Grades.Count > 0 ? Grades.Average() : 0.0;
    }
    
    public char GetLetterGrade()
    {
        double average = CalculateAverage();
        if (average >= GradeThresholds.A) return 'A';
        if (average >= GradeThresholds.B) return 'B';
        if (average >= GradeThresholds.C) return 'C';
        if (average >= GradeThresholds.D) return 'D';
        return 'F';
    }
    
    public bool IsPassingAllSubjects()
    {
        return Grades.All(grade => grade >= GradeThresholds.Passing);
    }
}
```

### Task 3: Create Grade Manager Class
Organize functionality into a cohesive class:

```csharp
public class GradeManager
{
    private List<Student> students;
    private readonly string[] subjects;
    
    public GradeManager()
    {
        students = new List<Student>();
        subjects = new[] { "Math", "Science", "English", "History" };
    }
    
    public void Run()
    {
        InputStudentData();
        
        while (true)
        {
            DisplayMenu();
            int choice = GetMenuChoice();
            
            switch (choice)
            {
                case 1: DisplayAllStudents(); break;
                case 2: DisplayStudentAverages(); break;
                case 3: DisplaySubjectAverages(); break;
                case 4: DisplayTopStudent(); break;
                case 5: DisplayStudentsBelowAverage(); break;
                case 6: DisplayGradeDistribution(); break;
                case 7: return;
                default: Console.WriteLine("Invalid choice. Please try again."); break;
            }
            
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
    }
    
    // Private methods for implementation...
}
```

### Task 4: Add Input Validation
Implement robust input validation:

```csharp
// Validate number of students (1-100)
private static int GetValidNumberOfStudents()
{
    while (true)
    {
        Console.Write("Enter number of students (1-100): ");
        if (int.TryParse(Console.ReadLine(), out int count) && 
            count >= 1 && count <= 100)
        {
            return count;
        }
        Console.WriteLine("Please enter a valid number between 1 and 100.");
    }
}

// Validate grade (0.0-100.0)
private static double GetValidGrade(string prompt)
{
    while (true)
    {
        Console.Write(prompt);
        if (double.TryParse(Console.ReadLine(), out double grade) && 
            grade >= 0.0 && grade <= 100.0)
        {
            return grade;
        }
        Console.WriteLine("Please enter a valid grade between 0.0 and 100.0.");
    }
}

// Validate menu choice (1-7)
private static int GetValidMenuChoice()
{
    while (true)
    {
        Console.Write("Enter your choice (1-7): ");
        if (int.TryParse(Console.ReadLine(), out int choice) && 
            choice >= 1 && choice <= 7)
        {
            return choice;
        }
        Console.WriteLine("Please enter a valid choice between 1 and 7.");
    }
}
```

### Task 5: Add Constants and Configuration
Replace magic numbers with named constants:

```csharp
public static class GradeThresholds
{
    public const double A = 90.0;
    public const double B = 80.0;
    public const double C = 70.0;
    public const double D = 60.0;
    public const double Passing = 60.0;
}

public static class SystemLimits
{
    public const int MinStudents = 1;
    public const int MaxStudents = 100;
    public const double MinGrade = 0.0;
    public const double MaxGrade = 100.0;
}

public static class MenuOptions
{
    public const int DisplayAll = 1;
    public const int StudentAverages = 2;
    public const int SubjectAverages = 3;
    public const int TopStudent = 4;
    public const int BelowAverage = 5;
    public const int GradeDistribution = 6;
    public const int Exit = 7;
}
```

### Task 6: Improve Error Handling
Add comprehensive error handling:

```csharp
public static void Main(string[] args)
{
    try
    {
        var manager = new GradeManager();
        manager.Run();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        Console.WriteLine("Please restart the application.");
    }
}
```

## Expected Functionality

Your refactored code should maintain all original functionality:

1. **Student Input**: Collect student names and grades for all subjects
2. **Display All Students**: Show formatted table with all student data
3. **Student Averages**: Display each student's average grade
4. **Subject Averages**: Display average grade for each subject
5. **Top Student**: Find and display the student with highest average
6. **Below Average Students**: Find students below the overall average
7. **Grade Distribution**: Show count of A, B, C, D, F grades
8. **Menu System**: Interactive menu for accessing all features

## Sample Refactored Structure

```csharp
using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentGradeManager
{
    /// <summary>
    /// Main program entry point for the Student Grade Management System.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Application entry point.
        /// </summary>
        public static void Main(string[] args)
        {
            try
            {
                var manager = new GradeManager();
                manager.Run();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
        }
    }

    /// <summary>
    /// Represents a student with their grades.
    /// </summary>
    public class Student
    {
        // Implementation as outlined above
    }

    /// <summary>
    /// Manages student grade data and provides analysis functionality.
    /// </summary>
    public class GradeManager
    {
        // Implementation as outlined above
    }

    /// <summary>
    /// Contains grade threshold constants.
    /// </summary>
    public static class GradeThresholds
    {
        // Constants as outlined above
    }
}
```

## Compilation and Testing

Compile and test your refactored code:

```bash
# From the c-sharp-kickstart directory
cd exercises/10-code-quality/refactoring
dotnet run
```

Test thoroughly:
- Valid input scenarios
- Invalid input handling (negative grades, invalid menu choices)
- Edge cases (single student, all same grades)
- Large datasets (many students)

## Evaluation Criteria

Your refactored code will be evaluated on:

### Structure and Organization (35%)
- **Method Extraction**: Logical breakdown of functionality
- **Class Design**: Appropriate use of classes and data encapsulation
- **Separation of Concerns**: Clear distinction between input, processing, and output
- **Code Reusability**: Elimination of duplication

### Code Quality (25%)
- **Naming**: Clear, descriptive names for all entities
- **Constants**: Proper use of named constants instead of magic numbers
- **Formatting**: Consistent, professional code formatting
- **Comments**: Appropriate XML documentation without over-commenting

### Error Handling (20%)
- **Input Validation**: Robust handling of invalid user input
- **Edge Cases**: Proper handling of boundary conditions
- **Error Messages**: Clear, helpful error reporting
- **Exception Safety**: Proper use of exceptions where appropriate

### Maintainability (20%)
- **Modularity**: Easy to modify individual features
- **Extensibility**: Easy to add new features (subjects, grade scales)
- **Testability**: Methods can be easily unit tested
- **Readability**: Code is self-documenting and easy to understand

## Learning Goals

This exercise develops:
- **Refactoring skills**: Systematically improving code structure
- **Design patterns**: Understanding when and how to extract methods and classes
- **Code organization**: Creating maintainable, professional code structure
- **Error handling**: Building robust applications that handle edge cases
- **Object-oriented thinking**: Using classes to model real-world entities

## Common Refactoring Patterns

### Extract Method
```csharp
// Before: Repeated calculation
double sum1 = 0;
foreach (double grade in student1.Grades) sum1 += grade;
double avg1 = sum1 / student1.Grades.Count;

double sum2 = 0;
foreach (double grade in student2.Grades) sum2 += grade;
double avg2 = sum2 / student2.Grades.Count;

// After: Extracted method
private static double CalculateAverage(List<double> grades)
{
    return grades.Count > 0 ? grades.Average() : 0.0;
}

double avg1 = CalculateAverage(student1.Grades);
double avg2 = CalculateAverage(student2.Grades);
```

### Replace Data Clumps with Objects
```csharp
// Before: Related data in separate containers
List<string> names = new List<string>();
List<List<double>> grades = new List<List<double>>();

// After: Encapsulated in object
public class Student
{
    public string Name { get; set; }
    public List<double> Grades { get; set; }
    // methods...
}
List<Student> students = new List<Student>();
```

### Replace Magic Numbers with Constants
```csharp
// Before: Magic numbers
if (average >= 90) return 'A';
else if (average >= 80) return 'B';

// After: Named constants
public static class GradeThresholds
{
    public const double A = 90.0;
    public const double B = 80.0;
}

if (average >= GradeThresholds.A) return 'A';
else if (average >= GradeThresholds.B) return 'B';
```

## Next Steps

After completing this refactoring:
1. Compare the before and after versions
2. Identify which changes had the biggest impact on maintainability
3. Consider how you would add new features (new subjects, different grading scales)
4. Think about how the refactored structure makes testing easier

This exercise prepares you for real-world software maintenance and helps develop the skills needed to work with legacy codebases.