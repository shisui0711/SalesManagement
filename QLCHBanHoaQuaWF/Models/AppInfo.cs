using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLCHWF.Models;

[Table("AppInfo")]
public class AppInfo
{
    [Key]
    [Required(ErrorMessage = "Tên cửa hàng không được để trống")]
    public string? AppName { get; set; }
    [Required(ErrorMessage = "Số điện thoại không được để trống")]
    public required string Phone { get; set; }
    public string? Email { get; set; }
    [Required(ErrorMessage = "Địa chỉ không được để trống")]
    public required string Address { get; set; }
}