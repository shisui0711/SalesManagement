using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using QLCHWF.Models;
using QLCHWF.Views;
using QLCHWF.Views.Employee;
using MyAppContext = QLCHWF.Models.MyAppContext;

namespace QLCHWF.Presenters;
public class EmployeePresenter : PresenterCRUD
{
    private readonly IViewEmployee _viewEmployee;
    private readonly IAddEmployee _addEmployee;
    private readonly IUpdateEmployee _updateEmployee;
    private readonly IHistoryImport _historyImport;
    private readonly IHistorySales _historySales;
    private readonly IViewSalary _viewSalary;
    private readonly MyAppContext _context;
    private readonly AuthPresenter _auth;


    public EmployeePresenter(IViewEmployee viewEmployee, IAddEmployee addEmployee, IUpdateEmployee updateEmployee, IHistoryImport historyImport, IHistorySales historySales, IViewSalary viewSalary, MyAppContext context, AuthPresenter auth)
    {
        _viewEmployee = viewEmployee;
        _addEmployee = addEmployee;
        _updateEmployee = updateEmployee;
        _historyImport = historyImport;
        _historySales = historySales;
        _viewSalary = viewSalary;
        _context = context;
        _auth = auth;

        _context.Employees.Load();

        _viewEmployee.LoadEmployee += delegate { Load(); };
        _viewEmployee.SearchEmployee += delegate { Search(); };
        _viewEmployee.RemoveEmployee += delegate { Remove(); };
        _viewEmployee.ShowAddEmployee += delegate { ShowAddForm(); };
        _viewEmployee.ShowUpdateEmployee += delegate { ShowUpdateForm(); };
        _viewEmployee.ShowSalesHistory += delegate { SalesHistory(); };
        _viewEmployee.ShowImportHistory += delegate { ImportHistory(); };
        _viewEmployee.ShowSalary += delegate { ShowSalaryTable(); };

        _addEmployee.AddEmployee += delegate { Add(); };
        _updateEmployee.UpdateEmployee += delegate { Update(); };

        _viewSalary.CalculateSalary += delegate { CalculateSalary(); };
    }

    void CalculateSalary()
    {
        try
        {
            List<SalaryTable> salesSalary = (from employee in _context.Employees
                join sales in _context.SalesOrders
                    on employee.EmployeeID equals sales.EmployeeID
                where sales.OrderDate >= _viewSalary.StartDate
                      && sales.OrderDate <= _viewSalary.EndDate && employee.Salary != null
                group sales by new
                {
                    employee.EmployeeID,
                    employee.EmployeeName,
                    employee.Salary
                }
                into g
                select new SalaryTable
                {
                    EmployeeID = g.Key.EmployeeID,
                    EmployeeName = g.Key.EmployeeName,
                    Salary = (decimal)g.Key.Salary,
                    TotalWorked = g.Count()
                }).ToList();
            List<SalaryTable> importSalary = (from employee in _context.Employees
                join import in _context.ImportOrders
                    on employee.EmployeeID equals import.EmployeeID
                where import.OrderDate >= _viewSalary.StartDate
                      && import.OrderDate <= _viewSalary.EndDate && employee.Salary != null
                group import by new
                {
                    employee.EmployeeID,
                    employee.EmployeeName,
                    employee.Salary
                }
                into g
                select new SalaryTable
                {
                    EmployeeID = g.Key.EmployeeID,
                    EmployeeName = g.Key.EmployeeName,
                    Salary = (decimal)g.Key.Salary,
                    TotalWorked = g.Count()
                }).ToList();
            List<SalaryTable> salaryTables = salesSalary.Concat(importSalary).ToList();
            _viewSalary.SalaryBindingSource.DataSource = salaryTables;
        }
        catch (Exception e)
        {
            MessageBox.Show($"Lỗi: {e.Message}");
        }
    }
    void ShowSalaryTable()
    {
        Form form = (Form)_viewSalary;
        form?.ShowDialog();
    }
    void SalesHistory()
    {
        if (_viewEmployee.EmployeeBindingSource.Current == null)
        {
            MessageBox.Show(@"Chưa bản ghi nào được chọn");
            return;
        }
        Employee currentEmployee = _viewEmployee.EmployeeBindingSource.Current as Employee;
        Employee employee = _context.Employees.Include(e => e.SalesOrders)
            .First(e => e.EmployeeID == currentEmployee.EmployeeID);
        if (employee.SalesOrders.Count == 0)
        {
            MessageBox.Show(@"Nhân viên này chưa bán đơn hàng nào");
            return;
        }
        _historySales.SalesBindingSource.DataSource = employee.SalesOrders.ToList();
        Form form = (Form)_historySales;
        form?.ShowDialog();

    }

    public void ImportHistory()
    {
        if (_viewEmployee.EmployeeBindingSource.Current == null)
        {
            MessageBox.Show(@"Chưa bản ghi nào được chọn");
            return;
        }
        Employee currentEmployee = _viewEmployee.EmployeeBindingSource.Current as Employee;
        Employee employee = _context.Employees.Include(e => e.ImportOrders)
            .First(e => e.EmployeeID == currentEmployee.EmployeeID);
        if (employee.ImportOrders.Count == 0)
        {
            MessageBox.Show(@"Nhân viên này chưa nhập đơn hàng nào");
            return;
        }
        _historyImport.ImportBindingSource.DataSource = employee.ImportOrders.ToList();
        Form form = (Form)_historyImport;
        form?.ShowDialog();
    }
    public void ShowAddForm()
    {
        if (AuthPresenter.User != null && AuthPresenter.User.UserRole.Permission.CanCreateEmployee == false)
        {
            MessageBox.Show(@"Bạn không có quyền này");
            return;
        }
        if (_addEmployee.GetType().IsAssignableTo(typeof(Form)))
        {
            var form = _addEmployee as Form;
            if (form != null)
            {
                form.ShowDialog();
            }
        }
    }

