﻿#nullable enable
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLCHWF.Models
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("Mã nhân viên")]
        public int EmployeeID { get; set; }
        [Required(ErrorMessage = "Tên không được để trống")]
        [Column(TypeName = "nvarchar")]
        [StringLength(30)]
        [DisplayName("Tên nhân viên")]
        public string EmployeeName { get; set; }
        [Required(ErrorMessage = "Email không được để trống")]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Vui lòng nhập đúng định dạng email")]
        [StringLength(50)]
        [DisplayName("Email")]
        public string Email { get; set; }
        [RegularExpression(@"0\d{9}", ErrorMessage = "Vui lòng nhập đúng định dạng số điện thoại")]
        [StringLength(10)]
        [Required(ErrorMessage = "Số điện thoại không được để trống")]
        [DisplayName("Số điện thoại")]
        public string Phone { get; set; }
        [StringLength(50)]
        [DisplayName("Địa chỉ")]
        public string? Address { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        [Range(0,1000000000,ErrorMessage = "Lương phải lơn hơn 0 và không vượt quá giới hạn")]
        [DisplayName("Lương cơ bản")]
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
