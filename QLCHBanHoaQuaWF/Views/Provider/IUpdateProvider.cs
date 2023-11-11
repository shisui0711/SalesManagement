namespace QLCHBanHoaQuaWF.Views.Provider;

public interface IUpdateProvider: IValidateControl
{
    public int ProviderID { get;}
    public string ProviderName { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string Address { get; set; }
    public event EventHandler UpdateProvider;
}