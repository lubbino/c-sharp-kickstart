using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentGradeManager
{
    class Grade
    {
        public string Subject { get; set; }
        public double Score { get; set; }
        public DateTime DateAdded { get; set; }

        public Grade(string subject, double score)
        {
            Subject = subject;
            Score = score;
            DateAdded = DateTime.Now;
        }
    }

    class Student
    {
        public string Name { get; set; }
        public List<Grade> Grades { get; set; }

        public Student(string name)
        {
            Name = name;
            Grades = new List<Grade>();
        }

        public double Average => Grades.Count > 0 ? Grades.Average(g => g.Score) : 0;
    }

    class Program
    {
        static List<Student> students = new List<Student>();
        static string[] gradeLetters = { "A", "B", "C", "D", "F" };
        static double[] gradeThresholds = { 90, 80, 70, 60, 0 };

        static void Main(string[] args)
        {
            Console.WriteLine("=== Student Grade Manager ===");
            Console.WriteLine();

            bool continueRunning = true;

            while (continueRunning)
            {
                DisplayMainMenu();
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddNewStudent();
                        break;

                    case "2":
                        AddGradeToStudent();
                        break;

                    case "3":
                        ViewAllStudents();
                        break;

                    case "4":
                        ViewStudentDetails();
                        break;

                    case "5":
                        CalculateClassStatistics();
                        break;

                    case "6":
                        FindTopPerformers();
                        break;

                    case "7":
                        SearchStudents();
                        break;

                    case "8":
                        RemoveStudent();
                        break;

                    case "9":
                        ExportGradeReport();
                        break;

                    case "10":
                        continueRunning = false;
                        Console.WriteLine("Thank you for using Student Grade Manager!");
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please choose 1-10.");
                        break;
                }

                Console.WriteLine();
            }
        }

        static void DisplayMainMenu()
        {
            Console.WriteLine($"Current Students: {students.Count}");
            Console.WriteLine();
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Add New Student");
            Console.WriteLine("2. Add Grade to Student");
            Console.WriteLine("3. View All Students");
            Console.WriteLine("4. View Student Details");
            Console.WriteLine("5. Calculate Class Statistics");
            Console.WriteLine("6. Find Top Performers");
            Console.WriteLine("7. Search Students");
            Console.WriteLine("8. Remove Student");
            Console.WriteLine("9. Export Grade Report");
            Console.WriteLine("10. Exit");
            Console.WriteLine();
            Console.Write("Choose an option (1-10): ");
        }

        // TODO: Implement all menu functions
        static void AddNewStudent()
        {
            Console.WriteLine("Add New Student - Not implemented yet");
            // TODO: Ask for student name, validate, add to list
        }

        static void AddGradeToStudent()
        {
            Console.WriteLine("Add Grade to Student - Not implemented yet");
            // TODO: Show student list, select student, add grade
        }

        static void ViewAllStudents()
        {
            Console.WriteLine("View All Students - Not implemented yet");
            // TODO: Display all students with basic info
        }

        static void ViewStudentDetails()
        {
            Console.WriteLine("View Student Details - Not implemented yet");
            // TODO: Show detailed info for selected student
        }

        static void CalculateClassStatistics()
        {
            Console.WriteLine("Calculate Class Statistics - Not implemented yet");
            // TODO: Calculate and display class-wide statistics
        }

        static void FindTopPerformers()
        {
            Console.WriteLine("Find Top Performers - Not implemented yet");
            // TODO: Find and display top students
        }

        static void SearchStudents()
        {
            Console.WriteLine("Search Students - Not implemented yet");
            // TODO: Search students by name
        }

        static void RemoveStudent()
        {
            Console.WriteLine("Remove Student - Not implemented yet");
            // TODO: Select and remove student with confirmation
        }

        static void ExportGradeReport()
        {
            Console.WriteLine("Export Grade Report - Not implemented yet");
            // TODO: Generate and display comprehensive report
        }

        // TODO: Add helper functions
        // static string GetGradeLetter(double score)
        // static void DisplayGradeDistribution()
        // static Student FindStudentByName(string name)
    }
}