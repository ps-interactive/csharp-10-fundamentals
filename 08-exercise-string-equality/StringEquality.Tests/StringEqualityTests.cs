using Xunit;

namespace StringEquality.Tests
{
    public class StringEqualityTests
    {
        [Fact]
        public void CheckIfStringsAreEqual_WhenStringsAreEqual_ReturnsTrue()
        {
            // Arrange
            string a = "This is a string";
            string b = "This is a string";

            // Act
            var result = Utilities.CheckIfStringsAreEqual(a, b);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void CheckIfStringsAreEqual_WhenStringsAreNotEqual_ReturnsFalse()
        {
            // Arrange
            string a = "This is a string";
            string b = "This is another string";

            // Act
            var result = Utilities.CheckIfStringsAreEqual(a, b);

            // Assert
            Assert.False(result);
        }
    }
}