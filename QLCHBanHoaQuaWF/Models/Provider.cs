using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHBanHoaQuaWF.Models
{
    public class Provider
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProviderID { get; set; }
        [Required(ErrorMessage = "Tên không được để trống")]
        [StringLength(30)]
        public string ProviderName { get; set; }
        [EmailAddress(ErrorMessage = "Vui lòng nhập đúng định dạng email")]
        [StringLength(50)]
        public string Email { get; set; }
        [RegularExpression(@"0\d{9}", ErrorMessage = "Vui lòng nhập đúng định dạng số điện thoại")]
        public string Phone { get; set; }

        [StringLength(50)]
        public string Address { get; set; }
        [InverseProperty("Provider")]
        public ICollection<ImportOrder> ImportOrders { get; set; } = new List<ImportOrder>();
        [NotMapped]
        public string NameWithPhone
        {
            get { return ProviderName + "-" + Phone; }
        }

    }
}
