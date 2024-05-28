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

    public List<TopCustomer> GetTopCustomers(DateTime start, DateTime end)
    {
        return (from c in _context.Customers
            join sales in _context.SalesOrders
                on c.CustomerID equals sales.CustomerID
            where sales.OrderDate >= start && sales.OrderDate <= end
            group sales by new { c.CustomerID, c.CustomerName }
            into g
            orderby g.Count() descending
            select new TopCustomer
            {
                CustomerID = g.Key.CustomerID,
                CustomerName = g.Key.CustomerName,
                TotalBought = g.Count()
            }).ToList();
    }
}