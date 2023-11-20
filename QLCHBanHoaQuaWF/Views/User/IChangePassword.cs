namespace QLCHBanHoaQuaWF.Views.User;

public interface IChangePassword : IValidateControl
{
    public string Email  { get; set; }
    public string Password { get; set; }
    public string Repassword { get; set; }
    public event EventHandler ChangePassowrd;
}