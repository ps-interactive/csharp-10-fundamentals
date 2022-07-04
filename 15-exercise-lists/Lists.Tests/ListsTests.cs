using System.Collections.Generic;
using Xunit;

namespace Lists.Tests
{
    public class ListsTests
    {
        [Fact]
        public void GivenCalculateSumOfMilesDrivenIsCalled_ItReturnsTheSumOfAllCurrentMileages()
        {
            // Arrange
            List<Vehicle> vehicles = new List<Vehicle>
            {
                new Vehicle(1, "BMW", "Red"),
                new Vehicle(2, "BMW", "Red"),
                new Vehicle(3, "BMW", "Red"),
                new Vehicle(4, "BMW", "Red"),
                new Vehicle(5, "BMW", "Red"),
                new Vehicle(6, "BMW", "Red"),
                new Vehicle(7, "BMW", "Red"),
                new Vehicle(8, "BMW", "Red"),
                new Vehicle(9, "BMW", "Red"),
                new Vehicle(10, "BMW", "Red")
            };
            var expectedValue = 55;

            // Act
            int result = Utilities.CalculateSumOfMilesDriven(vehicles);

            // Assert
            Assert.Equal(expectedValue, result);
        }
    }
}