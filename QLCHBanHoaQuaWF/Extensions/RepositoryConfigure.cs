using Microsoft.Extensions.DependencyInjection;
using QLCHWF.IRepository;
using QLCHWF.Repository;

namespace QLCHWF.Extensions;

public static class RepositoryConfigure
{
    public static void AddRepository(this IServiceCollection services)
    {
        services.AddScoped<ICustomerRepository, CustomerRepository>();
        services.AddScoped<IEmployeeRepository, EmployeeRepository>();
        services.AddScoped<IProviderRepository, ProviderRepository>();
        services.AddScoped<IProductRepository, ProductRepository>();
        services.AddScoped<ISalesOrderRepository, SalesOrderRepository>();
        services.AddScoped<IImportOrderRepository, ImportOrderRepository>();
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IAppInfoRepository, AppInfoRepository>();
        services.AddScoped<IUserRoleRepository, UserRoleRepository>();
    }
}