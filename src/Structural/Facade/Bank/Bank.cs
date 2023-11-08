namespace Patterns.Structural.Facade.Bank;

internal class Bank{
    public bool HasSufficientSavings(Customer c, int amount) {
        Console.WriteLine("Check bank for " + c.Name);
        return true;
    }
}