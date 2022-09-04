
List<Vehicle> vehicles = Utilities.ReadVehicles("vehicles.txt");

foreach (Vehicle vehicle in vehicles)
{
    Console.WriteLine(vehicle.DisplayVehicleDetails());
}

Console.ReadLine();