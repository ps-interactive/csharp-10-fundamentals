
public class Flower
{
    private int petals;
    private int leaves;
    private string name;
    private int height = 0;

    public Flower(string name, int petals, int leaves)
    {
        Petals = petals;
        Leaves = leaves;
        Name = name;
    }

    public int Petals
    {
        get { return petals; }
        set
        {
            petals = value;
        }
    }

    public int Leaves
    {
        get
        {
            return leaves;
        }

        set
        {
            leaves = value;
        }
    }

    public string Name
    {
        get { return name; }
        set
        {
            name = value;
        }
    }

    public int Height
    {
        get { return height; }
        set
        {
            height = value;
        }
    }

    public void Grow()
    {
        Height++;
    }

    public string DisplayDetails()
    {
        return $"Flower name: {Name} - Petals: {Petals} - Leaves: {Leaves} - Height: {Height}";
    }
}
