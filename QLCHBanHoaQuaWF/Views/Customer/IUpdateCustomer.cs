﻿namespace QLCHWF.Views.Customer;

public interface IUpdateCustomer : IValidateControl,IViewBase
{
    public int CustomerID { get; set; }
    public string CustomerName { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string Address { get; set; }
    public event EventHandler UpdateCustomer;
}