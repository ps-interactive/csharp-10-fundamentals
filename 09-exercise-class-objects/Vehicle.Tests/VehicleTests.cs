using Xunit;

namespace Vehicles.Tests
{
    public class VehicleTests
    {
        [Fact]
        [Trait("Category", "Task2")]
        public void VehicleDefaultConstructorTest()
        {
            // Act
            var vehicle = new Vehicle();

            // Assert
            Assert.NotNull(vehicle);
            Assert.Equal("BMW", vehicle.model);
            Assert.Equal("Red", vehicle.color);
            Assert.Equal(110, vehicle.currentMileage);
        }

        [Fact]
        [Trait("Category", "Task2")]
        public void VehicleConstructorTest()
        {
            // Act
            string model = "BMW";
            string color = "Red";
            int currentMileage = 110;

            var vehicle = new Vehicle(currentMileage, model, color);

            // Assert
            Assert.NotNull(vehicle);
            Assert.Equal("BMW", vehicle.model);
            Assert.Equal("Red", vehicle.color);
            Assert.Equal(110, vehicle.currentMileage);
        }

        [Fact]
        [Trait("Category", "Task3")]
        public void DriveTest()
        {
            // Act
            string model = "BMW";
            string color = "Red";
            int currentMileage = 110;

            var vehicle = new Vehicle(currentMileage, model, color);
            Assert.NotNull(vehicle);
            Assert.Equal(110, vehicle.currentMileage);

            vehicle.Drive();
            Assert.Equal(111, vehicle.currentMileage);
        }

        [Fact]
        [Trait("Category", "Task3")]
        public void DriveWithMileageTest()
        {
            // Act
            string model = "BMW";
            string color = "Red";
            int currentMileage = 110;

            var vehicle = new Vehicle(currentMileage, model, color);
            Assert.NotNull(vehicle);
            Assert.Equal(110, vehicle.currentMileage);

            vehicle.Drive(10);
            Assert.Equal(120, vehicle.currentMileage);
        }

        [Fact]
        [Trait("Category", "Task3")]
        public void DisplayVehicleDetailsTest()
        {
            // Act
            string model = "BMW";
            string color = "Red";
            int currentMileage = 110;

            var vehicle = new Vehicle(currentMileage, model, color);

            //Assert
            Assert.NotNull(vehicle);
            Assert.Equal("Model: BMW - Color: Red - Current mileage: 110", vehicle.DisplayVehicleDetails());
        }

        [Fact]
        [Trait("Category", "Task4")]
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