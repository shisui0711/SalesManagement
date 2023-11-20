using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHBanHoaQuaWF.Models
{
    public class SalesOrder
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderID { get; set; }
        [Column(TypeName = "date")]
        public DateTime OrderDate { get; set; } = DateTime.Now;
        [Column(TypeName = "decimal(10,2)")]
        public decimal TotalPrice { get; set; }
        [ForeignKey("EmployeeID")]
        [InverseProperty("SalesOrders")]
        public Employee? Employee { get; set; }
        [ForeignKey("CustomerID")]
        [InverseProperty("SalesOrders")]
        public Customer? Customer { get; set; }

        [InverseProperty("SalesOrder")]
        public ICollection<DetailSalesOrder> DetailSalesOrders { get; set; } = new List<DetailSalesOrder>();
    }
}
