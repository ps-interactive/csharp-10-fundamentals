using Xunit;

namespace Vehicle.Tests
{
    public class VehicleTests
    {
        [Fact]
        public void CreateAndUseVehicle_ShouldReturnARedBMWWithMileage110()
        {
            // Act
            var vehicle = Utilities.CreateAndUseVehicle();

            // Assert
            Assert.NotNull(vehicle);
            Assert.Equal("BMW", vehicle.model);
            Assert.Equal("Red", vehicle.color);
            Assert.Equal(110, vehicle.currentMileage);
            Assert.Equal("Model: BMW - Color: Red - Current mileage: 110",vehicle.DisplayVehicleDetails());
        }
    }
}