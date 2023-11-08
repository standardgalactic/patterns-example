namespace Patterns.Behavioral.ChainOfResponsibility.Calculator {
    public abstract class BaseHandler : IHandler {
        public void AddChain(IHandler handler) {
            Next = handler;    
        }

        public abstract double? Handle(double[] values, Action action);

        protected IHandler Next;
    }
}
