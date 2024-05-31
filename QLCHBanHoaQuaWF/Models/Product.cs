using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using QLCHWF.Properties;

namespace QLCHWF.Models
{
    [Table("Product")]
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductID { get; set; }
        [Required(ErrorMessage = "Tên không được để trống")]
        [StringLength(30)]
        public required string ProductName { get; set; }
        [StringLength(30)]
        public string? CalculationUnit { get; set; }

        public int Inventory { get; set; } = 0;
        public byte[]? ImageData { get; set; } = DefaultImage();
        [Column(TypeName = "date")]
        public DateTime DateCreated { get; set; } = DateTime.Now;
        [Column(TypeName = "decimal(10,2)")]
        [Required(ErrorMessage = "Giá nhập không được để trống")]
        [Range(1, 1000000000, ErrorMessage = "Giá nhập không được để trống và phải lớn lơn 0")]
        public decimal ImportUnitPrice { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        [Required(ErrorMessage = "Giá bán không được để trống")]
        [Range(1,1000000000,ErrorMessage = "Giá bán không được để trống và phải lớn lơn 0")]
        public decimal UnitPrice { get; set; }
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

        private static byte[] DefaultImage()
        {
            using (MemoryStream ms =new MemoryStream())
            {
                Resources.upload.Save(ms, Resources.upload.RawFormat);
                return ms.ToArray();
            }
        }
    }
}
