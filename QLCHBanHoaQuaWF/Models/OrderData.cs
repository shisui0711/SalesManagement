namespace QLCHWF.Models;

public class OrderData
{
    public int OrderID { get; set; }
    public string CustomerName { get; set; }
    public string CustomerPhone { get; set; }
    public string CustomerAddress { get; set; }
    public decimal TotalPrice { get; set; }
    public decimal PurchasePrice { get; set; }
    public decimal ChangePrice { get; set; }
    public DateTime DateCreated { get; set; }
}