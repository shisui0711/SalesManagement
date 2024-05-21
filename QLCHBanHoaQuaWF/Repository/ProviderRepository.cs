using QLCHWF.IRepository;
using QLCHWF.Models;

namespace QLCHWF.Repository;

public class ProviderRepository:GenericRepository<Provider>,IProviderRepository
{
    public ProviderRepository(MyAppContext context) : base(context)
    {
    }

    public Provider GetProviderWithImportOrder(int id)
    {
        throw new NotImplementedException();
    }
}