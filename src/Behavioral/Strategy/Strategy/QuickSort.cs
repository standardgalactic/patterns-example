namespace Patterns.Behavioral.Strategy.Strategy;

internal class QuickSort : SortStrategy{
    public override void Sort(List<string> list) {
      list.Sort();
     }
  }