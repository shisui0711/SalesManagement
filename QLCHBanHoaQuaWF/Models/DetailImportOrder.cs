using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHBanHoaQuaWF.Models
{
    public class DetailImportOrder
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DetailOrderID { get; set; }

        public int OrderID { get; set; }
        [ForeignKey("OrderID")]
        [InverseProperty("DetailImportOrders")]
        public ImportOrder ImportOrder { get; set; }
        public int Quantity { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal UnitPrice { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal TotalPrice { get; set; }
        [ForeignKey("ProductID")]
        [InverseProperty("DetailImportOrders")]
        public Product? Product { get; set; }
        
    }
}
