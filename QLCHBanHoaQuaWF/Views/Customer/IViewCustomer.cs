namespace QLCHBanHoaQuaWF.Views.Customer;

public interface IViewCustomer
{
    public string SearchText { get; set; }
    public int OptionIndex { get; set; }
    public BindingSource CustomerBindingSource { get; }
    public event EventHandler RemoveCustomer;
    public event EventHandler LoadCustomer;
    public event EventHandler SearchCustomer;
    public event EventHandler ShowAddCustomer;
    public event EventHandler ShowUpdateCustomer;
    public event EventHandler ShowSalesHistory;
}