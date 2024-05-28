using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLCHWF.Models
{
    [Table("Customer")]
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CustomerID { get; set; }
        [Required(ErrorMessage = "Tên không được để trống")]
        [StringLength(30,ErrorMessage = "Tên không dài quá 30 ký tự")]
        public required string CustomerName { get; set; }
        [EmailAddress(ErrorMessage = "Vui lòng nhập đúng định dạng email")]
        [StringLength(50,ErrorMessage = "Email không được dài hơn 50 ký tự")]
        public string? Email { get; set; }
        [RegularExpression(@"0\d{9}", ErrorMessage = "Vui lòng nhập đúng định dạng số điện thoại")]
        [StringLength(10)]
        public required string Phone { get; set; }
        [StringLength(50,ErrorMessage = "Địa chỉ không được dài hơn 50 ký tự")]
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
