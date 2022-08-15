namespace MethodParameters.Tests
{
    public class MethodParametersTests
    {
        [Fact]
        public void CalculateYearlyWageWithBonusTest()
        {
            // Arrange
            int input = 1000;
            int expected = 13000;

            // Act
            int result = Utilities.CalculateYearlyWage(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void CalculateYearlyWageWithoutBonusTest()
        {
            // Arrange
            int input = 1000;
            int expected = 12000;

            // Act
            int result = Utilities.CalculateYearlyWage(input, false);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}