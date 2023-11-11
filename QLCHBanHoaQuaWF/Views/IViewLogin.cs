namespace QLCHBanHoaQuaWF.Views;

public interface IViewLogin
{
    public string Username { get; set; }
    public string Password { get; set; }
    public string Role { get; }
    public event EventHandler LoginEvent;
}