using System;
using System.IO;
using Xunit;

namespace OperatorsExercises.Tests
{
    public class OperatorsExerciseTests
    {
        private readonly string _basePath;

        public OperatorsExerciseTests()
        {
            // Find the project root by looking for the exercises folder
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
        public void GradeCalculator_Exercise_ShouldExist()
        {
            // Arrange
            string programPath = Path.Combine(_basePath, "exercises", "04-operators", "01-grade-calculator", "Program.cs");
            
            // Assert
            Assert.True(File.Exists(programPath), $"Exercise file should exist at {programPath}");
        }

        [Fact]
        public void GradeCalculator_Exercise_ShouldContainRequiredElements()
        {
            // Arrange
            string programPath = Path.Combine(_basePath, "exercises", "04-operators", "01-grade-calculator", "Program.cs");
            
            // Act
            string content = File.ReadAllText(programPath);
            
            // Assert
            Assert.Contains("using System", content);
            Assert.Contains("Console.WriteLine", content);
            Assert.Contains("TODO", content);
            Assert.Contains("operator", content.ToLower());
        }

        [Fact]
        public void NumberAnalyzer_Exercise_ShouldExist()
        {
            // Arrange
            string programPath = Path.Combine(_basePath, "exercises", "04-operators", "02-number-analyzer", "Program.cs");
            
            // Assert
            Assert.True(File.Exists(programPath), $"Exercise file should exist at {programPath}");
        }

        [Fact]
        public void NumberAnalyzer_Exercise_ShouldContainRequiredElements()
        {
            // Arrange
            string programPath = Path.Combine(_basePath, "exercises", "04-operators", "02-number-analyzer", "Program.cs");
            
            // Act
            string content = File.ReadAllText(programPath);
            
            // Assert
            Assert.Contains("using System", content);
            Assert.Contains("Console.WriteLine", content);
            Assert.Contains("TODO", content);
            Assert.Contains("comparison", content.ToLower());
        }

        [Fact]
        public void GradeCalculator_Solution_ShouldExist()
        {
            // Arrange
            string programPath = Path.Combine(_basePath, "solutions", "04-operators", "01-grade-calculator", "Program.cs");
            
            // Assert
            Assert.True(File.Exists(programPath), $"Solution file should exist at {programPath}");
        }

        [Fact]
        public void GradeCalculator_Solution_ShouldContainArithmeticOperators()
        {
            // Arrange
            string programPath = Path.Combine(_basePath, "solutions", "04-operators", "01-grade-calculator", "Program.cs");
            
            // Act
            string content = File.ReadAllText(programPath);
            
            // Assert
            Assert.Contains("+", content);
            Assert.Contains("/", content);
            Assert.Contains("percentage", content.ToLower());
            Assert.Contains("Console.WriteLine", content);
        }

        [Fact]
        public void NumberAnalyzer_Solution_ShouldExist()
        {
            // Arrange
            string programPath = Path.Combine(_basePath, "solutions", "04-operators", "02-number-analyzer", "Program.cs");
            
            // Assert
            Assert.True(File.Exists(programPath), $"Solution file should exist at {programPath}");
        }

        [Fact]
        public void NumberAnalyzer_Solution_ShouldContainComparisonOperators()
        {
            // Arrange
            string programPath = Path.Combine(_basePath, "solutions", "04-operators", "02-number-analyzer", "Program.cs");
            
            // Act
            string content = File.ReadAllText(programPath);
            
            // Assert
            Assert.Contains(">", content);
            Assert.Contains("<", content);
            Assert.Contains("==", content);
            Assert.Contains("Console.WriteLine", content);
        }

        [Theory]
        [InlineData("01-grade-calculator")]
        [InlineData("02-number-analyzer")]
        public void Exercise_ShouldHaveProjectFile(string exerciseName)
        {
            // Arrange
            string exercisePath = Path.Combine(_basePath, "exercises", "04-operators", exerciseName);
            
            // Act
            string[] csprojFiles = Directory.GetFiles(exercisePath, "*.csproj");
            
            // Assert
            Assert.Single(csprojFiles);
        }

        [Theory]
        [InlineData("01-grade-calculator")]
        [InlineData("02-number-analyzer")]
        public void Solution_ShouldHaveProjectFile(string exerciseName)
        {
            // Arrange
            string solutionPath = Path.Combine(_basePath, "solutions", "04-operators", exerciseName);
            
            // Act
            string[] csprojFiles = Directory.GetFiles(solutionPath, "*.csproj");
            
            // Assert
            Assert.Single(csprojFiles);
        }
    }
}