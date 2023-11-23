namespace QLCHBanHoaQuaWF.Views.Customer;

public interface IAddCustomer : IValidateControl
{
    public string CustomerName { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string Address { get; set; }
    public void Reset();
    public event EventHandler AddCustomer;
}