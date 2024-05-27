using QLCHWF.Models;
using System.Linq.Expressions;

namespace QLCHWF.IRepository;

public interface IImportOrderRepository:IGenericRepository<ImportOrder>
{
    public bool AddOrder(ImportOrder order, List<DetailImportOrder> detailImportOrders);
    public OrderImportData GetOrderData(int orderId);
    public List<OrderDetailData> GetOrderDetailData(int orderId);
    public Task<OrderImportData> GetOrderDataAsync(int orderId);
    public Task<List<OrderDetailData>> GetOrderDetailDataAsync(int orderId);
    public ImportOrder GetOrderWithDetail(int orderId);
    public IEnumerable<ImportOrder> GetOrdersInclue<TProperty>(Expression<Func<ImportOrder, TProperty>> selector, Expression<Func<ImportOrder, bool>> match);
}