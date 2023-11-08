namespace Patterns.Behavioral.Memento.Care;

internal class Caretaker{
    private Memento _memento;
 
    public Memento Memento
    {
      set { _memento = value; }
      get { return _memento; }
    }
  }