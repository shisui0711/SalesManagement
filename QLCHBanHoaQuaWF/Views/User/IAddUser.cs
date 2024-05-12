﻿namespace QLCHWF.Views.User;

public interface IAddUser : IValidateControl
{
    public string Email { get; set; }
    public int EmployeeID { get; }
    public int RoleID { get; }
    public string Password { get; set; }
    public string Repassword { get; set; }
    public BindingSource EmployeeBindingSource { get; }
    public BindingSource RoleBindingSource { get; }
    public event EventHandler AddUser;
}