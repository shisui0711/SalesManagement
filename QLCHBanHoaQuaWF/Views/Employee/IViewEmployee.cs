namespace QLCHWF.Views.Employee;

public interface IViewEmployee :IViewBase,IViewPagination
{
    public string SearchText { get; set; }
    public int OptionIndex { get; set; }
    public BindingSource EmployeeBindingSource { get; }
    public event EventHandler RemoveEmployee;
    public event EventHandler LoadEmployee;
    public event EventHandler SearchEmployee;
    public event EventHandler ShowSalesHistory;
    public event EventHandler ShowImportHistory;
    public event EventHandler ShowSalary;
    public event EventHandler ShowAddEmployee;
    public event EventHandler ShowUpdateEmployee;
}