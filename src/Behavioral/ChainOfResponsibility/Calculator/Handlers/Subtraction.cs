namespace Patterns.Behavioral.ChainOfResponsibility.Calculator.Handlers;
    public class Subtraction : BaseHandler {
        public override double? Handle(double[] values, Action action) {
            if (action == Action.substruct) {
                var result = values[0];
                for (int i = 1; i < values.Length; i++) {
                    result -= values[i];
                }
                return result;
            }
            
            return Next?.Handle(values, action)?? throw new InvalidOperationException("Next  is not initialized");
        }
    }

