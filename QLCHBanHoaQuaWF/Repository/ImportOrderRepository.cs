using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using QLCHWF.IRepository;
using QLCHWF.Models;
using QLCHWF.Views.SalesOrder;

namespace QLCHWF.Repository;

public class ImportOrderRepository:GenericRepository<ImportOrder>,IImportOrderRepository
{
    private readonly MyAppContext _context;
    public ImportOrderRepository(MyAppContext context) : base(context)
    {
        _context = context;
    }

    public bool AddOrder(ImportOrder order, List<DetailImportOrder> detailImportOrders)
    {
        using (var transaction = _context.Database.BeginTransaction())
        {
            try
            {
                _context.ImportOrders.Add(order);
                _context.SaveChanges();
                foreach (var detailImportOrder in detailImportOrders)
                {
                    Product product = _context.Products.Find(detailImportOrder.ProductID)!;
                    product.Inventory += detailImportOrder.Quantity;
                    _context.DetailImportOrders.Add(detailImportOrder);
                }

                _context.SaveChanges();
                transaction.Commit();
                return true;
            }
            catch (Exception)
            {
                transaction.Rollback();
                return false;
            }
        }
    }

    public OrderImportData? GetOrderData(int orderId)
    {
        return (from s in _context.ImportOrders
            join p in _context.Providers on s.ProviderID equals p.ProviderID
            where s.OrderID == orderId
            select new OrderImportData
            {
                DateCreated = s.OrderDate,
                OrderID = s.OrderID,
                ProviderName = p.ProviderName,
                TotalPrice = s.TotalPrice
            }).FirstOrDefault();
    }

    public List<OrderDetailData> GetOrderDetailData(int orderId)
    {
        return (from d in _context.DetailImportOrders
            join p in _context.Products
                on d.ProductID equals p.ProductID
            where d.OrderID == orderId
            select new OrderDetailData()
            {
                ProductName = p.ProductName,
                Quantity = d.Quantity + " " + p.CalculationUnit,
                UnitPrice = d.UnitPrice.ToString("C0"),
                TotalPrice = d.TotalPrice.ToString("C0")
            }).ToList();
    }

    public async Task<OrderImportData?> GetOrderDataAsync(int orderId)
    {
        return await (from s in _context.ImportOrders
            join p in _context.Providers on s.ProviderID equals p.ProviderID
            where s.OrderID == orderId
            select new OrderImportData
            {
                DateCreated = s.OrderDate,
                OrderID = s.OrderID,
                ProviderName = p.ProviderName,
                TotalPrice = s.TotalPrice
            }).FirstOrDefaultAsync();
    }

    public async Task<List<OrderDetailData>> GetOrderDetailDataAsync(int orderId)
    {
        return await (from d in _context.DetailImportOrders
            join p in _context.Products
                on d.ProductID equals p.ProductID
            where d.OrderID == orderId
            select new OrderDetailData()
            {
                ProductName = p.ProductName,
                Quantity = d.Quantity + " " + p.CalculationUnit,
                UnitPrice = d.UnitPrice.ToString("C0"),
                TotalPrice = d.TotalPrice.ToString("C0")
            }).ToListAsync();
    }

    public ImportOrder? GetOrderWithDetail(int orderId)
    {
        return _context.ImportOrders.Include(o => o.DetailImportOrders).ToList().FirstOrDefault(x=>x.OrderID == orderId);
    }

    public IEnumerable<ImportOrder> GetOrdersInclue<TProperty>(Expression<Func<ImportOrder, TProperty>> selector, Expression<Func<ImportOrder, bool>> match)
    {
        return _context.ImportOrders.Include(selector).Where(match);
    }
}