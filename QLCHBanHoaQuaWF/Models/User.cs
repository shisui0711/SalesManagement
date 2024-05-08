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
        public int EmployeeID { get; set; }
        [ForeignKey("EmployeeID")]
        public Employee Employee { get; set; }
        [Required]
        [EmailAddress]
        [StringLength(50)]
        public string Email { get; set; }
        [Required(ErrorMessage = "Mật khẩu không được để trống")]
        [MinLength(8, ErrorMessage = "Mật khẩu phải dài ít nhất 8 ký tự.")]
        public string Password { get; set; }

        public DateTime LastLogin { get; set; }

        public bool Lock { get; set; } = false;
        public int RoleID { get; set; }
        [ForeignKey("RoleID")]
        public UserRole UserRole { get; set; }


    }
}
