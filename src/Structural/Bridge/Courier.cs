using static System.Console;

namespace Patterns.Structural.Bridge;

public class Сourier : IBridge
{
    public void PrimaryFunc() => WriteLine("walking");

    public void SecondaryFunc() => WriteLine("reading");
}