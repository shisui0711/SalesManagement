namespace QLCHBanHoaQuaWF.Views;

public interface IViewMain : IChangeControl
{
    public string User { get; set; }
    public string Role { get; set; }
    public Panel BodyPanel { get; }
    public event EventHandler ShowStatistics;
    public event EventHandler ShowSalesOrder;
    public event EventHandler ShowImportOrder;
    public event EventHandler ShowCustomer;
    public event EventHandler ShowProduct;
    public event EventHandler ShowProvider;
    public event EventHandler ShowEmployee;
    public event EventHandler ShowUser;
    public event EventHandler ShowUserRole;
    public event EventHandler ShowOptions;
    public event EventHandler ShowChangePassword;

}