namespace QLCHWF.Views.User;

public interface IUpdatePassword : IValidateControl
{
    public string Email { get; set; }
    public string Password { get; set; }
    public string Repassword { get; set; }
    public event EventHandler UpdatePassowrd;
}