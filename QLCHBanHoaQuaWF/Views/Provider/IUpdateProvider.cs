namespace QLCHWF.Views.Provider;

public interface IUpdateProvider : IValidateControl
{
    public int ProviderID { get; set; }
    public string ProviderName { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string Address { get; set; }
    public event EventHandler UpdateProvider;
}