namespace Patterns.Behavioral.ChainOfResponsibility.Calculator.Handlers;
    public class Multiplication : BaseHandler {
        public override double? Handle(double[] values, Action action) {
            if (action == Action.multiply) {
                var result = 1.0;
                foreach (var value in values) {
                    result *= value;
                }
                return result;
            }
            
            return Next?.Handle(values, action)?? throw new InvalidOperationException("Next  is not initialized");
        }
    }

