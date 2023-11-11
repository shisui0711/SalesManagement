using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLCHBanHoaQuaWF.Models;
//Ca làm việc
public class Shift
{
    [Key]
    public int ShiftID { get; set; }
    public int EmployeeID { get; set; }
    [RegularExpression(@"Sáng|Chiều|Tối")]
    public string TypeOfShift { get; set; }
    [Column(TypeName = "date")]
    public DateTime DataOfShift { get; set; }
    [ForeignKey("EmployeeID")]
    [InverseProperty("Shifts")]
    public Employee Employee { get; set; }
}