public static class Utilities
{
    public static int DivideValues(string input1, string input2)
    {
        int value1 = int.Parse(input1);
        int value2 = int.Parse(input2);

        int result = value1 / value2;

        return result;
    }
}

