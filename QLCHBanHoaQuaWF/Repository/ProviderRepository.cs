using Microsoft.EntityFrameworkCore;
using QLCHWF.IRepository;
using QLCHWF.Models;

namespace QLCHWF.Repository;

public class ProviderRepository:GenericRepository<Provider>,IProviderRepository
{
    private readonly MyAppContext _context;
    public ProviderRepository(MyAppContext context) : base(context)
    {
        _context = context;
    }

    public Provider? GetProviderWithImportOrder(int id)
    {
        return _context.Providers.Include(x => x.ImportOrders).FirstOrDefault(x => x.ProviderID == id);
    }
}