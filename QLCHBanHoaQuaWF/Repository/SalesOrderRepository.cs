using System.Linq.Expressions;
using Bogus.DataSets;
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

    public bool AddOrder(SalesOrder order, List<DetailSalesOrder> detailSalesOrders)
    {
        using (var transaction = _context.Database.BeginTransaction())
        {
            try
            {
                _context.SalesOrders.Add(order);
                _context.SaveChanges();
                foreach (var detailSalesOrder in detailSalesOrders)
                {
                    Product product = _context.Products.Find(detailSalesOrder.ProductID)!;
                    product.Inventory -= detailSalesOrder.Quantity;
                    _context.DetailSalesOrders.Add(detailSalesOrder);
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

    public OrderData? GetOrderData(int orderId)
    {
        return (from s in _context.SalesOrders
            join c in _context.Customers on s.CustomerID equals c.CustomerID
            where s.OrderID == orderId
            select new OrderData()
            {
                DateCreated = s.OrderDate,
                OrderID = s.OrderID,
                CustomerName = c.CustomerName,
                CustomerAddress = c.Address,
                CustomerPhone = c.Phone,
                TotalPrice = s.TotalPrice,
                PurchasePrice = s.PurchasePrice
            }).ToList().FirstOrDefault();
    }

    public async Task<OrderData?> GetOrderDataAsync(int orderId)
    {
        return await (from s in _context.SalesOrders
            join c in _context.Customers on s.CustomerID equals c.CustomerID
            where s.OrderID == orderId
            select new OrderData()
            {
                DateCreated = s.OrderDate,
                OrderID = s.OrderID,
                CustomerName = c.CustomerName,
                CustomerAddress = c.Address,
                CustomerPhone = c.Phone,
                TotalPrice = s.TotalPrice,
                PurchasePrice = s.PurchasePrice
            }).FirstOrDefaultAsync();
    }
    public async Task<List<OrderDetailData>> GetOrderDetailDataAsync(int orderId)
    {
        return await (from d in _context.DetailSalesOrders
            join p in _context.Products
                on d.ProductID equals p.ProductID
            where d.OrderID == orderId
            select new OrderDetailData
            {
                ProductName = p.ProductName,
                Quantity = d.Quantity+ " " + p.CalculationUnit,
                UnitPrice = d.UnitPrice.ToString("C0"),
                TotalPrice = d.TotalPrice.ToString("C0")
            }).ToListAsync();
    }
    public List<OrderDetailData?> GetOrderDetailData(int orderId)
    {
        return (from d in _context.DetailSalesOrders
            join p in _context.Products
                on d.ProductID equals p.ProductID
            where d.OrderID == orderId
            select new OrderDetailData
            {
                ProductName = p.ProductName,
                Quantity = d.Quantity.ToString() + " " + p.CalculationUnit,
                UnitPrice = d.UnitPrice.ToString("C0"),
                TotalPrice = d.TotalPrice.ToString("C0")
            }).ToList();
    }

    public SalesOrder? GetOrderWithDetail(int orderId)
    {
        return _context.SalesOrders.Include(o => o.DetailSalesOrders).ToList().FirstOrDefault(x=>x.OrderID== orderId);
    }

    public IEnumerable<SalesOrder> GetOrdersInclue<TProperty>(Expression<Func<SalesOrder, TProperty>> selector, Expression<Func<SalesOrder, bool>> match)
    {
        return _context.SalesOrders.Include(selector).Where(match);
    }

    public decimal GetRevenue(DateTime start, DateTime end)
    {
        return (from sales in _context.SalesOrders
            join detail in _context.DetailSalesOrders on sales.OrderID equals detail.OrderID
            join product in _context.Products on detail.ProductID equals product.ProductID
            where sales.OrderDate >= start && sales.OrderDate <= end
                select detail.Quantity * product.UnitPrice).Sum();
    }

    public decimal GetBudget(DateTime start, DateTime end)
    {
        return (from sales in _context.SalesOrders
            join detail in _context.DetailSalesOrders on sales.OrderID equals detail.OrderID
            join product in _context.Products on detail.ProductID equals product.ProductID
            where sales.OrderDate >= start && sales.OrderDate <= end
            select detail.Quantity * product.ImportUnitPrice).Sum();
    }

    public List<KeyValuePair<DateTime, decimal>> GetRevenueData(DateTime start, DateTime end)
    {
        return (from sales in _context.SalesOrders
            join detail in _context.DetailSalesOrders on sales.OrderID equals detail.OrderID
            join product in _context.Products on detail.ProductID equals product.ProductID
            where sales.OrderDate >= start && sales.OrderDate <= end
            group new { sales.OrderDate, product.UnitPrice, detail.Quantity } by sales.OrderDate
            into g
            select new KeyValuePair<DateTime, decimal>(
                g.Key,
                g.Sum(x => x.Quantity * x.UnitPrice)
            )).ToList();
    }

    public List<KeyValuePair<DateTime, decimal>> GetBudgetData(DateTime start, DateTime end)
    {
       return  (from sales in _context.SalesOrders
            join detail in _context.DetailSalesOrders on sales.OrderID equals detail.OrderID
            join product in _context.Products on detail.ProductID equals product.ProductID
            where sales.OrderDate >= start && sales.OrderDate <= end
            group new { sales.OrderDate, product.ImportUnitPrice, detail.Quantity } by sales.OrderDate
            into g
            select new KeyValuePair<DateTime, decimal>(
                g.Key,
                g.Sum(x => x.Quantity * x.ImportUnitPrice)
            )).ToList();
    }
}