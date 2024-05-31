using QLCHWF.Models;

namespace QLCHWF.IRepository;

public interface IUserRoleRepository: IGenericRepository<UserRole>
{
    public bool AddUserRoleWithPermission(UserRole userRole, Permission permission);

    public bool UpdateRoleWithPermission(UserRole userRole,Permission permission);
    public Permission? GetPermission(object key);
}