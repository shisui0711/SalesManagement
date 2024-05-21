using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QLCHWF.Models
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeeID { get; set; }
        [Required(ErrorMessage = "Tên không được để trống")]
        [Column(TypeName = "nvarchar")]
        [StringLength(30)]
        public string EmployeeName { get; set; }
        [Required(ErrorMessage = "Email không được để trống")]
        [EmailAddress(ErrorMessage = "Vui lòng nhập đúng định dạng email")]
        [StringLength(50)]
        public string Email { get; set; }
        [RegularExpression(@"0\d{9}", ErrorMessage = "Vui lòng nhập đúng định dạng số điện thoại")]
        [StringLength(10)]
        public string Phone { get; set; }
        [StringLength(50)]
        public string? Address { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal? Salary { get; set; }
        [Column(TypeName = "date")]
        public DateTime DateCreated { get; set; } = DateTime.Now;
        [InverseProperty("Employee")]
        public virtual ICollection<SalesOrder> SalesOrders { get; set; } = new List<SalesOrder>();
        [InverseProperty("Employee")]
        public virtual ICollection<ImportOrder> ImportOrders { get; set; } = new List<ImportOrder>();

        public override string ToString()
        {
            return EmployeeName;
        }
        [NotMapped]
        public string NameWithId
        {
            get { return EmployeeID + "-" + EmployeeName; }
        }
    }
}
