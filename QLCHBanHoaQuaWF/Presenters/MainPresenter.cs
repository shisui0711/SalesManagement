using QLCHBanHoaQuaWF.Views;
using QLCHBanHoaQuaWF.Views.Customer;
using QLCHBanHoaQuaWF.Views.Employee;
using QLCHBanHoaQuaWF.Views.ImportOrder;
using QLCHBanHoaQuaWF.Views.Options;
using QLCHBanHoaQuaWF.Views.Product;
using QLCHBanHoaQuaWF.Views.Provider;
using QLCHBanHoaQuaWF.Views.SalesOrder;
using QLCHBanHoaQuaWF.Views.User;
using QLCHBanHoaQuaWF.Views.UserRole;
using System.Reflection;
using System.Text.RegularExpressions;
using DevExpress.XtraEditors.Senders;
using QLCHBanHoaQuaWF.Attributes;
using QLCHBanHoaQuaWF.Models;
using QLCHBanHoaQuaWF.Views.Statistics;

namespace QLCHBanHoaQuaWF.Presenters;

public class MainPresenter
{
    private readonly IViewMain _viewMain;
    private readonly IViewEmployee _viewEmployee;
    private readonly IViewCustomer _viewCustomer;
    private readonly IViewProduct _viewProduct;
    private readonly IViewProvider _viewProvider;
    private readonly IViewSalesOrder _viewSalesOrder;
    private readonly IViewImportOrder _viewImportOrder;
    private readonly IViewUser _viewUser;
    private readonly IViewUserRole _viewUserRole;
    private readonly IViewOptions _viewOptions;
    private readonly IViewStatistics _viewStatistics;
    private readonly IChangePassword _changePassword;
    private readonly MyAppContext _context;
    public MainPresenter(IViewMain viewMain, IViewCustomer viewCustomer, IViewEmployee viewEmployee, IViewProduct viewProduct, IViewProvider viewProvider, IViewSalesOrder viewSalesOrder, IViewImportOrder viewImportOrder, IViewUser viewUser, IViewUserRole viewUserRole, IViewOptions viewOptions,IChangePassword changePassword,IViewStatistics viewStatistics,MyAppContext context)
    {
        _viewMain = viewMain;
        _viewCustomer = viewCustomer;
        _viewEmployee = viewEmployee;
        _viewProduct = viewProduct;
        _viewProvider = viewProvider;
        _viewSalesOrder = viewSalesOrder;
        _viewImportOrder = viewImportOrder;
        _viewUser = viewUser;
        _viewUserRole = viewUserRole;
        _viewOptions = viewOptions;
        _viewStatistics = viewStatistics;
        _changePassword = changePassword;
        _context = context;

        Init();
        _viewMain.ShowChangePassword += delegate { ShowChangePassword(); };
    }
    void Init()
    {
        var events = _viewMain.GetType().GetEvents(BindingFlags.Public | BindingFlags.Instance).Where(x=>Regex.IsMatch(x.Name,@"Show[A-Z].*") && !x.Name.Contains("ChangePassword")).ToList();
        foreach (var eventInfo in events)
        {
            EventHandler handler = (sender, e) =>
            {
                ShowForm(eventInfo.Name.Substring(4));
            };
            eventInfo.AddEventHandler(_viewMain,handler);
        }
    }
    void ShowForm(string formName)
    {
        var fieldForm = GetType().GetFields(BindingFlags.Instance | BindingFlags.NonPublic).Where(f => f.FieldType.Name.StartsWith("IView")).FirstOrDefault(x=>x.Name.Substring(5) == formName);
        Form form = (Form)fieldForm.GetValue(this);
        form.TopLevel = false;
        form.Dock = DockStyle.Fill;
        _viewMain.BodyPanel.Controls.Clear();
        _viewMain.BodyPanel.Controls.Add(form);
        form.Show();
    }
    void ShowChangePassword()
    {
        _changePassword.Email = AuthPresenter.User.Email;
        Form form = (Form)_changePassword;
        if (form != null)
        {
            form.ShowDialog();
        }
    }
}