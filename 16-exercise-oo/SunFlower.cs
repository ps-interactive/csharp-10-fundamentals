
public class SunFlower : Flower
{
    public SunFlower(string name, int petals, int leaves) : base(name, petals, leaves)
    {
    }

    public override void Grow()
    {
        Height += 2;
    }
}
