using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLCHWF.Models;

[Table("Category")]
public class Category
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int CategoryID { get; set; }
    [Required(ErrorMessage = "Tên danh mục không được để trống")]
    [MaxLength(30,ErrorMessage = "Tên danh mục không dài quá 30 ký tự")]
    public string CategoryName { get; set; }
    [MaxLength(100,ErrorMessage = "Ghi chú không dài quá 100 ký tự")]
    public string Description { get; set; }
    [Column(TypeName = "date")]
    public DateTime DateCreated { get; set; }
    [InverseProperty("Category")]
    public virtual ICollection<Product> Products { get; set; }
}