namespace Patterns.Behavioral.ListOfSignatories {
    public abstract class BaseHandler : IHandler {
      
        public void AddChain(IHandler handler) {
            Next = handler;    
        }
        public abstract  IDictionary<Division, IConsideration?> Handle(object doc, IDictionary<Division, IConsideration?>  list);
        protected IHandler Next;
        
    }
}
