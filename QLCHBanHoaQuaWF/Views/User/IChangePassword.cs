namespace QLCHWF.Views.User;

public interface IChangePassword
{
    public string Email { get; set; }
    public string OldPassword { get; set; }
    public string NewPassword { get; set; }
    public string Repassword { get; set; }
    public event EventHandler ChangePassowrd;
}