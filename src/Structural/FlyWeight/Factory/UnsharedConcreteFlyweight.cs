namespace Patterns.Structural.FlyWeight.Factory;

internal class UnsharedConcreteFlyweight : Flyweight{
    public override void Operation(int extrinsicstate) {
        Console.WriteLine("UnsharedConcreteFlyweight: " + extrinsicstate);
    }
}