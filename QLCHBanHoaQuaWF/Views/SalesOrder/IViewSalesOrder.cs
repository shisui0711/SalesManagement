namespace QLCHWF.Views.SalesOrder;

public interface IViewSalesOrder : IViewBase,IViewPagination
{
    public string SearchText { get; set; }
    public int OptionIndex { get; set; }
    public DateTime DateStart { get; }
    public DateTime DateEnd { get; }
    public BindingSource OrderBindingSource { get; }
    public event EventHandler LoadSalesOrder;
    public event EventHandler RemoveSalesOrder;
    public event EventHandler SearchSalesOrder;
    public event EventHandler ShowAdd;
    public event EventHandler ShowReport;
    public event EventHandler ShowDetail;
}