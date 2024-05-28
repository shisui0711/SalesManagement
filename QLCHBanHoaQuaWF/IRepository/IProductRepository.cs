using QLCHWF.Models;

namespace QLCHWF.IRepository;

public interface IProductRepository :IGenericRepository<Product>
{
    public List<KeyValuePair<string, int>> GetTopProduct(DateTime start, DateTime end);
}