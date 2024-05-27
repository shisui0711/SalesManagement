using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLCHWF.Models;

[Table("AppInfo")]
public class AppInfo
{
    [Key]
    [Required]
    public string? AppName { get; set; }
    [Required]
    public string Phone { get; set; }
    public string? Email { get; set; }
    [Required]
    public string Address { get; set; }
}