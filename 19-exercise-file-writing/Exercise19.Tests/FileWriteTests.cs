using System;
using System.Collections.Generic;
using System.IO;
using Xunit;

namespace Exercise19.Tests
{
    public class FileWriteTests
    {
        [Fact]
        public void Test_WriteVehicles()
        {
            string path = Path.Combine(Environment.CurrentDirectory, "vehicles.txt");

            // Prepare the data to write to the file
            Vehicle v1 = new Vehicle(10, "Ford", "Red");
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

            // Write to the file
            Utilities.WriteVehicles(vehicles);

            // The file should exist now
            Assert.True(File.Exists(path));

            // Read file
            List<Vehicle> vehiclesFromFileList = new List<Vehicle>();

            string[] vehiclesFromFile = File.ReadAllLines(path);
            for (int i = 0; i < vehiclesFromFile.Length; i++)
            {
                string[] vehicleSplits = vehiclesFromFile[i].Split(';');
                string model = vehicleSplits[0];
                string color = vehicleSplits[1];
                int currentMileage = int.Parse(vehicleSplits[2]);

                Vehicle v = new Vehicle(currentMileage, model, color);
                vehiclesFromFileList.Add(v);
            }

            // Assert that the data in the file is the data that is written to the file
            Assert.NotNull(vehiclesFromFileList);
            Assert.Equal(5, vehiclesFromFileList.Count);

            Assert.Equal("Ford", vehiclesFromFileList[0].Model);
            Assert.Equal("Red", vehiclesFromFileList[0].Color);
            Assert.Equal(10, vehiclesFromFileList[0].CurrentMileage);

            Assert.Equal("Toyota", vehiclesFromFileList[1].Model);
            Assert.Equal("Blue", vehiclesFromFileList[1].Color);
            Assert.Equal(45, vehiclesFromFileList[1].CurrentMileage);

            Assert.Equal("Renault", vehiclesFromFileList[2].Model);
            Assert.Equal("Black", vehiclesFromFileList[2].Color);
            Assert.Equal(987, vehiclesFromFileList[2].CurrentMileage);

            Assert.Equal("Volkswagen", vehiclesFromFileList[3].Model);
            Assert.Equal("Green", vehiclesFromFileList[3].Color);
            Assert.Equal(45643, vehiclesFromFileList[3].CurrentMileage);

            Assert.Equal("Fiat", vehiclesFromFileList[4].Model);
            Assert.Equal("Red", vehiclesFromFileList[4].Color);
            Assert.Equal(0, vehiclesFromFileList[4].CurrentMileage);
        }
    }
}