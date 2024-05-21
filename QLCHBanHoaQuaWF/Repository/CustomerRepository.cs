using Microsoft.EntityFrameworkCore;
using QLCHWF.IRepository;
using QLCHWF.Models;

namespace QLCHWF.Repository;

public class CustomerRepository : GenericRepository<Customer>,ICustomerRepository
{
    private readonly MyAppContext _context;
    public CustomerRepository(MyAppContext context) : base(context)
    {
        _context = context;
    }

    public Customer GetCustomerWithSalesOrder(int id)
    {
        return _context.Customers.Include(c => c.SalesOrders)
            .First(c => c.CustomerID == id);
    }
}