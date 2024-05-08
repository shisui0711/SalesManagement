using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLCHWF.Models
{
    [Table("ImportOrder")]
    public class ImportOrder
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderID { get; set; }
        [Column(TypeName = "date")]
        public DateTime OrderDate { get; set; } = DateTime.Now;
        [Column(TypeName = "decimal(10,2)")]
        public decimal TotalPrice { get; set; }

        public int EmployeeID { get; set; }
        [ForeignKey("EmployeeID")]
        [InverseProperty("ImportOrders")]
        public Employee? Employee { get; set; }

        public int ProviderID { get; set; }
        [ForeignKey("ProviderID")]
        [InverseProperty("ImportOrders")]
        public Provider? Provider { get; set; }
        [InverseProperty("ImportOrder")]
        public virtual ICollection<DetailImportOrder> DetailImportOrders { get; set; }
    }
}
