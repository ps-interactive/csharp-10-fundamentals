using Xunit;

namespace Arrays.Tests
{
    public class ArrayTests
    {
        [Fact]
        public void CalculateSumOfArrayElements_ShouldReturnTheSumOfTheElementsInTHeArray()
        {
            // Arrange
            int[] myValues = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int expectedValue = 55;

            // Act
            int sum = Utilities.CalculateSumOfArrayElements(myValues);

            // Assert
            Assert.Equal(expectedValue, sum);
        }
    }
}