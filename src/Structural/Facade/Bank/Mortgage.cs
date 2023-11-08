namespace Patterns.Structural.Facade.Bank;

internal class Mortgage{
    private Bank _bank = new();
    private Loan _loan = new();
    private Credit _credit = new();

    public bool IsEligible(Customer cust, int amount) {
        bool eligible = true;


        if (!_bank.HasSufficientSavings(cust, amount)){
            eligible = false;
        }
        else if (!_loan.HasNoBadLoans(cust)){
            eligible = false;
        }
        else if (!_credit.HasGoodCredit(cust)){
            eligible = false;
        }

        return eligible;
    }
}