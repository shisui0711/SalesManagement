namespace QLCHWF.Views;

public interface IViewLogin : IViewBase
{
    public string Username { get; set; }
    public string Password { get; set; }
    public string Role { get; }
    public event EventHandler LoginEvent;
}