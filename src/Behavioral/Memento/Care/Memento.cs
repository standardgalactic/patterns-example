namespace Patterns.Behavioral.Memento.Care;

internal class Memento{
     
    private string _state;
 public Memento(string state) {
      _state = state;
    }
 
    public string State => _state;
    
  }