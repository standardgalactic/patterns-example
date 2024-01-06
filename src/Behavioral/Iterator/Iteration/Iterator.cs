namespace Patterns.Behavioral.Iterator.Iteration;

internal class DemoIterator : IAbstractIterator

{
    private DemoCollection _collection;
    private int _current = 0;
    private int _step = 1;


    public DemoIterator(DemoCollection collection)
    {
        this._collection = collection;
    }


    public Item First()
    {
        _current = 0;
        return _collection[_current] as Item;
    }


    public Item Next()
    {
        _current += _step;
        if (!IsDone)
            return _collection[_current] as Item;
        else

            return null;
    }

    // Gets or sets stepsize

    public int Step{
        get{ return _step; }
        set{ _step = value; }
    }


    public Item CurrentItem{
        get{ return _collection[_current] as Item; }
    }


    public bool IsDone{
        get{ return _current >= _collection.Count; }
    }
}