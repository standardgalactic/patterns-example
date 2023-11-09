namespace Patterns.Structural.Bridge;

public class Actor : IActor
{
    public IBridge bridge;

    public Actor(IBridge bridge)
    {
        this.bridge = bridge;
    }

    public void Work()
    {
        bridge.PrimaryFunc();
    }

    public void Rest()
    {
        bridge.SecondaryFunc();
    }
}