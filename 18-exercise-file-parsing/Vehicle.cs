public class Vehicle
{
    private int currentMileage;
    private string model;
    private string color;

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

    public void Drive()
    {
        CurrentMileage++;
    }

    public void Drive(int miles)
    {
        if (miles > 0)
            CurrentMileage += miles;
    }

    public string DisplayVehicleDetails()
    {
        return $"Model: {Model} - Color: {Color} - Current mileage: {CurrentMileage}";
    }

    protected void SoundHorn()
    {
        Console.WriteLine("HONK");
    }
}