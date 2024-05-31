using QLCHWF.Models;

namespace QLCHWF.IRepository;

public interface IProviderRepository : IGenericRepository<Provider>
{
    public Provider? GetProviderWithImportOrder(int id);
}