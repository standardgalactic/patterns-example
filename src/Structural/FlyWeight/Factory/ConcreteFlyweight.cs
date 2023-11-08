namespace Patterns.Structural.FlyWeight.Factory;

internal class ConcreteFlyweight : Flyweight{
    public override void Operation(int extrinsicstate) {
        Console.WriteLine("ConcreteFlyweight: " + extrinsicstate);
    }
}