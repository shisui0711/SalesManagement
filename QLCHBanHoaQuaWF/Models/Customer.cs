using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLCHWF.Models
{
    [Table("Customer")]
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("Mã khách hàng")]
        public int CustomerID { get; set; }
        [Required(ErrorMessage = "Tên không được để trống")]
        [StringLength(30,ErrorMessage = "Tên không dài quá 30 ký tự")]
        [DisplayName("Tên khách hàng")]
        public required string CustomerName { get; set; }
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Vui lòng nhập đúng định dạng email")]
        [StringLength(50,ErrorMessage = "Email không được dài hơn 50 ký tự")]
        [DisplayName("Email")]
        public string? Email { get; set; }
        [RegularExpression(@"0\d{9}", ErrorMessage = "Vui lòng nhập đúng định dạng số điện thoại")]
        [StringLength(10)]
        [Required(ErrorMessage = "Số điện thoại không được để trống")]
        [DisplayName("Số điện thoại")]
        public required string Phone { get; set; }
        [StringLength(50,ErrorMessage = "Địa chỉ không được dài hơn 50 ký tự")]
        [Required(ErrorMessage = "Địa chỉ không được để trống")]
        [DisplayName("Địa chỉ")]
        public string? Address { get; set; }
        [Column(TypeName = "date")]
        public DateTime DateCreated { get; set; } = DateTime.Now;
        [InverseProperty("Customer")]
        public virtual ICollection<SalesOrder> SalesOrders { get; set; } = new List<SalesOrder>();

        public override string ToString()
        {
            return CustomerName;
        }
        [NotMapped]
        public string NameWithPhone
        {
            get { return CustomerName + "-" + Phone; }
        }
    }
}
