namespace Patterns.Behavioral.ChainOfResponsibility.Calculator {
    public interface IHandler {
        void AddChain(IHandler handler);
        double? Handle(double[] values, Action action);
    }
}
