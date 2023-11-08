namespace Patterns.Structural.Facade.Bank;

internal class Customer{
    private string _name;

    public Customer(string name) {
        _name = name;
    }


    public string Name => _name;
}