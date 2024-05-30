namespace QLCHWF.Views.SalesOrder;

public interface IAddSalesOrder : IViewBase,IViewPagination
{
    public string CustomerSearchText { get; set; }
    public string ProductSearchText { get; set; }
    public decimal PurchasePrice { get; set; }
    public decimal ChangePrice { get; set; }
    public decimal TotalPrice { get; set; }
    public int? EmployeeID { get; }
    public int? CustomerID { get; }
    public void AddControl(Control control);
    public void ClearControl();
    public BindingSource CustomerBindingSource { get; }
    public DataGridView OrderedGridView { get; set; }
    public event EventHandler<DataGridViewCellEventArgs>? RemoveProduct;
    public event EventHandler? LoadProduct;
    public event EventHandler? SearchCustomer;
    public event EventHandler? SearchProduct;
    public event EventHandler? AddSalesOrder;
}