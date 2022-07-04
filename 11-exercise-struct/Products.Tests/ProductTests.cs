using Xunit;

namespace Products.Tests
{
    public class ProductTests
    {
        [Fact]
        public void GetSalePrice_ShouldReturnCalculatedSalePrice()
        {
            // Arrange
            double expectedPrice = 1.4625;

            // Act
            double salePrice = Utilities.GetSalePrice();

            // Assert
            Assert.Equal(expectedPrice, salePrice);
        }
    }
}