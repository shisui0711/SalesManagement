using QLCHWF.IRepository;
using QLCHWF.Models;

namespace QLCHWF.Repository;

public class ImportOrderRepository:GenericRepository<ImportOrder>,IImportOrderRepository
{
    public ImportOrderRepository(MyAppContext context) : base(context)
    {
    }
}