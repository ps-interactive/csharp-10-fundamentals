using Xunit;

namespace RemoveVowels.Tests
{
    public class RemoveVowels_ShouldRemoveVowels
    {
        [Fact]
        public void RemoveVowelsTest()
        {
            // Arrange
            string input = "abcdefghijklmnopqrstuvwxyz";
            string expected = "bcdfghjklmnpqrstvwxz";

            // Act
            string result = Utilities.RemoveVowels(input);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}