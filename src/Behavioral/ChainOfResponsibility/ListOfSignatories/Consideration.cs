namespace Patterns.Behavioral.ListOfSignatories;

public class Consideration : IConsideration{

    public  bool  Approval { get;  }
    public  string? Comment { get; }
    
    public Consideration(bool approval): this(approval, null) { }

    public Consideration(bool approval, string? comment) {
        Approval = approval;
        Comment = comment;
    }
    
}
