namespace Patterns.Behavioral.ListOfSignatories.Signatories;

public class Chief:BaseHandler{
    
   /// <param name="doc">document for approval</param>
   /// <param name="list">approval list</param>
   /// <returns></returns>
   /// <exception cref="InvalidOperationException"></exception>
    public override IDictionary<Division, IConsideration> Handle(object doc, IDictionary<Division, IConsideration> list) {
        
            if (list.Values.All(x => x == null)){
                  return Next?.Handle(doc, list) ??
                  throw new InvalidOperationException("It's impossible to delegate the task further.");
            }
           
            if (list.Where(x=>x.Key!=Division.Chief).Any(x => x.Value == null)){
              Next = new Secretary();
              Next.AddChain(this);
              return Next?.Handle(doc, list);
            }

            if (list.Values.All(x => x.Approval)){
                list[Division.Chief] = new Consideration(true);
            }
            else{
                list[Division.Chief] = new Consideration(false);
            }
            return list;
    }
}