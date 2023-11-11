using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using QLCHBanHoaQuaWF.Presenters;
using QLCHBanHoaQuaWF.Views;
using QLCHBanHoaQuaWF.Views.Customer;
using QLCHBanHoaQuaWF.Views.Employee;
using QLCHBanHoaQuaWF.Views.Product;
using QLCHBanHoaQuaWF.Views.Provider;
using AppContext = QLCHBanHoaQuaWF.Models.AppContext;

namespace QLCHBanHoaQuaWF
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            _host.Start();
            ApplicationConfiguration.Initialize();
            var authPresenter = _host.Services.GetRequiredService<AuthPresenter>();
            var customerPresenter = _host.Services.GetRequiredService<CustomerPresenter>();
            var employeePresenter = _host.Services.GetRequiredService<EmployeePresenter>();
            var productPresenter = _host.Services.GetRequiredService<ProductPresenter>();
            var providerPresenter = _host.Services.GetRequiredService<ProviderPresenter>();

            var mainControl = _host.Services.GetRequiredService<MainControl>();
            Application.Run((Form)_host.Services.GetRequiredService<IViewLogin>());
            _host.StopAsync().GetAwaiter().GetResult();
            _host.Dispose();
        }

        private static readonly IHost _host = CreateHostBuilder().Build();

        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder().ConfigureServices((services) =>
            {
                services.AddDbContext<AppContext>();
                services.AddSingleton<IViewMain,frmMain>();
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
                services.AddSingleton<IViewLogin,frmLogin>();
                services.AddSingleton<AuthPresenter>();
                services.AddSingleton<CustomerPresenter>();
                services.AddSingleton<EmployeePresenter>();
                services.AddSingleton<ProductPresenter>();
                services.AddSingleton<ProviderPresenter>();
                services.AddSingleton<MainControl>();
            });
        }
    }
}