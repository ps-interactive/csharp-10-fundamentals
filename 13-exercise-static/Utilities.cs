
public class Utilities
{
    public static int ChangeMaxSpeed()
    {
        int newMaxSpeed = 0;

        int increaseAmount = 10;

        Vehicle.IncreaseMaxSpeed(increaseAmount);

        newMaxSpeed = Vehicle.maxSpeed;

        return newMaxSpeed;

    }
}
