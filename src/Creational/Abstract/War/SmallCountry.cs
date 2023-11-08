namespace Patterns.Creational.Abstract.War;

internal class SmallCountry : Country{
    public override Racket MakeRacket() {
        return new Raid();
    }

    public override Income ReceiveIncome() {
        Cash cash = new();
        cash.Money *= 10;
        return cash;
    }
}