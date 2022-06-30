using Xunit;


public class EmployeeTests
{
    [Fact]
    public void Drive_Adds_Miles()
    {
        Vehicle vehicle = new Vehicle(10, "BMW", "Black");

        vehicle.CurrentMileage = 0;

        vehicle.Drive();


    }
}