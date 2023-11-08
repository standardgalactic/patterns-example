namespace Patterns.Behavioral.Memento.MementoList;

internal class Memento
{
    private readonly string state;
    private Memento(string state) {
        this.state = state;
    }

    public string State => state; 
    public class Originator
    {
        private string state;
        
        public void Set(string state) {
            this.state = state;
        }

        public string State => state;
        public Memento SaveToMemento()=> new Memento(state);
        
        public void RestoreFromMemento(Memento memento) {
            state = memento.state;
          
        }
    }
}