namespace Patterns.Behavioral.ListOfSignatories {
    public interface IHandler {
        void AddChain(IHandler handler);
        IDictionary<Division, IConsideration?> Handle(object doc, IDictionary<Division, IConsideration?> list);
    }
}
