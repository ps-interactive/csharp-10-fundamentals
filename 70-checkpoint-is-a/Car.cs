public class Car : Vehicle
{
    public Car(int currentMileage, string model, string color, int numberOfGears) : base(currentMileage, model, color)
    {
        NumberOfGears = numberOfGears;
    }

    private int numberOfGears;

    public int NumberOfGears
    {
        get
        {
            return numberOfGears;
        }
        set
        {
            numberOfGears = value;
        }
    }

    public void SoundCarHorn()
    {
        SoundHorn();
    }
}
