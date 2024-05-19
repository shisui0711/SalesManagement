namespace QLCHWF.Views.Provider;

public interface IViewProvider : IViewBase,IViewPagination
{
    public string SearchText { get; set; }
    public int OptionIndex { get; set; }
    public BindingSource ProviderBindingSource { get; }
    public event EventHandler RemoveProvider;
    public event EventHandler LoadProvider;
    public event EventHandler SearchProvider;
    public event EventHandler ShowAddProvider;
    public event EventHandler ShowUpdateProvider;
    public event EventHandler ShowOrderHistory;
}