using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLCHBanHoaQuaWF.Models;

public class UserRole
{
    public UserRole(int roleId, string roleName, string description, Permission permission)
    {
        RoleID = roleId;
        RoleName = roleName ?? throw new ArgumentNullException(nameof(roleName));
        Description = description ?? throw new ArgumentNullException(nameof(description));
        Permission = permission ?? throw new ArgumentNullException(nameof(permission));
    }

    public UserRole()
    {

    }

    [Key]
    public int RoleID { get; set; }
    [Required]
    public string RoleName { get; set; }
    public DateTime DateCreated { get; set; } = DateTime.Now;
    public string? Description { get; set; }
    public virtual Permission Permission { get; set; }
    [InverseProperty("UserRole")]
    public virtual ICollection<User> Users { get; set; }

    public override string ToString()
    {
        return RoleName;
    }
}