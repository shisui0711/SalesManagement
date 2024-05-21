using QLCHWF.Models;

namespace QLCHWF.IRepository;

public interface ISalesOrderRepository :IGenericRepository<SalesOrder>
{
    public OrderData GetOrderData(int orderId);
    public OrderDetailData GetOrderDetailData(int orderId);
    public SalesOrder GetOrderWithDetail(int orderId);
}