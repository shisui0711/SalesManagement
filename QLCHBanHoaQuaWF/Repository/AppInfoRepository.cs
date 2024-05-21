using QLCHWF.IRepository;
using QLCHWF.Models;

namespace QLCHWF.Repository;

public class AppInfoRepository : GenericRepository<AppInfo>,IAppInfoRepository
{
    public AppInfoRepository(MyAppContext context) : base(context)
    {
    }

}