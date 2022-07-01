public static class Utilities
{
    public static int DivideValues(string input1, string input2)
    {
        try
        {
            int value1 = int.Parse(input1);
            int value2 = int.Parse(input2);

            int result = value1 / value2;

            return result;
        }
        catch (FormatException fex)
        {
            Console.WriteLine("The entered value was not an integer!");
            Console.WriteLine(fex.Message);
            return -1;
        }
        catch (DivideByZeroException dex)
        {
            Console.WriteLine("Dividing by zero is not possible!");
            Console.WriteLine(dex.Message);
            return -1;
        }
        catch (Exception ex)
        {
            return -1;
        }
    }
}