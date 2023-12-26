using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLCHBanHoaQuaWF.Models
{
    public class DetailSalesOrder
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DetailOrderID { get; set; }

        public int OrderID { get; set; }
        [ForeignKey("OrderID")]
        [InverseProperty("DetailSalesOrders")]
        public SalesOrder? SalesOrder { get; set; }

        public int Quantity { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal UnitPrice { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal TotalPrice
        {
            get { return UnitPrice * Quantity; }
        }

        public int ProductID { get; set; }
        [ForeignKey("ProductID")]
        [InverseProperty("DetailSalesOrders")]
        public Product? Product { get; set; }
    }
}
