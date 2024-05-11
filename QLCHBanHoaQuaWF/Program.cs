using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OfficeOpenXml;
using QLCHWF.Presenters;
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
using QLCHWF.CustomMessageBox;
using QLCHWF.Models;
using QLCHWF.Views.Statistics;
using MyAppContext = QLCHWF.Models.MyAppContext;

namespace QLCHWF
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            //var _host = CreateHostBuilder(args).Build();
            _host = CreateHostBuilder(args).Build();
            _host.Start();
            var presenterTypes =
                Assembly.GetExecutingAssembly().GetTypes().Where(t => t.Name.Contains("Presenter") && t.IsClass && !t.IsAbstract);
            foreach (var type in presenterTypes)
            {
                _host.Services.GetRequiredService(type);
            }

            try
            {
                Application.Run((Form)_host.Services.GetRequiredService<IViewLogin>());
            }
            catch (Exception e)
            {
                MyMessageBox.Show($"Lỗi: {e.Message}");
            }
            finally
            {
                _host.StopAsync().GetAwaiter().GetResult();
                _host.Dispose();
            }
        }

        public static IHost _host;
        static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args).ConfigureHostConfiguration(config =>
            {
                config.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
                config.AddEnvironmentVariables();
            }).ConfigureServices((hostContext,services) =>
            {
                services.Configure<EmailSetting>(hostContext.Configuration.GetSection("EmailSettings"));
                services.AddDbContext<MyAppContext>();
                services.AddSingleton<IViewMain, frmMain>();
                services.AddSingleton<IViewCustomer, frmViewCustomer>();
                services.AddSingleton<IAddCustomer, frmAddCustomer>();
                services.AddSingleton<IUpdateCustomer, frmUpdateCustomer>();
                services.AddSingleton<IViewEmployee, frmViewEmployee>();
                services.AddSingleton<IAddEmployee, frmAddEmployee>();
                services.AddSingleton<IUpdateEmployee, frmUpdateEmployee>();
                services.AddSingleton<IViewSalary, frmViewSalary>();
                services.AddSingleton<IViewProduct, frmViewProduct>();
                services.AddSingleton<IAddProduct, frmAddProduct>();
                services.AddSingleton<IUpdateProduct, frmUpdateProduct>();
                services.AddSingleton<IViewProvider, frmViewProvider>();
                services.AddSingleton<IAddProvider, frmAddProvider>();
                services.AddSingleton<IUpdateProvider, frmUpdateProvider>();
                services.AddSingleton<IViewSalesOrder, frmViewSalesOrder>();
                services.AddSingleton<IAddSalesOrder, frmAddSalesOrder>();
                services.AddSingleton<IDetailSalesOrder, frmViewDetailSales>();
                services.AddSingleton<IReportSalesOrder, frmReportSalesOrder>();
                services.AddSingleton<IViewImportOrder, frmViewImportOrder>();
                services.AddSingleton<IAddImportOrder, frmAddImportOrder>();
                services.AddSingleton<IDetailImportOrder, frmViewDetailImport>();
                services.AddSingleton<IReportImportOrder, frmReportImportOrder>();
                services.AddSingleton<IViewUser, frmViewUser>();
                services.AddSingleton<IUpdatePassword, frmUpdatePassword>();
                services.AddSingleton<IChangePassword, frmChangePassword>();
                services.AddSingleton<IViewUserRole, frmViewUserRole>();
                services.AddSingleton<IAddUserRole, frmAddUserRole>();
                services.AddSingleton<IUpdateUserRole, frmUpdateUserRole>();
                services.AddSingleton<IViewOptions, frmViewOptions>();
                services.AddSingleton<IViewStatistics, frmStatistics>();
                services.AddSingleton<IAppInfo, frmAppInfo>();
                services.AddSingleton<IViewLogin, frmLogin>();
                services.AddSingleton<IHistoryImport, frmHistoryImportOrder>();
                services.AddSingleton<IHistorySales, frmHistorySalesOrder>();
                services.AddSingleton<AuthPresenter>();
                services.AddSingleton<CustomerPresenter>();
                services.AddSingleton<EmployeePresenter>();
                services.AddSingleton<ProductPresenter>();
                services.AddSingleton<ProviderPresenter>();
                services.AddSingleton<SalesOrderPresenter>();
                services.AddSingleton<ImportOrderPresenter>();
                services.AddSingleton<UserRolePresenter>();
                services.AddSingleton<OptionsPresenter>();
                services.AddSingleton<StatisticsPresenter>();
                services.AddSingleton<MainPresenter>();

            });
        }

        public static void DecimalPressed(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}