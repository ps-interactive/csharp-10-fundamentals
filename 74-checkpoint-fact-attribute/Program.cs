using Xunit;

public class VehicleTests
{
    public void Drive_Adds_Miles()
    {
        Vehicle vehicle = new Vehicle(10, "BMW", "Black");

        vehicle.Drive();

        
    }
}