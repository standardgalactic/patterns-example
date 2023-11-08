namespace  Patterns.Behavioral.Command.Calculator;

internal class Calculator

  {

    public int Result{ get; private set; } = 0; 
    public void Operation(char @operator, int operand)
    {
      switch (@operator)
      {
        case '+': Result += operand; break;
        case '-': Result -= operand; break;
        case '*': Result *= operand; break;
        case '/': Result /= operand; break;
      }
    }
    
    public void UndoOperation(char @operator,int operand)
    {
      switch (@operator)
      {
          case '+': Result -= operand; break;
          case '-': Result += operand; break;
          case '*': Result /= operand; break;
          case '/': Result *= operand; break;
      }
    }
  }