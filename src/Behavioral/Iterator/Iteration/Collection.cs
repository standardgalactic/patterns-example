using System.Collections;

namespace Patterns.Behavioral.Iterator.Iteration;

internal class DemoCollection : IAbstractCollection

    {
        private ArrayList _items = new ArrayList();
 
        public DemoIterator CreateIterator()
        {
            return new DemoIterator(this);
        }
 
      
        public int Count
        {
            get { return _items.Count; }
        }
 
     
        public object this[int index]
        {
            get { return _items[index]; }
            set { _items.Add(value); }
        }
    }