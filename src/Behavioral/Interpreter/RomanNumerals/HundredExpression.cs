namespace Patterns.Behavioral.Interpreter.RomanNumerals;

internal class HundredExpression : Expression{
    public override string One=> "C";
    
    public override string Four =>"CD"; 
    public override string Five =>"D";
    public override string Nine => "CM"; 
    public override int Multiplier => 100;
  }