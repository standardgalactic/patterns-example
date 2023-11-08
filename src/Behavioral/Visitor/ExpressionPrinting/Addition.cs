namespace Patterns.Behavioral.Visitor.ExpressionPrinting;

public class Addition : Expression {
    public Expression Left { get; set; }
    public Expression Right { get; set; }

    public Addition(Expression left, Expression right) {
        Left = left;
        Right = right;
    }
  
    public override void Accept(ExpressionPrinting v) {
        Left.Accept(v);
        Right.Accept(v);
        v.PrintAddition(this);
    }
  
    public override double GetValue() {
        return Left.GetValue() + Right.GetValue();    
    }
}