namespace QLCHBanHoaQuaWF.Views.ImportOrder;

public interface IViewImportOrder
{
    public string SearchText { get; set; }
    public int OptionIndex { get; set; }
    public DateTime DateStart { get; }
    public DateTime DateEnd { get; }
    public BindingSource OrderBindingSource { get; }
    public event EventHandler LoadImportOrder;
    public event EventHandler RemoveImportOrder;
    public event EventHandler SearchImportOrder;
    public event EventHandler ShowAdd;
    public event EventHandler ShowReport;
}