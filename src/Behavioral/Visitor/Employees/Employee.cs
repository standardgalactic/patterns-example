namespace Patterns.Behavioral.Visitor.Employees;

internal class Employee {
   public string Name{ get; set; }
   public double Income  { get; set; }
   public int VacationDays { get; set; }
 public Employee(string name, double income, int vacationDays) {
      Name = name;
      Income = income;
      VacationDays = vacationDays;
    }
    
    public  void Recalculate(IApprover approver) {
      approver.Recalculate(this);
    }
  }