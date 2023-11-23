namespace QLCHBanHoaQuaWF.Views.Options;

public interface IAppInfo
{
    public string AppName { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }
    public byte[]? PrintFormat { get; set; }
    public event EventHandler UpdateAppInfo;
}