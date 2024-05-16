using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLCHWF.Models
{
    [Table("User")]
    public class User
    {
        public User(int employeeId, Employee employee, string email, string password, int roleId, UserRole userRole)
        {
            EmployeeID = employeeId;
            Employee = employee;
            Email = email;
            Password = password;
            RoleID = roleId;
            UserRole = userRole;
        }

        public User()
        {

        }
        [DisplayName("Mã nhân viên")]
        public int EmployeeID { get; set; }
        [ForeignKey("EmployeeID")]
        public Employee Employee { get; set; }
        [Required(ErrorMessage = "Email không được để trống")]
        [EmailAddress(ErrorMessage = "Email không hợp lệ")]
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
        public UserRole UserRole { get; set; }


    }
}
