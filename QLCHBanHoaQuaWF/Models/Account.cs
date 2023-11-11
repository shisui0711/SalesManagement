using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHBanHoaQuaWF.Models
{
    public class Account
    {
        public int EmployeeID { get; set; }
        [ForeignKey("EmployeeID")]
        public Employee Employee { get; set; }
        [EmailAddress]
        [StringLength(50)]
        public string Email { get; set; }
        [Required(ErrorMessage = "Tên không được để trống")]
        [Column(TypeName = "nvarchar")]
        [StringLength(30)]
        public string Name { get; set; }
        [MinLength(8,ErrorMessage = "Mật khẩu phải dài ít nhất 8 ký tự.")]
        public string Password { get; set; }
        [RegularExpression(@"Quản lý|Nhân viên")]
        public string Role { get; set; }
        
    }
}
