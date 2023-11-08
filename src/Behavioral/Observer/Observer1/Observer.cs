namespace Patterns.Behavioral.Observer.Observer1;

public class Observer : IObserver<Payload>
{
    public string Message { get; set; }

    public void OnCompleted() {
    }

    public void OnError(Exception error) {
    }

    public void OnNext(Payload value) {
        Message = value.Message;
    }

    public IDisposable Register(Subject subject) {
        return subject.Subscribe(this);
    }
}