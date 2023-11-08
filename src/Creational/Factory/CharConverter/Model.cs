namespace Patterns.Creational.Factory.CharConverter;

public class Model{
    private int? _code=null;
    private char _char;
  
    public Model(char c) {
        _char = c;

    }
    public int? Code => _code;
    public char Get() {
        return  _char;
    }

    public void Parse(char a) {
        _code= a;
    }
}