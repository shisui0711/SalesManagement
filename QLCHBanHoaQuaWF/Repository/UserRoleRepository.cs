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

    public bool AddUserRoleWithPermission(UserRole userRole, Permission permission)
    {
        using (var transaction = _context.Database.BeginTransaction())
        {
            try
            {
                
                _context.Add(permission);
                _context.SaveChanges();
                userRole.Permission = permission;
                _context.Add(userRole);
                _context.SaveChanges();
                transaction.Commit();
                return true;
            }
            catch
            {
                transaction.Rollback();
                return false;
            }
        }
    }

    public bool UpdateRoleWithPermission(UserRole userRole,Permission permission)
    {
        using (var transaction = _context.Database.BeginTransaction())
        {
            try
            {
                _context.Update(userRole);
                _context.Update(permission);
                _context.SaveChanges();
                transaction.Commit();
                return true;
            }
            catch (Exception)
            {
                transaction.Rollback();
                return false;
            }
        }
        
    }

    public Permission? GetPermission(object? key)
    {
        return _context.Find<Permission>(key);
    }
}