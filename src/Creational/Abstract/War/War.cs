namespace Patterns.Creational.Abstract.War;

internal class War{
    private Racket _racket;
    private Income _income;

    public War(Country country) {
        _racket = country.MakeRacket();
        _income = country.ReceiveIncome();
    }

    public int GetResult() {
        var p = _racket.Produce(_income);
        return p.Money;
    }
}