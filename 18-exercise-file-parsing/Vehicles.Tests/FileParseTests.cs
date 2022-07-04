using System.Collections.Generic;
using Xunit;

namespace Vehicles.Tests
{
    public class FileParseTests
    {
        [Fact]
        public void GivenReadVehiclesIsCalled_WhenTheFileDoesntExists_AEmptyListOfVehiclesIsReturned()
        {
            // Arrange

            // Act
            List<Vehicle> vehicles = Utilities.ReadVehicles("cars.txt");

            // Assert
            Assert.NotNull(vehicles);
            Assert.Empty(vehicles);
        }

        [Fact]
        public void GivenReadVehiclesIsCalled_WhenTheFileExists_TheListOfVehiclesIsReturned()
        {
            // Arrange

            // Act
            List<Vehicle> vehicles = Utilities.ReadVehicles("vehicles.txt");

            // Assert
            Assert.NotNull(vehicles);
            Assert.Equal(3, vehicles.Count);

            Assert.Equal("BMW", vehicles[0].Model);
            Assert.Equal("Black", vehicles[0].Color);
            Assert.Equal(10, vehicles[0].CurrentMileage);

            Assert.Equal("Toyota", vehicles[1].Model);
            Assert.Equal("Red", vehicles[1].Color);
            Assert.Equal(455, vehicles[1].CurrentMileage);

            Assert.Equal("Mercedes", vehicles[2].Model);
            Assert.Equal("Green", vehicles[2].Color);
            Assert.Equal(1000, vehicles[2].CurrentMileage);
        }
    }
}