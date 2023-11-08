namespace Patterns.Behavioral.Visitor.Employees;

internal class VacationApprover : IApprover{
 public void Recalculate(Employee employee) {
      employee.VacationDays += 3;
    }
  }