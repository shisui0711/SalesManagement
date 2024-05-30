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
using Microsoft.Extensions.DependencyInjection;
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
    public MainPresenter(IViewMain viewMain, IViewCustomer viewCustomer, IViewEmployee viewEmployee, IViewProduct viewProduct, IViewProvider viewProvider, IViewSalesOrder viewSalesOrder, IViewImportOrder viewImportOrder, IViewUser viewUser, IViewUserRole viewUserRole, IViewOptions viewOptions,IChangePassword changePassword,IViewStatistics viewStatistics)
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

        Init();
    }
    void Init()
    {
        var events = _viewMain.GetType().GetEvents(BindingFlags.Public | BindingFlags.Instance).Where(x=>Regex.IsMatch(x.Name,@"Show[A-Z].*")).ToList();
        foreach (var eventInfo in events)
        {
            EventHandler handler = (_, _) =>
            {
                ShowForm(eventInfo.Name.Substring(4));
            };
            eventInfo.AddEventHandler(_viewMain,handler);
        }
    }
    void ShowForm(string formName)
    {
        InitPresenter(formName);
        var fieldForm = GetType().GetFields(BindingFlags.Instance | BindingFlags.NonPublic).Where(f => f.FieldType.Name.StartsWith("IView")).FirstOrDefault(x=>x.Name.Substring(5) == formName);
        if (fieldForm != null)
        {
            Form form = (Form)fieldForm.GetValue(this)!;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            _viewMain.BodyPanel.Controls.Clear();
            _viewMain.BodyPanel.Controls.Add(form);
            form.Show();
        }
    }

    void InitPresenter(string formName)
    {
        switch (formName)
        {
            case "Customer":
                Program.MyHost.Services.GetRequiredService<CustomerPresenter>();
                break;
            case "Employee":
                Program.MyHost.Services.GetRequiredService<EmployeePresenter>();
                break;
            case "ImportOrder":
                Program.MyHost.Services.GetRequiredService<ImportOrderPresenter>();
                break;
            case "Options":
                Program.MyHost.Services.GetRequiredService<OptionsPresenter>();
                break;
            case "Product":
                Program.MyHost.Services.GetRequiredService<ProductPresenter>();
                break;
            case "Provider":
                Program.MyHost.Services.GetRequiredService<ProviderPresenter>();
                break;
            case "SalesOrder":
                Program.MyHost.Services.GetRequiredService<SalesOrderPresenter>();
                break;
            case "Statistics":
                Program.MyHost.Services.GetRequiredService<StatisticsPresenter>();
                break;
            case "UserRole":
                Program.MyHost.Services.GetRequiredService<UserRolePresenter>();
                break;
            case "User":
                Program.MyHost.Services.GetRequiredService<UserPresenter>();
                break;
        }
    }
}