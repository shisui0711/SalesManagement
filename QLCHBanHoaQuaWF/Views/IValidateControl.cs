namespace QLCHBanHoaQuaWF.Views;

public interface IValidateControl
{
    public string Message { get; set; }
    public void Focus(string name);
}