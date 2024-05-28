using QLCHWF.Models;

namespace QLCHWF.IRepository;

public interface ICustomerRepository:IGenericRepository<Customer>
{
    public Customer GetCustomerWithSalesOrder(int id);
    public List<TopCustomer> GetTopCustomers(DateTime start, DateTime end);
}