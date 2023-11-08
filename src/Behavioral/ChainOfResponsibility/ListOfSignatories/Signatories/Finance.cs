namespace Patterns.Behavioral.ListOfSignatories.Signatories;

public class Finance : BaseHandler{
    private const string Success = "Approved";
    private const string Failer = "List of remarks";
    public override IDictionary<Division, IConsideration> Handle(object doc, IDictionary<Division, IConsideration> list) {
        
            var approved = Calculation(doc, out string comment);
            list[Division.Finance] = new Consideration(approved, comment);
        
        
        return Next?.Handle(doc, list) ??
               throw new InvalidOperationException("It's impossible to delegate the task further.");
    }

    private int threshold = 500;

    private bool Calculation(object o, out string comment) {
        var income = new Random().Next(100, 1000);
        if (income > threshold){
            comment =Success;
            return true;
        }

        comment =Failer;
        return false;
    }
}