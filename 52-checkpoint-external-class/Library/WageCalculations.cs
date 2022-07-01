namespace Library
{
    public class WageCalculations
    {
        public double RandomWageGenerator()
        {
            return new Random().NextDouble() * 1000;
        }

    }
}