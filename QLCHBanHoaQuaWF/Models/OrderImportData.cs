namespace QLCHWF.Models;

public class OrderImportData
{

    public int OrderID { get; set; }
    public string ProviderName { get; set; }
    public decimal TotalPrice { get; set; }
    public DateTime DateCreated { get; set; }
}