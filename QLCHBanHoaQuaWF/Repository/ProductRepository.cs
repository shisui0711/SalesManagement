using QLCHWF.IRepository;
using QLCHWF.Models;

namespace QLCHWF.Repository;

public class ProductRepository : GenericRepository<Product>,IProductRepository
{
    private readonly MyAppContext _context;
    public ProductRepository(MyAppContext context) : base(context)
    {
        _context = context;
    }

    public List<KeyValuePair<string, int>> GetTopProduct(DateTime start, DateTime end)
    {
        return (from p in _context.Products.ToList()
            join detail in _context.DetailSalesOrders on p.ProductID equals detail.ProductID
            join sales in _context.SalesOrders on detail.OrderID equals sales.OrderID
            where sales.OrderDate >= start && sales.OrderDate <= end
            group detail by new { p.ProductID, p.ProductName }
            into g
            orderby g.Sum(x => x.Quantity) descending
            select new KeyValuePair<string,int>(g.Key.ProductName, g.Sum(x => x.Quantity))
            ).ToList();
    }
}