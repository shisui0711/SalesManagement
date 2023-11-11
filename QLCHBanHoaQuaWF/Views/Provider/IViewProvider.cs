namespace QLCHBanHoaQuaWF.Views.Provider;

public interface IViewProvider
{
    public string SearchText { get; set; }
    public BindingSource ProviderBindingSource { get; }
    public event EventHandler RemoveProvider;
    public event EventHandler LoadProvider;
    public event EventHandler SearchProvider;
    public event EventHandler ShowAddProvider;
    public event EventHandler ShowUpdateProvider;
}