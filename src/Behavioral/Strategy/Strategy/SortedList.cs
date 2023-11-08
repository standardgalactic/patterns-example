namespace Patterns.Behavioral.Strategy.Strategy;

internal class SortedList{
    private List<string> _list = new ();
    private SortStrategy _sortstrategy;
 
    public void SetSortStrategy(SortStrategy sortstrategy) {
      _sortstrategy = sortstrategy;
    }
 
    public void Add(string name) {
      _list.Add(name);
    }
 
    public void Sort() {
      _sortstrategy.Sort(_list);
      foreach (string name in _list){
        Console.WriteLine(" " + name);
      }
      Console.WriteLine();
    }
 }