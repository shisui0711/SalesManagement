using QLCHWF.Models;
using System.Linq.Expressions;

namespace QLCHWF.IRepository;

public interface IUserRoleRepository: IGenericRepository<UserRole>
{
    public bool AddUserRoleWithPermission(UserRole userRole, Permission permission);

    public bool UpdatePermission(Permission permission);
    public Permission GetPermission(object key);
}