using System;
using System.IO;
using Xunit;

namespace IterationsExercises.Tests
{
    public class IterationsExerciseTests
    {
        private readonly string _basePath;

        public IterationsExerciseTests()
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
        public void MultiplicationTable_Exercise_ShouldExist()
        {
            // Arrange
            string programPath = Path.Combine(_basePath, "exercises", "07-iterations", "01-multiplication-table", "Program.cs");
            
            // Assert
            Assert.True(File.Exists(programPath), $"Exercise file should exist at {programPath}");
        }

        [Fact]
        public void MultiplicationTable_Exercise_ShouldContainRequiredElements()
        {
            // Arrange
            string programPath = Path.Combine(_basePath, "exercises", "07-iterations", "01-multiplication-table", "Program.cs");
            
            // Act
            string content = File.ReadAllText(programPath);
            
            // Assert
            Assert.Contains("using System", content);
            Assert.Contains("Console.WriteLine", content);
            Assert.Contains("TODO", content);
            Assert.Contains("for", content);
        }

        [Fact]
        public void NumberAccumulator_Exercise_ShouldExist()
        {
            // Arrange
            string programPath = Path.Combine(_basePath, "exercises", "07-iterations", "02-number-accumulator", "Program.cs");
            
            // Assert
            Assert.True(File.Exists(programPath), $"Exercise file should exist at {programPath}");
        }

        [Fact]
        public void NumberAccumulator_Exercise_ShouldContainRequiredElements()
        {
            // Arrange
            string programPath = Path.Combine(_basePath, "exercises", "07-iterations", "02-number-accumulator", "Program.cs");
            
            // Act
            string content = File.ReadAllText(programPath);
            
            // Assert
            Assert.Contains("using System", content);
            Assert.Contains("Console.WriteLine", content);
            Assert.Contains("TODO", content);
            Assert.Contains("while", content);
        }

        [Fact]
        public void MultiplicationTable_Solution_ShouldExist()
        {
            // Arrange
            string programPath = Path.Combine(_basePath, "solutions", "07-iterations", "01-multiplication-table", "Program.cs");
            
            // Assert
            Assert.True(File.Exists(programPath), $"Solution file should exist at {programPath}");
        }

        [Fact]
        public void MultiplicationTable_Solution_ShouldContainForLoop()
        {
            // Arrange
            string programPath = Path.Combine(_basePath, "solutions", "07-iterations", "01-multiplication-table", "Program.cs");
            
            // Act
            string content = File.ReadAllText(programPath);
            
            // Assert
            Assert.Contains("for", content);
            Assert.Contains("*", content);
            Assert.Contains("Console.WriteLine", content);
            Assert.Contains("multiplication", content.ToLower());
        }

        [Fact]
        public void NumberAccumulator_Solution_ShouldExist()
        {
            // Arrange
            string programPath = Path.Combine(_basePath, "solutions", "07-iterations", "02-number-accumulator", "Program.cs");
            
            // Assert
            Assert.True(File.Exists(programPath), $"Solution file should exist at {programPath}");
        }

        [Fact]
        public void NumberAccumulator_Solution_ShouldContainWhileLoop()
        {
            // Arrange
            string programPath = Path.Combine(_basePath, "solutions", "07-iterations", "02-number-accumulator", "Program.cs");
            
            // Act
            string content = File.ReadAllText(programPath);
            
            // Assert
            Assert.Contains("while", content);
            Assert.Contains("sum", content.ToLower());
            Assert.Contains("Console.WriteLine", content);
            Assert.Contains("Console.ReadLine", content);
        }

        [Theory]
        [InlineData("01-multiplication-table")]
        [InlineData("02-number-accumulator")]
        public void Exercise_ShouldHaveProjectFile(string exerciseName)
        {
            // Arrange
            string exercisePath = Path.Combine(_basePath, "exercises", "07-iterations", exerciseName);
            
            // Act
            string[] csprojFiles = Directory.GetFiles(exercisePath, "*.csproj");
            
            // Assert
            Assert.Single(csprojFiles);
        }

        [Theory]
        [InlineData("01-multiplication-table")]
        [InlineData("02-number-accumulator")]
        public void Solution_ShouldHaveProjectFile(string exerciseName)
        {
            // Arrange
            string solutionPath = Path.Combine(_basePath, "solutions", "07-iterations", exerciseName);
            
            // Act
            string[] csprojFiles = Directory.GetFiles(solutionPath, "*.csproj");
            
            // Assert
            Assert.Single(csprojFiles);
        }
    }
}