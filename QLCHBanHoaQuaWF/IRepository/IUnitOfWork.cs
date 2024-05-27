namespace QLCHWF.IRepository;

public interface IUnitOfWork
{
    IAppInfoRepository AppInfos { get; }
    ICustomerRepository Customers { get; }
    IEmployeeRepository Employees { get; }
    IImportOrderRepository ImportOrders { get; }
    IProductRepository Products { get; }
    IProviderRepository Providers { get; }
    ISalesOrderRepository SalesOrders { get; }
    IUserRepository Users { get; }
    IUserRoleRepository UserRoles { get; }
    int SaveChanges();
    Task<int> SaveChangesAsync();
}