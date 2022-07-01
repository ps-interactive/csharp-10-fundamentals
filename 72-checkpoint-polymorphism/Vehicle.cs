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

    public virtual void Drive()
    {
        CurrentMileage++;
    }

    public virtual void Drive(int miles)
    {
        if (miles > 0)
            CurrentMileage += miles;
    }

    private string DisplayVehicleDetails()
    {
        return $"Model: {Model} - Color: {Color} - Current mileage: {CurrentMileage}";
    }

    protected void SoundHorn()
    {
        Console.WriteLine("HONK");
    }
}