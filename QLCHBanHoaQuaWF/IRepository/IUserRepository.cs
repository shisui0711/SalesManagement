using QLCHWF.Models;
using System.Linq.Expressions;

namespace QLCHWF.IRepository;

public interface IUserRepository : IGenericRepository<User>
{
    public IEnumerable<User> GetUserInclue<TProperty>(Expression<Func<User, TProperty>> selector, Expression<Func<User, bool>> match);

    public User? GetUserWithPermission(string username);
}