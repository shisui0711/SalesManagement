namespace QLCHBanHoaQuaWF.Views.Product;

public interface IUpdateProduct : IValidateControl
{
    public int ProductID { get; set; }
    public string ProductName { get; set; }
    public string CalculationUnit { get; set; }
    public byte[] ImageData { get; set; }
    public decimal? ImportUnitPrice { get; set; }
    public decimal? UnitPrice { get; set; }
    public string Description { get; set; }
    public event EventHandler UpdateProduct;
}