using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLCHBanHoaQuaWF.Models
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductID { get; set; }
        [Required(ErrorMessage = "Tên không được để trống")]
        [StringLength(30)]
        public string ProductName { get; set; }
        [Required(ErrorMessage = "Đơn vị tính không được để trống")]
        [StringLength(30)]
        public string? CalculationUnit { get; set; }

        public int Inventory { get; set; } = 0;
        [Required(ErrorMessage = "Vui lòng chọn ảnh")]
        public byte[]? ImageData { get; set; }
        [Column(TypeName = "date")]
        public DateTime DateCreated { get; set; } = DateTime.Now;
        [Column(TypeName = "decimal(10,2)")]
        public decimal? ImportUnitPrice { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal? UnitPrice { get; set; }
        [StringLength(100)]
        public string? Description { get; set; }

        [InverseProperty("Product")]
        public virtual ICollection<DetailImportOrder> DetailImportOrders { get; set; } = new List<DetailImportOrder>();
        [InverseProperty("Product")]
        public virtual ICollection<DetailSalesOrder> DetailSalesOrders { get; set; } = new List<DetailSalesOrder>();

        public override string ToString()
        {
            return ProductName;
        }
    }
}
