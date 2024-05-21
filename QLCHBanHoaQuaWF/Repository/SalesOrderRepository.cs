using Microsoft.EntityFrameworkCore;
using QLCHWF.IRepository;
using QLCHWF.Models;

namespace QLCHWF.Repository;

public class SalesOrderRepository:GenericRepository<SalesOrder>,ISalesOrderRepository
{
    private readonly MyAppContext _context;
    public SalesOrderRepository(MyAppContext context) : base(context)
    {
        _context = context;
    }

    public OrderData GetOrderData(int orderId)
    {
        throw new NotImplementedException();
    }

    public OrderDetailData GetOrderDetailData(int orderId)
    {
        throw new NotImplementedException();
    }

    public SalesOrder GetOrderWithDetail(int orderId)
    {
       return _context.SalesOrders.Include(o => o.DetailSalesOrders).First(o => o.OrderID == orderId);
    }
}