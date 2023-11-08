namespace Patterns.Behavioral.ListOfSignatories;

public interface IConsideration{
    bool  Approval { get; }
    string? Comment { get; }
}