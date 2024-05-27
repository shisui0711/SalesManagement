using System.ComponentModel.DataAnnotations.Schema;

namespace QLCHWF.Models
{
    [Table("DetailImportOrder")]
    public class DetailImportOrder
    {
        public int OrderID { get; set; }
        [ForeignKey("OrderID")]
        [InverseProperty("DetailImportOrders")]
        public ImportOrder? ImportOrder { get; set; }
        public int Quantity { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal UnitPrice { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal TotalPrice
        {
            get { return Quantity * UnitPrice;} }

        public int ProductID { get; set; }
        [ForeignKey("ProductID")]
        [InverseProperty("DetailImportOrders")]
        public Product? Product { get; set; }

    }
}
