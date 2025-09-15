using System;
using System.IO;
using Xunit;

namespace IntroExercises.Tests
{
    public class IntroExerciseTests
    {
        private readonly string _basePath;

        public IntroExerciseTests()
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
        public void HelloWorld_Exercise_ShouldExist()
        {
            // Arrange
            string programPath = Path.Combine(_basePath, "exercises", "01-intro", "01-hello-world", "Program.cs");
            
            // Assert
            Assert.True(File.Exists(programPath), $"Exercise file should exist at {programPath}");
        }

        [Fact]
        public void HelloWorld_Exercise_ShouldContainRequiredElements()
        {
            // Arrange
            string programPath = Path.Combine(_basePath, "exercises", "01-intro", "01-hello-world", "Program.cs");
            
            // Act
            string content = File.ReadAllText(programPath);
            
            // Assert
            Assert.Contains("using System", content);
            Assert.Contains("Console.WriteLine", content);
            Assert.Contains("Hello", content);
        }

        [Fact]
        public void MultipleOutputs_Exercise_ShouldExist()
        {
            // Arrange
            string programPath = Path.Combine(_basePath, "exercises", "01-intro", "02-multiple-outputs", "Program.cs");
            
            // Assert
            Assert.True(File.Exists(programPath), $"Exercise file should exist at {programPath}");
        }

        [Fact]
        public void MultipleOutputs_Exercise_ShouldContainRequiredElements()
        {
            // Arrange
            string programPath = Path.Combine(_basePath, "exercises", "01-intro", "02-multiple-outputs", "Program.cs");
            
            // Act
            string content = File.ReadAllText(programPath);
            
            // Assert
            Assert.Contains("using System", content);
            Assert.Contains("Console.WriteLine", content);
            Assert.Contains("TODO", content);
        }

        [Fact]
        public void CommentsAndCode_Exercise_ShouldExist()
        {
            // Arrange
            string programPath = Path.Combine(_basePath, "exercises", "01-intro", "03-comments-and-code", "Program.cs");
            
            // Assert
            Assert.True(File.Exists(programPath), $"Exercise file should exist at {programPath}");
        }

        [Fact]
        public void CommentsAndCode_Exercise_ShouldContainRequiredElements()
        {
            // Arrange
            string programPath = Path.Combine(_basePath, "exercises", "01-intro", "03-comments-and-code", "Program.cs");
            
            // Act
            string content = File.ReadAllText(programPath);
            
            // Assert
            Assert.Contains("using System", content);
            Assert.Contains("Console.WriteLine", content);
            Assert.Contains("//", content); // Should contain comments
            Assert.Contains("TODO", content);
        }

        [Fact]
        public void HelloWorld_Solution_ShouldExist()
        {
            // Arrange
            string programPath = Path.Combine(_basePath, "solutions", "01-intro", "01-hello-world", "Program.cs");
            
            // Assert
            Assert.True(File.Exists(programPath), $"Solution file should exist at {programPath}");
        }

        [Fact]
        public void HelloWorld_Solution_ShouldContainCorrectOutput()
        {
            // Arrange
            string programPath = Path.Combine(_basePath, "solutions", "01-intro", "01-hello-world", "Program.cs");
            
            // Act
            string content = File.ReadAllText(programPath);
            
            // Assert
            Assert.Contains("Hello, World!", content);
            Assert.Contains("Console.WriteLine", content);
        }

        [Theory]
        [InlineData("01-hello-world")]
        [InlineData("02-multiple-outputs")]
        [InlineData("03-comments-and-code")]
        public void Exercise_ShouldHaveProjectFile(string exerciseName)
        {
            // Arrange
            string exercisePath = Path.Combine(_basePath, "exercises", "01-intro", exerciseName);
            
            // Act
            string[] csprojFiles = Directory.GetFiles(exercisePath, "*.csproj");
            
            // Assert
            Assert.Single(csprojFiles);
        }

        [Theory]
        [InlineData("01-hello-world")]
        [InlineData("02-multiple-outputs")]
        [InlineData("03-comments-and-code")]
        public void Solution_ShouldHaveProjectFile(string exerciseName)
        {
            // Arrange
            string solutionPath = Path.Combine(_basePath, "solutions", "01-intro", exerciseName);
            
            // Act
            string[] csprojFiles = Directory.GetFiles(solutionPath, "*.csproj");
            
            // Assert
            Assert.Single(csprojFiles);
        }
    }
}