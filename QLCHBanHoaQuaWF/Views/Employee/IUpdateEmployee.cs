﻿namespace QLCHWF.Views.Employee;

public interface IUpdateEmployee : IValidateControl
{
    public int EmployeeID { get; set; }
    public string EmployeeName { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string Address { get; set; }
    public decimal? Salary { get; set; }
    public event EventHandler UpdateEmployee;
}