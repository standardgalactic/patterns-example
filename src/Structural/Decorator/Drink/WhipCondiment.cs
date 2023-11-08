namespace Patterns.Structural.Decorator.Drink;

internal class WhipCondiment : CondimentDecorator{
    private Beverage _beverage;

    public WhipCondiment(Beverage beverage) {
        _beverage = beverage;
    }

    public override string Description{
        get{
            if (_beverage.Description.StartsWith("Whip")){
                return "Double " + _beverage.Description;
            }
            else
                return "Whip " + _beverage.Description;
        }
    }

    public override double Cost() {
        return 0.15 + _beverage.Cost();
    }
}