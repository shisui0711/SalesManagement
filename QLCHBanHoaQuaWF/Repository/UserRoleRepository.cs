using QLCHWF.IRepository;
using QLCHWF.Models;

namespace QLCHWF.Repository;

public class UserRoleRepository : GenericRepository<UserRole>,IUserRoleRepository
{
    private readonly MyAppContext _context;
    public UserRoleRepository(MyAppContext context) : base(context)
    {
        _context = context;
    }

    public void AddUserRoleWithPermission(UserRole userRole, Permission permission)
    {
        using (var transaction = _context.Database.BeginTransaction())
        {
            try
            {
                _context.Add(userRole);
                permission.UserRole = userRole;
                _context.Add(permission);
                transaction.Commit();
            }
            catch (Exception e)
            {
                transaction.Rollback();
            }
        }
    }

    public void UpdatePermission(Permission permission)
    {
        _context.Update(permission);
    }

    public Permission GetPermission(object key)
    {
        return _context.Find<Permission>(key);
    }
}