using System.ComponentModel.DataAnnotations;

namespace QLCHBanHoaQuaWF.Models;

public class AppInfo
{
    [Key]
    [Required]
    public string AppName { get; set; }
    [Required]
    public string Phone { get; set; }
    public string? Email { get; set; }
    [Required]
    public string Address { get; set; }
}