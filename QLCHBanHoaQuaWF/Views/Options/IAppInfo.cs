namespace QLCHWF.Views.Options;

public interface IAppInfo : IViewBase
{
    public string? AppName { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }
    public byte[]? PrintFormat { get; set; }
    public event EventHandler UpdateAppInfo;
}