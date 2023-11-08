namespace Patterns.Structural.Proxy.Math;

internal class MathProxy : IMath {
    private Math _math = new ();
    public int Add(int x, int y) => _math.Add(x, y)+1;
}