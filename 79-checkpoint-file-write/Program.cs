string fileName = "vehicles.txt";

string path = Path.Combine(Environment.CurrentDirectory, fileName);

string vehicles = "BMW\nToyota\nMercedes";

File.WriteAllText(path, vehicles);
