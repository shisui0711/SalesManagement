namespace QLCHBanHoaQuaWF.Models;

public class SalaryTable
{
    public int EmployeeID { get; set; }
    public string EmployeeName { get; set; }
    public decimal Salary { get; set; }
    public int TotalWorked { get; set; }
    public decimal FinalSalary
    {
        get { return Salary * TotalWorked; }
    }
}