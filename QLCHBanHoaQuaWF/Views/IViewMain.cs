namespace QLCHBanHoaQuaWF.Views;

public interface IViewMain
{
    public TabControl NavigationBar { get;}
    public event EventHandler LoadPages;
    public event EventHandler Logout;

}