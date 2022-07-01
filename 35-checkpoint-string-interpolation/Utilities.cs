
public class Utilities
{
    public static string CreateGreeting(string employeeName, int age)
    {
        string greeting = string.Empty;

        greeting = $"Hello {employeeName}, you are {age} years";

        return greeting;
    }
}
