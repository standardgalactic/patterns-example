namespace Patterns.Creational.Abstract.War;

internal class Invasion : Racket{
    public override Income Produce(Income income) {
        income.Money *= 1000;
        return income;
    }
}