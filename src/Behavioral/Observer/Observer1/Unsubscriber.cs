namespace Patterns.Behavioral.Observer.Observer1;

public class Unsubscriber : IDisposable
{
    private IObserver<Payload> observer;
    private IList<IObserver<Payload>> observers;

    public Unsubscriber(
        IObserver<Payload> observer,
        IList<IObserver<Payload>> observers)
    {
        this.observer = observer;
        this.observers = observers;
    }

    public void Dispose()
    {
        if (observer != null && observers.Contains(observer))
        {
            observers.Remove(observer);
        }
    }
}