public class Owner
{
    private string firstName;
    private string lastName;

    public string FirstName
    {
        get
        {
            return firstName;
        }
        set
        {
            firstName = value;
        }
    }
    public string LastName
    {
        get { return lastName; }
        set
        {
            lastName = value;
        }
    }

    public Owner(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;    
    }
}
