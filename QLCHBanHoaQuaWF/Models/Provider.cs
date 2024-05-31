using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLCHWF.Models
{
    [Table("Provider")]
    public class Provider
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("Mã nhà cung cáp")]
        public int ProviderID { get; set; }
        [Required(ErrorMessage = "Tên không được để trống")]
        [StringLength(30,ErrorMessage = "Tên không được quá 30 ký tự")]
        [DisplayName("Tên nhà cung cấp")]
        public required string ProviderName { get; set; }

        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Vui lòng nhập đúng định dạng email")]
        [StringLength(50)]
        [Required(ErrorMessage = "Email không được để trống")]
        [DisplayName("Email")]
        public required string Email { get; set; }
        [RegularExpression(@"0\d{9}", ErrorMessage = "Vui lòng nhập đúng định dạng số điện thoại")]
        [StringLength(10)]
        [Required(ErrorMessage = "Số điện thoại không được để trống")]
        [DisplayName("Phone")]
        public required string Phone { get; set; }

        [StringLength(50,ErrorMessage = "Địa chỉ không được quá 50 ký tự")]
        [Required(ErrorMessage = "Địa chỉ không được để trống")]
        [DisplayName("Địa chỉ")]
        public required string Address { get; set; }
        [Column(TypeName = "date")]
        public DateTime DateCreated { get; set; } = DateTime.Now;
        [InverseProperty("Provider")]
        public virtual ICollection<ImportOrder> ImportOrders { get; set; } = new List<ImportOrder>();
        [NotMapped]
        public string NameWithPhone
        {
            get { return ProviderName + "-" + Phone; }
        }

        public override string ToString()
        {
            return ProviderName;
        }
    }
}
