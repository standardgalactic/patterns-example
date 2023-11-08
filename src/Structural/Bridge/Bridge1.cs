using static System.Console;
namespace Patterns.Structural.Bridge;

public class Bridge1 : IBridge
{
    public void Function1()=>WriteLine("Bridge1.Function1");
    
public void Function2()=> WriteLine("Bridge1.Function2");
    
}