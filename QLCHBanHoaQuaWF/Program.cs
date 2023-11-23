using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OfficeOpenXml;
using QLCHBanHoaQuaWF.Presenters;
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
using MyAppContext = QLCHBanHoaQuaWF.Models.MyAppContext;

namespace QLCHBanHoaQuaWF
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
            var _host = CreateHostBuilder(args).Build();
            _host.Start();
            var presenterTypes =
                Assembly.GetExecutingAssembly().GetTypes().Where(t => t.Name.Contains("Presenter") && t.IsClass && !t.IsAbstract);
            foreach (var type in presenterTypes)
            {
                _host.Services.GetRequiredService(type);
            }

            Application.Run((Form)_host.Services.GetRequiredService<IViewLogin>());
            _host.StopAsync().GetAwaiter().GetResult();
            _host.Dispose();
        }

        static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args).ConfigureHostConfiguration(config =>
            {
                config.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
                config.AddEnvironmentVariables();
            }).ConfigureServices((services) =>
            {
                services.AddDbContext<MyAppContext>();
                services.AddSingleton<IViewMain, frmMain>();
                services.AddSingleton<IViewCustomer, frmViewCustomer>();
                services.AddSingleton<IAddCustomer, frmAddCustomer>();
                services.AddSingleton<IUpdateCustomer, frmUpdateCustomer>();
                services.AddSingleton<IViewEmployee, frmViewEmployee>();
                services.AddSingleton<IAddEmployee, frmAddEmployee>();
                services.AddSingleton<IUpdateEmployee, frmUpdateEmployee>();
                services.AddSingleton<IViewProduct, frmViewProduct>();
                services.AddSingleton<IAddProduct, frmAddProduct>();
                services.AddSingleton<IUpdateProduct, frmUpdateProduct>();
                services.AddSingleton<IViewProvider, frmViewProvider>();
                services.AddSingleton<IAddProvider, frmAddProvider>();
                services.AddSingleton<IUpdateProvider, frmUpdateProvider>();
                services.AddSingleton<IViewSalesOrder, frmViewSalesOrder>();
                services.AddSingleton<IAddSalesOrder, frmAddSalesOrder>();
                services.AddSingleton<IReportSalesOrder, frmReportSalesOrder>();
                services.AddSingleton<IViewImportOrder, frmViewImportOrder>();
                services.AddSingleton<IAddImportOrder, frmAddImportOrder>();
                services.AddSingleton<IReportImportOrder, frmReportImportOrder>();
                services.AddSingleton<IViewUser, frmViewUser>();
                services.AddSingleton<IChangePassword, frmChangePassword>();
                services.AddSingleton<IViewUserRole, frmViewUserRole>();
                services.AddSingleton<IAddUserRole, frmAddUserRole>();
                services.AddSingleton<IUpdateUserRole, frmUpdateUserRole>();
                services.AddSingleton<IViewOptions, frmViewOptions>();
                services.AddSingleton<IAppInfo, frmAppInfo>();
                services.AddSingleton<IViewLogin, frmLogin>();
                services.AddSingleton<AuthPresenter>();
                services.AddSingleton<CustomerPresenter>();
                services.AddSingleton<EmployeePresenter>();
                services.AddSingleton<ProductPresenter>();
                services.AddSingleton<ProviderPresenter>();
                services.AddSingleton<SalesOrderPresenter>();
                services.AddSingleton<ImportOrderPresenter>();
                services.AddSingleton<UserRolePresenter>();
                services.AddSingleton<OptionsPresenter>();
                services.AddSingleton<MainPresenter>();

            });
        }
    }
}