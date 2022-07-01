public class Utilities
{
    public static List<Vehicle> ReadVehicles(string fileName)
    {
        try
        {
            List<Vehicle> vehicleList = new List<Vehicle>();

            string path = Path.Combine(Environment.CurrentDirectory, fileName);

            if (File.Exists(path))
            {
                string[] vehicles = File.ReadAllLines(path);
                for (int i = 0; i < vehicles.Length; i++)
                {
                    string[] vehicleSplits = vehicles[i].Split(';');
                    string model = vehicleSplits[0];
                    string color = vehicleSplits[1];
                    int currentMileage = int.Parse(vehicleSplits[2]);

                    Vehicle v = new Vehicle(currentMileage, model, color);
                    vehicleList.Add(v);
                }
            }
            return vehicleList;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message + " " + ex.StackTrace);
            return null;
        }
    }
}

