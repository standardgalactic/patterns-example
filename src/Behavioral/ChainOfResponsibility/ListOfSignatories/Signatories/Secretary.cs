namespace Patterns.Behavioral.ListOfSignatories.Signatories;

public class Secretary : BaseHandler{
    
    
    public override IDictionary<Division, IConsideration> Handle(object doc, IDictionary<Division, IConsideration> list) {
        
            var keys = list.Where(x => x.Value == null).Select(x => x.Key);
            foreach (var key in keys){
                var conclusion = Talk(key);
                list[key] = new Consideration(conclusion);
            }
        
        return Next?.Handle(doc, list) ??
               throw new InvalidOperationException("It's impossible to delegate the task further.");
    }

    private bool Talk(Division division) => true;
}