namespace Patterns.Behavioral.Visitor.Employees;

internal class Employees{
    private List<Employee> _employees = new ();
 
    public void Add(Employee employee) {
      _employees.Add(employee);
    }
 
    public void Remove(Employee employee) {
      _employees.Remove(employee);
    }
 
    public void Recalculate(IApprover approver) {
      foreach (Employee e in _employees){
        e.Recalculate(approver);
      }
  
    }
  }