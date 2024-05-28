using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OfficeOpenXml;
using QLCHWF.Views;
using System.Reflection;
using QLCHWF.CustomMessageBox;
using QLCHWF.Extensions;
using QLCHWF.IRepository;
using QLCHWF.Mapper;
using QLCHWF.Models;
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
            var _host = CreateHostBuilder(args).Build();
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

        //public static IHost Host = null!;
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
                services.AddRepository();
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