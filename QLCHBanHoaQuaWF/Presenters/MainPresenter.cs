using QLCHWF.Views;
using QLCHWF.Views.Customer;
using QLCHWF.Views.Employee;
using QLCHWF.Views.ImportOrder;
using QLCHWF.Views.Options;
using QLCHWF.Views.Product;
using QLCHWF.Views.Provider;
using QLCHWF.Views.SalesOrder;
using QLCHWF.Views.User;
using QLCHWF.Views.UserRole;
using System.Reflection;
using System.Text.RegularExpressions;
using QLCHWF.Attributes;
using QLCHWF.Models;
using QLCHWF.Views.Statistics;

namespace QLCHWF.Presenters;

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
    }
    void Init()
    {
        var events = _viewMain.GetType().GetEvents(BindingFlags.Public | BindingFlags.Instance).Where(x=>Regex.IsMatch(x.Name,@"Show[A-Z].*")).ToList();
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
}