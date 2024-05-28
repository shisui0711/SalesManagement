using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using QLCHWF.IRepository;
using QLCHWF.Models;

namespace QLCHWF.Repository;

public class UserRepository : GenericRepository<User>, IUserRepository
{
    private readonly MyAppContext _context;
    public UserRepository(MyAppContext context) : base(context)
    {
        _context = context;
    }

    public IEnumerable<User> GetUserInclue<TProperty>(Expression<Func<User, TProperty>> selector, Expression<Func<User, bool>> match)
    {
        return _context.Users.Include(selector).Where(match);
    }

    public User? GetUserWithPermission(string username)
    {
        return _context.Users.Include(u => u.UserRole).ThenInclude(u => u.Permission)
            .FirstOrDefault(x => x.Email == username);
    }
}