using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OfficeOpenXml;
using QLCHWF.Views;
using QLCHWF.CustomMessageBox;
using QLCHWF.Extensions;
using QLCHWF.IRepository;
using QLCHWF.Mapper;
using QLCHWF.Models;
using QLCHWF.Presenters;
using QLCHWF.Repository;
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
            MyHost = CreateHostBuilder(args).Build();
            MyHost.Start();
            MyHost.Services.GetRequiredService<AuthPresenter>();
            try
            {
                Application.Run((Form)MyHost.Services.GetRequiredService<IViewLogin>());
            }
            catch (Exception e)
            {
                MyMessageBox.Show($"Lỗi: {e.Message}");
            }
            finally
            {
                MyHost.StopAsync().GetAwaiter().GetResult();
                MyHost.Dispose();
            }
        }

        public static IHost MyHost = null!;
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
                services.AddAutoMapper(typeof(AutoMapperProfile).Assembly);
                services.AddView();
                services.AddPresenter();
                services.AddScoped<IUnitOfWork, UnitOfWork>();

            });
        }

        public static void DecimalPressed(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
    }
}