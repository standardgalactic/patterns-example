using static System.Console;
namespace Patterns.Structural.Bridge;

public class Editor : IBridge{
    public void PrimaryFunc()=>WriteLine("reading");
    public void SecondaryFunc()=> WriteLine("running");
}