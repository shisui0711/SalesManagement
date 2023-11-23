namespace QLCHBanHoaQuaWF.Views;

public interface IViewMain
{
    public string User { get; set; }
    public string Role { get; set; }
    public TabControl NavigationBar { get; }
    public event EventHandler LoadPages;
    public event EventHandler Logout;

}