namespace QLCHWF.Views.ImportOrder;

public interface IAddImportOrder : IViewBase,IViewPagination
{
    public string ProviderSearchText { get; set; }
    public string? ProductSearchText { get; set; }
    public decimal TotalPrice { get; set; }
    public int EmployeeID { get; }
    public int ProviderID { get; }
    public void AddControl(Control control);
    public void ClearControl();
    public DataGridView OrderedGridView { get; set; }
    public event EventHandler<DataGridViewCellEventArgs>? RemoveProduct;
    public BindingSource ProviderBindingSource { get; }
    public event EventHandler? LoadProduct;
    public event EventHandler? LoadProvider;
    public event EventHandler? SearchProvider;
    public event EventHandler? SearchProduct;
    public event EventHandler? AddImportOrder;
}