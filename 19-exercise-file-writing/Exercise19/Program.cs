
Vehicle v1 = new Vehicle(10, "BMW", "Red");
Vehicle v2 = new Vehicle(45, "Toyota", "Blue");
Vehicle v3 = new Vehicle(987, "Renault", "Black");
Vehicle v4 = new Vehicle(45643, "Volkswagen", "Green");
Vehicle v5 = new Vehicle(0, "Fiat", "Red");

List<Vehicle> vehicles = new List<Vehicle>();
vehicles.Add(v1);
vehicles.Add(v2);
vehicles.Add(v3);
vehicles.Add(v4);
vehicles.Add(v5);

Utilities.WriteVehicles(vehicles);

foreach (var item in vehicles)
{
    Console.WriteLine(item.DisplayVehicleDetails());
}

Console.ReadLine();