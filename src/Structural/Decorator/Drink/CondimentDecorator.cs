namespace Patterns.Structural.Decorator.Drink;

internal abstract class CondimentDecorator : Beverage{
    public abstract override string Description{ get; }
}