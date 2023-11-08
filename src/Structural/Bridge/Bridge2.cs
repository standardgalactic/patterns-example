using static System.Console;
namespace Patterns.Structural.Bridge;

public class Bridge2 : IBridge{
    public void Function1()=>WriteLine("Bridge2.Function1");
    public void Function2()=> WriteLine("Bridge2.Function2");
}