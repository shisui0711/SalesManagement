namespace QLCHWF.Views.Employee;

public interface IViewSalary
{
    public DateTime StartDate { get;  }
    public DateTime EndDate { get; }
    public BindingSource SalaryBindingSource { get;}
    public event EventHandler CalculateSalary;
}