namespace  Patterns.Behavioral.Command.Calculator;

internal class CalculatorCommand : ICommand
  {
    private char _operator;
    private int _operand;
    private Calculator _calculator;
 
  public CalculatorCommand(Calculator calculator,
      char @operator, int operand)
    {
      _calculator = calculator;
      _operator = @operator;
      _operand = operand;
    }
 

    public char Operator
    {
      set { _operator = value; }
    }
 
    // Get operand

    public int Operand
    {
      set { _operand = value; }
    }
 
    // Execute new command

    public  void Execute()
    {
      _calculator.Operation(_operator, _operand);
    }
 
    public  void UnExecute()
    {
      _calculator.UndoOperation(_operator, _operand);
    }
 
  
}