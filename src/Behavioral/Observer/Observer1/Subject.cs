namespace Patterns.Behavioral.Observer.Observer1;

public class Subject : IObservable<Payload>
{
    public IList<IObserver<Payload>> Observers { get; set; }

    public Subject()
    {
        Observers = new List<IObserver<Payload>>();
    }

    public IDisposable Subscribe(IObserver<Payload> observer)
    {         
        if (!Observers.Contains(observer))
        {
            Observers.Add(observer);
        }

        return new Unsubscriber(observer, Observers);
    }

    public void SendMessage(string message)
    {
        foreach (var observer in Observers)
        {
            observer.OnNext(new Payload { Message = message });
        }
    }
}