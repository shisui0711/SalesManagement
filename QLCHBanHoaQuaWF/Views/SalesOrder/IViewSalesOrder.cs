namespace QLCHBanHoaQuaWF.Views.SalesOrder;

public interface IViewSalesOrder
{
    public string SearchText { get; set; }
    public int OptionIndex { get; set; }
    public DateTime DateStart { get;  }
    public DateTime DateEnd { get; }
    public BindingSource OrderBindingSource { get; }
    public event EventHandler LoadSalesOrder;
    public event EventHandler RemoveSalesOrder;
    public event EventHandler SearchSalesOrder;
    public event EventHandler ShowAdd;
}