namespace Patterns.Creational.Abstract.War;

internal class Raid : Racket{
    public override Income Produce(Income income) {
        income.Money *= 100;
        return income;
    }
}