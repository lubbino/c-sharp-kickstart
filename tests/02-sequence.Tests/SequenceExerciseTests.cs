using System;
using System.IO;
using Xunit;

namespace SequenceExercises.Tests
{
    public class SequenceExerciseTests
    {
        private readonly string _basePath;

        public SequenceExerciseTests()
        {
            // Find the project root by looking for the .git directory or specific marker files
            string currentDir = Directory.GetCurrentDirectory();
            string searchDir = currentDir;
            
            // Navigate up until we find the project root (contains exercises and solutions folders)
            while (searchDir != null && !Directory.Exists(Path.Combine(searchDir, "exercises")))
            {
                string? parentDir = Directory.GetParent(searchDir)?.FullName;
                if (parentDir == null || parentDir == searchDir)
                {
                    break; // Reached root
                }
                searchDir = parentDir;
            }
            
            _basePath = searchDir ?? throw new DirectoryNotFoundException("Could not find project root containing exercises folder");
        }

        [Fact]
        public void SimpleCalculator_Exercise_ShouldExist()
        {
            // Arrange
            string programPath = Path.Combine(_basePath, "exercises", "02-sequence", "01-simple-calculator", "Program.cs");
            
            // Assert
            Assert.True(File.Exists(programPath), $"Exercise file should exist at {programPath}");
        }

        [Fact]
        public void SimpleCalculator_Exercise_ShouldContainRequiredElements()
        {
            // Arrange
            string programPath = Path.Combine(_basePath, "exercises", "02-sequence", "01-simple-calculator", "Program.cs");
            
            // Act
            string content = File.ReadAllText(programPath);
            
            // Assert
            Assert.Contains("using System", content);
            Assert.Contains("Console.WriteLine", content);
            Assert.Contains("TODO", content);
            Assert.Contains("arithmetic", content.ToLower());
        }

        [Fact]
        public void OrderOfOperations_Exercise_ShouldExist()
        {
            // Arrange
            string programPath = Path.Combine(_basePath, "exercises", "02-sequence", "02-order-of-operations", "Program.cs");
            
            // Assert
            Assert.True(File.Exists(programPath), $"Exercise file should exist at {programPath}");
        }

        [Fact]
        public void OrderOfOperations_Exercise_ShouldContainRequiredElements()
        {
            // Arrange
            string programPath = Path.Combine(_basePath, "exercises", "02-sequence", "02-order-of-operations", "Program.cs");
            
            // Act
            string content = File.ReadAllText(programPath);
            
            // Assert
            Assert.Contains("using System", content);
            Assert.Contains("Console.WriteLine", content);
            Assert.Contains("parentheses", content.ToLower());
            Assert.Contains("TODO", content);
        }

        [Fact]
        public void SimpleCalculator_Solution_ShouldExist()
        {
            // Arrange
            string programPath = Path.Combine(_basePath, "solutions", "02-sequence", "01-simple-calculator", "Program.cs");
            
            // Assert
            Assert.True(File.Exists(programPath), $"Solution file should exist at {programPath}");
        }

        [Fact]
        public void SimpleCalculator_Solution_ShouldContainArithmeticOperations()
        {
            // Arrange
            string programPath = Path.Combine(_basePath, "solutions", "02-sequence", "01-simple-calculator", "Program.cs");
            
            // Act
            string content = File.ReadAllText(programPath);
            
            // Assert
            Assert.Contains("+", content);
            Assert.Contains("-", content);
            Assert.Contains("*", content);
            Assert.Contains("/", content);
            Assert.Contains("Console.WriteLine", content);
        }

        [Fact]
        public void OrderOfOperations_Solution_ShouldExist()
        {
            // Arrange
            string programPath = Path.Combine(_basePath, "solutions", "02-sequence", "02-order-of-operations", "Program.cs");
            
            // Assert
            Assert.True(File.Exists(programPath), $"Solution file should exist at {programPath}");
        }

        [Fact]
        public void OrderOfOperations_Solution_ShouldDemonstrateParentheses()
        {
            // Arrange
            string programPath = Path.Combine(_basePath, "solutions", "02-sequence", "02-order-of-operations", "Program.cs");
            
            // Act
            string content = File.ReadAllText(programPath);
            
            // Assert
            Assert.Contains("(", content);
            Assert.Contains(")", content);
            Assert.Contains("Without parentheses", content);
            Assert.Contains("With parentheses", content);
        }

        [Theory]
        [InlineData("01-simple-calculator")]
        [InlineData("02-order-of-operations")]
        public void Exercise_ShouldHaveProjectFile(string exerciseName)
        {
            // Arrange
            string exercisePath = Path.Combine(_basePath, "exercises", "02-sequence", exerciseName);
            
            // Act
            string[] csprojFiles = Directory.GetFiles(exercisePath, "*.csproj");
            
            // Assert
            Assert.Single(csprojFiles);
        }

        [Theory]
        [InlineData("01-simple-calculator")]
        [InlineData("02-order-of-operations")]
        public void Solution_ShouldHaveProjectFile(string exerciseName)
        {
            // Arrange
            string solutionPath = Path.Combine(_basePath, "solutions", "02-sequence", exerciseName);
            
            // Act
            string[] csprojFiles = Directory.GetFiles(solutionPath, "*.csproj");
            
            // Assert
            Assert.Single(csprojFiles);
        }
    }
}