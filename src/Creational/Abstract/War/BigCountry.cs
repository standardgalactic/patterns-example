namespace Patterns.Creational.Abstract.War;

internal class BigCountry : Country{
    public override Racket MakeRacket() {
        return new Invasion();
    }

    public override Income ReceiveIncome() {
        Contract contract = new();
        contract.Money *= 100;
        return contract;
    }
}