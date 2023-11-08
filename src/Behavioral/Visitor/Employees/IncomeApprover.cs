namespace Patterns.Behavioral.Visitor.Employees;

internal class IncomeApprover : IApprover{
    public void Recalculate(Employee employee) {
      employee.Income *= 1.10;
      
    }
  }