using QLCHWF.IRepository;
using QLCHWF.Models;

namespace QLCHWF.Repository;

public class ProductRepository : GenericRepository<Product>,IProductRepository
{
    public ProductRepository(MyAppContext context) : base(context)
    {
    }
}