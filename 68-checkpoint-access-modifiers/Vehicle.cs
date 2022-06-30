public class Vehicle
{
    int currentMileage;
    string model;
    string color;

    public int CurrentMileage
    {
        get
        {
            return currentMileage;
        }
        set
        {
            currentMileage = value;
        }
    }

    public string Color
    {
        get
        {
            return color;
        }
        set
        {
            color = value;
        }
    }

    public string Model
    {
        get
        {
            return model;
        }
        set
        {
            model = value;
        }
    }

    public Vehicle(int currentMileage, string model, string color)
    {
        CurrentMileage = currentMileage;
        Model = model;
        Color = color;
    }

    void Drive()
    {
        CurrentMileage++;
    }

    void Drive(int miles)
    {
        if (miles > 0)
            CurrentMileage += miles;
    }

    string DisplayVehicleDetails()
    {
        return $"Model: {Model} - Color: {Color} - Current mileage: {CurrentMileage}";
    }
}