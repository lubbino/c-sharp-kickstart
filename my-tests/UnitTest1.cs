using Xunit;

namespace XUnitProject
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            int expected = 4;
            
            // Act
            int actual = 2 + 2;
            
            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(2, 3, 5)]
        [InlineData(-1, 1, 0)]
        public void AddNumbers_ShouldReturnCorrectSum(int a, int b, int expected)
        {
            // Arrange & Act
            int actual = a + b;
            
            // Assert
            Assert.Equal(expected, actual);
        }
    }
}