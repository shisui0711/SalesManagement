using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHBanHoaQuaWF.Models
{
    [Table("Customer")]
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CustomerID { get; set; }
        [Required(ErrorMessage = "Tên không được để trống")]
        [StringLength(30)]
        public string CustomerName { get; set; }
        [EmailAddress(ErrorMessage = "Vui lòng nhập đúng định dạng email")]
        [StringLength(50)]
        public string Email { get; set; }
        [RegularExpression(@"0\d{9}",ErrorMessage = "Vui lòng nhập đúng định dạng số điện thoại")]
        public string Phone { get; set; }
        [StringLength(50)]
        public string  Address { get; set; }
        [Column(TypeName = "date")]
        public DateTime DateCreated { get; set; } = DateTime.Now;
        [InverseProperty("Customer")]
        public virtual ICollection<SalesOrder> SalesOrders { get; set; } = new List<SalesOrder>();
    }
}
