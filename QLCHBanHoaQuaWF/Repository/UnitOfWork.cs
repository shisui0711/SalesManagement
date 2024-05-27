using QLCHWF.IRepository;
using QLCHWF.Models;

namespace QLCHWF.Repository;

public class UnitOfWork : IUnitOfWork, IDisposable
{
    private readonly MyAppContext _context;
    private readonly Lazy<IAppInfoRepository> _appInfos;
    private readonly Lazy<ICustomerRepository> _customers;
    private readonly Lazy<IEmployeeRepository> _employees;
    private readonly Lazy<IImportOrderRepository> _importOrders;
    private readonly Lazy<IProductRepository> _products;
    private readonly Lazy<IProviderRepository> _providers;
    private readonly Lazy<ISalesOrderRepository> _salesOrder;
    private readonly Lazy<IUserRepository> _users;
    private readonly Lazy<IUserRoleRepository> _userRoles;
    public UnitOfWork(MyAppContext context)
    {
        _context = context;
        _appInfos = new Lazy<IAppInfoRepository>(() => new AppInfoRepository(_context));
        _customers = new Lazy<ICustomerRepository>(() => new CustomerRepository(_context));
        _employees = new Lazy<IEmployeeRepository>(() => new EmployeeRepository(_context));
        _importOrders = new Lazy<IImportOrderRepository>(() => new ImportOrderRepository(_context));
        _products = new Lazy<IProductRepository>(() => new ProductRepository(_context));
        _providers = new Lazy<IProviderRepository>(() => new ProviderRepository(_context));
        _salesOrder = new Lazy<ISalesOrderRepository>(() => new SalesOrderRepository(_context));
        _users = new Lazy<IUserRepository>(() => new UserRepository(_context));
        _userRoles = new Lazy<IUserRoleRepository>(() => new UserRoleRepository(_context));
    }
    public void Dispose()
    {
        _context.Dispose();
    }

    public IAppInfoRepository AppInfos
    {
        get { return _appInfos.Value; }
    }

    public ICustomerRepository Customers
    {
        get { return _customers.Value; }
    }
    public IEmployeeRepository Employees
    {
        get { return _employees.Value; }
    }
    public IImportOrderRepository ImportOrders
    {
        get { return _importOrders.Value; }
    }
    public IProductRepository Products
    {
        get { return _products.Value; }
    }
    public IProviderRepository Providers
    {
        get { return _providers.Value; }
    }
    public ISalesOrderRepository SalesOrders
    {
        get { return _salesOrder.Value; }
    }
    public IUserRepository Users
    {
        get { return _users.Value; }
    }
    public IUserRoleRepository UserRoles
    {
        get { return _userRoles.Value; }
    }
    public int SaveChanges()
    {
       return _context.SaveChanges();
    }

    public async Task<int> SaveChangesAsync()
    {
       return await _context.SaveChangesAsync();
    }
}