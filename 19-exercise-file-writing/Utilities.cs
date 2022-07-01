
using System.Text;

public class Utilities
{

    public static void WriteVehicles(List<Vehicle> vehicles)
    {
        string path = Path.Combine(Environment.CurrentDirectory, "vehicles.txt");
        StringBuilder sb = new StringBuilder();

        foreach (var vehicle in vehicles)
        {
            sb.Append(vehicle.Model + ";");
            sb.Append(vehicle.Color + ";");
            sb.Append(vehicle.CurrentMileage);
            sb.Append(Environment.NewLine);
        }

        File.WriteAllText(path, sb.ToString());
    }
}

