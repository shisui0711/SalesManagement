using QLCHWF.IRepository;
using QLCHWF.Models;

namespace QLCHWF.Repository;

public class UserRepository : GenericRepository<User>, IUserRepository
{
    public UserRepository(MyAppContext context) : base(context)
    {
    }
}