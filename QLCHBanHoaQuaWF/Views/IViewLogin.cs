namespace QLCHWF.Views;

public interface IViewLogin : IViewBase
{
    public string Username { get; set; }
    public string Password { get; set; }
    public event EventHandler LoginEvent;
}