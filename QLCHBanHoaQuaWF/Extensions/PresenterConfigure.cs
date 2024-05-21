using Microsoft.Extensions.DependencyInjection;
using QLCHWF.Presenters;

namespace QLCHWF.Extensions;

public static class PresenterConfigure
{
    public static void AddPresenter(this IServiceCollection services)
    {
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
    }
}