using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.RegularExpressions;

namespace QLCHWF.Models
{
    [Table("Provider")]
    public class Provider
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProviderID { get; set; }
        [Required(ErrorMessage = "Tên không được để trống")]
        [StringLength(30,ErrorMessage = "Tên không được quá 30 ký tự")]
        public required string ProviderName { get; set; }

        [EmailAddress(ErrorMessage = "Vui lòng nhập đúng định dạng email")]
        [StringLength(50)]
        public required string Email { get; set; }
        [RegularExpression(@"0\d{9}", ErrorMessage = "Vui lòng nhập đúng định dạng số điện thoại")]
        [StringLength(10)]
        [Required(ErrorMessage = "Số điện thoại không được để trống")]
        public required string Phone { get; set; }

        [StringLength(50,ErrorMessage = "Địa chỉ không được quá 50 ký tự")]
        [Required(ErrorMessage = "Địa chỉ không được để trống")]
        public required string Address { get; set; }
        [Column(TypeName = "date")]
        public DateTime DateCreated { get; set; } = DateTime.Now;
        [InverseProperty("Provider")]
        public ICollection<ImportOrder> ImportOrders { get; set; } = new List<ImportOrder>();
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
