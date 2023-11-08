namespace Patterns.Behavioral.Visitor.ExpressionPrinting;

public class Literal : Expression
{
    public double Value { get; set; }

    public Literal(double value) {
        Value = value;
    }
    
    public override void Accept(ExpressionPrinting v) {
        v.PrintLiteral(this);
    }
    
    public override double GetValue() {
        return Value;
    }
}