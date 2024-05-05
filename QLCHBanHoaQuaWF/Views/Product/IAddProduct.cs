namespace QLCHBanHoaQuaWF.Views.Product;

public interface IAddProduct : IValidateControl
{
    public string ProductName { get; set; }
    public string CalculationUnit { get; set; }
    public byte[] ImageData { get; }
    public decimal? ImportUnitPrice { get; set; }
    public decimal? UnitPrice { get; set; }
    public string Description { get; set; }
    public void Reset();
    public event EventHandler AddProduct;
}