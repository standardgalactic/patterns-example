namespace Patterns.Behavioral.Interpreter.RomanNumerals;  
public class Context{
    public Context(string input) {
     Input = input;
    }
    public string Input{ get; set; }
    public int Output { get; set; }
  }