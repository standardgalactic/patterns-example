using System.Diagnostics.CodeAnalysis;

namespace Patterns.Behavioral.ListOfSignatories.Signatories;

public class Sales: BaseHandler{
    private const string Success = "Approved";
    private const string Failer = "List of remarks";
        public override  IDictionary<Division, IConsideration> Handle(object doc, IDictionary<Division, IConsideration> list) {
          
              var approved=  Calculation(doc, out string comment);
               list[Division.Sales] = new Consideration(approved,comment);
             
          
            return Next?.Handle(doc, list)?? throw new InvalidOperationException("It's impossible to delegate the task further.");
        }

        private bool Calculation(object o, out string comment) {

            if (DateTime.Now.Hour < 12){
                comment = Success;
                return true;
            }

            comment = Failer;
            return false;
        }
    }
    
    
