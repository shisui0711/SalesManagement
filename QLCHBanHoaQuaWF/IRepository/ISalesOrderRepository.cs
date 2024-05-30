using System.Linq.Expressions;
using QLCHWF.Models;

namespace QLCHWF.IRepository;

public interface ISalesOrderRepository :IGenericRepository<SalesOrder>
{
    public bool AddOrder(SalesOrder order, List<DetailSalesOrder> detailSalesOrders);
    public OrderData? GetOrderData(int orderId);
    public List<OrderDetailData> GetOrderDetailData(int orderId);
    public Task<OrderData?> GetOrderDataAsync(int orderId);
    public Task<List<OrderDetailData>> GetOrderDetailDataAsync(int orderId);
    public SalesOrder? GetOrderWithDetail(int orderId);
    public IEnumerable<SalesOrder> GetOrdersInclue<TProperty>(Expression<Func<SalesOrder, TProperty>> selector, Expression<Func<SalesOrder, bool>> match);
    public decimal GetRevenue(DateTime start, DateTime end);
    public decimal GetBudget(DateTime start, DateTime end);
    public List<KeyValuePair<DateTime, decimal>> GetRevenueData(DateTime start,DateTime end);
    public List<KeyValuePair<DateTime, decimal>> GetBudgetData(DateTime start, DateTime end);
}