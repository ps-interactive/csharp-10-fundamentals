public class Utilities
{
    public static string RemoveVowels(string input)
    {
        string result = string.Empty;

        result = input.Replace("a", "")
                          .Replace("e", "")
                          .Replace("i", "")
                          .Replace("o", "")
                          .Replace("u", "")
                          .Replace("y", "");
        return result;
    }
}
