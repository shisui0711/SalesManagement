using System.Linq.Expressions;
using QLCHWF.Models;

namespace QLCHWF.IRepository;

public interface ISalesOrderRepository :IGenericRepository<SalesOrder>
{
    public bool AddOrder(SalesOrder order, List<DetailSalesOrder> detailSalesOrders);
    public OrderData GetOrderData(int orderId);
    public List<OrderDetailData> GetOrderDetailData(int orderId);
    public Task<OrderData> GetOrderDataAsync(int orderId);
    public Task<List<OrderDetailData>> GetOrderDetailDataAsync(int orderId);
    public SalesOrder GetOrderWithDetail(int orderId);
    public IEnumerable<SalesOrder> GetOrdersInclue<TProperty>(Expression<Func<SalesOrder, TProperty>> selector, Expression<Func<SalesOrder, bool>> match);
}