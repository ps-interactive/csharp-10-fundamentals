﻿string fileName = "vehicles.txt";

string path = Path.Combine(Environment.CurrentDirectory, fileName);

string[] vehicles = File.ReadAllLines(path);
