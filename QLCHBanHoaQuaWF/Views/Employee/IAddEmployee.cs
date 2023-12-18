namespace QLCHBanHoaQuaWF.Views.Employee;

public interface IAddEmployee : IValidateControl
{
    public string EmployeeName { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string Address { get; set; }
    public decimal? Salary { get; set; }
    public void Reset();
    public event EventHandler AddEmployee;
}