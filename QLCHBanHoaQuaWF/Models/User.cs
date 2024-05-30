using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLCHWF.Models
{
    [Table("User")]
    public class User
    {
        [DisplayName("Mã nhân viên")]
        public int EmployeeID { get; set; }
        [ForeignKey("EmployeeID")]
        public virtual Employee Employee { get; set; }
        [Required(ErrorMessage = "Email không được để trống")]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Email không hợp lệ")]
        [StringLength(50,ErrorMessage = "Email không dài quá 50 ký tự")]
        [DisplayName("Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Mật khẩu không được để trống")]
        [MinLength(8, ErrorMessage = "Mật khẩu phải dài ít nhất 8 ký tự.")]
        [DisplayName("Mật khẩu")]
        public string Password { get; set; }
        [DisplayName("Lần cuối đăng nhập")]
        public DateTime LastLogin { get; set; }

        public bool Lock { get; set; } = false;
        [DisplayName("Mã vai trò")]
        public int RoleID { get; set; }
        [ForeignKey("RoleID")]
        public virtual UserRole UserRole { get; set; } = null!;
    }
}
