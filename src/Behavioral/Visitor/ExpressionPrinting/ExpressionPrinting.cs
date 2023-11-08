namespace Patterns.Behavioral.Visitor.ExpressionPrinting;

public class ExpressionPrinting
{
    public void PrintLiteral(Literal literal)
    {
        Console.WriteLine(literal.Value);
    }
    
    public void PrintAddition(Addition addition)
    {
        double leftValue = addition.Left.GetValue();
        double rightValue = addition.Right.GetValue();
        var sum = addition.GetValue();
        Console.WriteLine("{0} + {1} = {2}", leftValue, rightValue, sum);
    }
}