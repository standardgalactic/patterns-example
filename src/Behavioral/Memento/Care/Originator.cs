using System;
namespace Patterns.Behavioral.Memento.Care;

internal class Originator{
    private string _state;

    public string State{
      get { return _state; }
      set{ _state = value;
      }
    }
 
    public Memento CreateMemento() {
      return (new Memento(_state));
    }
 
    public void SetMemento(Memento memento) {
      State = memento.State;
    }
  }