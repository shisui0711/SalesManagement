namespace QLCHBanHoaQuaWF.Views.Provider;

public interface IAddProvider : IValidateControl
{
    public string ProviderName { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string Address { get; set; }
    public void Reset();
    public event EventHandler AddProvider;
}