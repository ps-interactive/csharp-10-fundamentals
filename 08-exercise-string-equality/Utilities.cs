public class Utilities
{
    public static bool CheckIfStringsAreEqual(string a, string b)
    {
        bool equal = false;
        equal = a.ToLower() == b.ToLower();
        return equal;
    }
}
