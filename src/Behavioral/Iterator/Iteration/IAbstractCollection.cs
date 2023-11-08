namespace Patterns.Behavioral.Iterator.Iteration;

internal interface IAbstractCollection

    {
        DemoIterator CreateIterator();
    }