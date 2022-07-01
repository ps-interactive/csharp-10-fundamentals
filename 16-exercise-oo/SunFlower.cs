
public class SunFlower : Flower
{
    public SunFlower(string name, int petals, int leafs) : base(name, petals, leafs)
    {
    }

    public override void Grow()
    {
        Height += 2;
    }
}
