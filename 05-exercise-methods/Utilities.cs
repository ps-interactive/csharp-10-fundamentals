using Xunit;

namespace RemoveVowels.Tests
{
    public class RemoveVowelsTests
    {
        [Fact]
        public void RemoveVowel_SHouldRemoveVowels()
        {
            // Arrange
            var input = "abcdefghijklmnopqrstuvwxyz";

            // Act
            string result = Utilities.RemoveVowels(input);

            // Assert
            Assert.Equal("bcdfghjklmnpqrstvwxz", result);
        }
    }
}
