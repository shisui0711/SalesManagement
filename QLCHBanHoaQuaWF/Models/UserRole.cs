using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLCHWF.Models;

[Table("UserRole")]
public class UserRole
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int RoleID { get; set; }
    [Required(ErrorMessage = "Tên vai trò không được để trống")]
    [StringLength(30,ErrorMessage = "Tên vai trò không dài quá 30 ký tự")]
    public string RoleName { get; set; }
    [Column(TypeName = "date")]
    public DateTime DateCreated { get; set; } = DateTime.Now;
    [StringLength(100,ErrorMessage = "Ghi chú không dài quá 100 ký tự")]
    public string? Description { get; set; }
    public int PermissionID { get; set; }
    [ForeignKey("PermissionID")]
    public virtual Permission Permission { get; set; } = null!;

    [InverseProperty("UserRole")]
    public virtual ICollection<User> Users { get; set; }

    public override string ToString()
    {
        return RoleName;
    }
}