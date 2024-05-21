using QLCHWF.Models;

namespace QLCHWF.IRepository;

public interface IUserRoleRepository: IGenericRepository<UserRole>
{
    public void AddUserRoleWithPermission(UserRole userRole, Permission permission);

    public void UpdatePermission(Permission permission);
    public Permission GetPermission(object key);
}