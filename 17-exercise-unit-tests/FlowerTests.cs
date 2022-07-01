
using Xunit;

public class FlowerTests
{
    [Fact]
    public void Grow_Adds_DefaultNumber()
    {

        Flower f1 = new Flower("Rose", 10, 10);
        f1.Height = 0;

        f1.Grow();

        Assert.Equal(1, f1.Height);
    }
}