    public void ShowUpdateForm()
    {
        if (AuthPresenter.User != null && AuthPresenter.User.UserRole.Permission.CanUpdateProduct == false)
        {
            MessageBox.Show(@"Bạn không có quyền này");
            return;
        }
        var updated = _viewEmployee.EmployeeBindingSource.Current as Employee;
        if (updated == null)
        {
            return;
        }
        _updateEmployee.EmployeeID = updated.EmployeeID;
        _updateEmployee.EmployeeName = updated.EmployeeName;
        _updateEmployee.Email = updated.Email;
        _updateEmployee.Phone = updated.Phone;
        _updateEmployee.Salary = updated.Salary;
        if (_updateEmployee.GetType().IsAssignableTo(typeof(Form)))
        {
            var form = _updateEmployee as Form;
            if (form != null)
            {
                form.ShowDialog();
            }
        }
    }
    public override void Add()
    {
        try
        {
            var employee = new Employee();
            employee.EmployeeName = _addEmployee.EmployeeName;
            employee.Email = _addEmployee.Email;
            employee.Phone = _addEmployee.Phone;
            employee.Address = _addEmployee.Address;
            employee.Salary = _addEmployee.Salary;
            if (!IsValid(employee, _addEmployee))
            {
                return;
            }

            if (_context.Employees.Any(e => e.Email == _addEmployee.Email))
            {
                MessageBox.Show(@"Email đã tồn tại trên hệ thống");
                return;
            }

            _context.Employees.Add(employee);
            _context.SaveChanges();
            _auth.Register(employee.Email, "123456", 1);
            _viewEmployee.EmployeeBindingSource.EndEdit();
            MessageBox.Show("Thêm thành công");
        }
        catch (Exception e)
        {
           MessageBox.Show($"Lỗi: {e.Message}");
        }
    }

    public override void Update()
    {
        try
        {
            var employee = _context.Employees.Find(_updateEmployee.EmployeeID);
            if (employee == null)
            {
                return;
            }

            employee.EmployeeName = _updateEmployee.EmployeeName;
            employee.Email = _updateEmployee.Email;
            employee.Phone = _updateEmployee.Phone;
            employee.Address = _updateEmployee.Address;
            employee.Salary = _updateEmployee.Salary;
            if (!IsValid(employee, _updateEmployee))
            {
                _context.Entry(employee).Reload();
                return;
            }

            _context.SaveChanges();
            _viewEmployee.EmployeeBindingSource.EndEdit();
            MessageBox.Show("Cập nhật thành công");
        }
        catch (Exception e)
        {
           MessageBox.Show($"Lỗi: {e.Message}");
        }
    }

    public override void Remove()
    {
        try
        {
            var deleted = _viewEmployee.EmployeeBindingSource.Current as Employee;
            if (deleted == null)
            {
                return;
            }

            var dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi đã chọn ?", "Thông báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Cancel)
            {
                return;
            }

            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    _context.Employees.Remove(deleted);
                    _context.SaveChanges();
                    transaction.Commit();
                    _viewEmployee.EmployeeBindingSource.Remove(deleted);
                    MessageBox.Show("Xóa thành công");
                }
                catch (SqlException e)
                {
                    transaction.Rollback();
                    MessageBox.Show($"Xóa thất bại: {e.Message}");
                }
            }
        }
        catch (Exception e)
        {
          MessageBox.Show($"Lỗi: {e.Message}");
        }
    }

    public override void Search()
    {
        try
        {
            List<Employee> employees = null;
            switch (_viewEmployee.OptionIndex)
            {
                case 1:
                    employees = _context.Employees.Where(x => x.EmployeeName.Contains(_viewEmployee.SearchText))
                        .ToList();
                    break;
                case 3:
                    employees = _context.Employees.Where(x => x.Email.Contains(_viewEmployee.SearchText)).ToList();
                    break;
                case 4:
                    employees = _context.Employees.Where(x => x.Phone.Contains(_viewEmployee.SearchText)).ToList();
                    break;
                case 5:
                    employees = _context.Employees.Where(x => x.Address.Contains(_viewEmployee.SearchText)).ToList();
                    break;
                default:
                    break;
            }

            if (employees != null)
            {
                _viewEmployee.EmployeeBindingSource.DataSource = employees;
            }
            else
            {
                MessageBox.Show("Không tìm thấy bản ghi nào hợp lệ", "Thông báo");
            }
        }
        catch (Exception e)
        {
           MessageBox.Show($"Lỗi: {e.Message}");
        }
    }

    public override void Load()
    {
        _viewEmployee.EmployeeBindingSource.ResetBindings(true);
        _viewEmployee.EmployeeBindingSource.DataSource = _context.Employees.Local.ToBindingList();
    }
}