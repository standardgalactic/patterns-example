
namespace Patterns.Behavioral.ListOfSignatories;

public class Approvallist: Dictionary <Division, IConsideration?> {
    public Approvallist() : base(new List<KeyValuePair<Division, IConsideration?>>(){
        new(Division.Marketing, null),
        new(Division.Finance, null),
        new(Division.Sales, null),
        new(Division.Security, null),
        new(Division.Chief, null)
     }) {
    }
}
