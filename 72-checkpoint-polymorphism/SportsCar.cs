
public class SportsCar : Vehicle
{
    public SportsCar(int currentMileage, string model, string color) : base(currentMileage, model, color)
    {
    }

    public override void Drive()
    {
        CurrentMileage += 2;
    }

    public override void Drive(int miles)
    {
        CurrentMileage += 2 * miles;
    }
}
