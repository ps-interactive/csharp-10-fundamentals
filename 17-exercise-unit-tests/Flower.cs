
public class Flower
{
    private int petals;
    private int leafs;
    private string name;
    private int height = 0;

    public Flower(string name, int petals, int leafs)
    {
        Petals = petals;
        Leafs = leafs;
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

    public int Leafs
    {
        get
        {
            return leafs;
        }

        set
        {
            leafs = value;
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

    public virtual void Grow()
    {
        Height++;
    }

    public string DisplayDetails()
    {
        return $"Flower name: {Name} - Petals: {Petals} - Leafs: {Leafs} - Height: {Height}";
    }
}
