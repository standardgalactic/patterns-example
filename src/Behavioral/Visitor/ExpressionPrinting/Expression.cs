namespace Patterns.Behavioral.Visitor.ExpressionPrinting;

public abstract class Expression
{    
    public abstract void Accept(ExpressionPrinting v);
    
    public abstract double GetValue();
}