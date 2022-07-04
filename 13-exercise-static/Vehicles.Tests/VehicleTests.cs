using Xunit;

namespace Vehicles.Tests
{
    public class VehicleTests
    {
        [Fact]
        public void GivenVehicleIncreasMaxSpeedIsCalled_ThenTheMaxSpeedIsIncreasedByTheInput()
        {
            // Arrange
            int initialMaxSpeed = 100;
            int expectedMaxSpeed = 120;

            // Act + Assert
            Vehicle.maxSpeed = 100;
            Assert.Equal(initialMaxSpeed, Vehicle.maxSpeed);
            Vehicle.IncreaseMaxSpeed(20);

            Assert.Equal(expectedMaxSpeed, Vehicle.maxSpeed);
        }

        [Fact]
        public void GivenUtilitiesChangeMaxSpeedIsCalled_ThenTheNewMaxSpeedIsReturned()
        {
            // Arrange
            int expectedMaxSpeed = 110;

            // Act 
            var result = Utilities.ChangeMaxSpeed();

            Assert.Equal(expectedMaxSpeed, result);
        }
    }
}