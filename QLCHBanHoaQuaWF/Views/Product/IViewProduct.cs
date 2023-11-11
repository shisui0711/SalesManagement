namespace QLCHBanHoaQuaWF.Views.Product;

public interface IViewProduct
{
    public string SearchText { get; set; }
    public int OptionIndex { get; set; }
    public BindingSource ProductBindingSource { get; }
    public event EventHandler RemoveProduct;
    public event EventHandler LoadProduct;
    public event EventHandler SearchProduct;
    public event EventHandler ShowAddProduct;
    public event EventHandler ShowUpdateProduct;
}