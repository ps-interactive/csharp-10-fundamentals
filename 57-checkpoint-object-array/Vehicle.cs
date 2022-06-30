public class Vehicle
{
    public int currentMileage;
    public string model;
    public string color;

    public Vehicle()
    {
    }

    public Vehicle(int currentMileage, string model, string color)
    {
        this.currentMileage = currentMileage;
        this.model = model;
        this.color = color;
    }

    public void Drive()
    {
        currentMileage++;
    }

    public void Drive(int miles)
    {
        if (miles > 0)
            currentMileage += miles;
    }

    public string DisplayVehicleDetails()
    {
        return $"Model: {model} - Color: {color} - Current mileage: {currentMileage}";
    }
}
