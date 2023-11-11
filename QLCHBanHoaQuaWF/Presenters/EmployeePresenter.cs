using Microsoft.EntityFrameworkCore;
using QLCHBanHoaQuaWF.Models;
using QLCHBanHoaQuaWF.Views.Customer;
using QLCHBanHoaQuaWF.Views.Employee;
using System.ComponentModel.DataAnnotations;
using QLCHBanHoaQuaWF.Views;
using AppContext = QLCHBanHoaQuaWF.Models.AppContext;

namespace QLCHBanHoaQuaWF.Presenters;

public class EmployeePresenter:PresenterCRUD
{
    private IViewEmployee _viewEmployee;
    private IAddEmployee _addEmployee;
    private IUpdateEmployee _updateEmployee;
    private AppContext _context;

    public EmployeePresenter(IViewEmployee viewEmployee,IAddEmployee addEmployee,IUpdateEmployee updateEmployee,AppContext context)
    {
        _viewEmployee = viewEmployee;
        _addEmployee = addEmployee;
        _updateEmployee = updateEmployee;
        _context = context;

        _context.Employees.Load();

        _viewEmployee.LoadEmployee += delegate { Load(); };
        _viewEmployee.SearchEmployee += delegate { Search(); };
        _viewEmployee.RemoveEmployee += delegate { Remove(); };
        _viewEmployee.ShowAddEmployee += delegate { ShowAddForm(); };
        _viewEmployee.ShowUpdateEmployee += delegate { ShowUpdateForm(); };
        _viewEmployee.ShowPurchaseHistory += delegate { PurchaseHistory(); };
        _viewEmployee.ShowImportHistory += delegate { ImportHistory(); };
        _viewEmployee.ShowShiftHistory += delegate { ShiftHistory(); };

        _addEmployee.AddEmployee += delegate { Add(); };
        _updateEmployee.UpdateEmployee += delegate { Update(); };
    }

    public void PurchaseHistory()
    {
        
    }

    public void ImportHistory()
    {

    }

    public void ShiftHistory()
    {

    }
    public void ShowAddForm()
    {
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
        var employee = new Employee();
        employee.EmployeeName = _addEmployee.EmployeeName;
        employee.Email = _addEmployee.Email;
        employee.Phone = _addEmployee.Phone;
        employee.Address = _addEmployee.Address;
        employee.Salary = _addEmployee.Salary;
        if (!IsValid(employee,_addEmployee))
        {
            return;
        }

        _context.Employees.Add(employee);
        _context.SaveChanges();
        _viewEmployee.EmployeeBindingSource.EndEdit();
    }

    public override void Update()
    {
        var employee = new Employee();
        employee.EmployeeID = _updateEmployee.EmployeeID;
        employee.EmployeeName = _updateEmployee.EmployeeName;
        employee.Email = _updateEmployee.Email;
        employee.Phone = _updateEmployee.Phone;
        employee.Address = _updateEmployee.Address;
        employee.Salary = _updateEmployee.Salary;
        if (!IsValid(employee, _updateEmployee))
        {
            return;
        }

        var employeeExist = _context.Employees.Find(employee.EmployeeID);
        if (employeeExist != null)
        {
            _context.Entry(employeeExist).CurrentValues.SetValues(employee);
            _context.SaveChanges();
            _viewEmployee.EmployeeBindingSource.EndEdit();
        }
    }

    public override void Remove()
    {
        var dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi đã chọn ?", "Thông báo",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        if (dialogResult == DialogResult.Cancel)
        {
            return;
        }

        var deleted = _viewEmployee.EmployeeBindingSource.Current as Employee;
        using (var transaction = _context.Database.BeginTransaction())
        {
            try
            {
                _context.Employees.Remove(deleted);
                _context.SaveChanges();
                transaction.Commit();
                _viewEmployee.EmployeeBindingSource.Remove(deleted);
            }
            catch (Exception e)
            {
                transaction.Rollback();
            }
        }
    }

    public override void Search()
    {
        List<Employee> employees = null;
        switch (_viewEmployee.OptionIndex)
        {
            case 1:
                employees = _context.Employees.Where(x => x.EmployeeName.Contains(_viewEmployee.SearchText)).ToList();
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

    public override void Load()
    {
        _viewEmployee.EmployeeBindingSource.ResetBindings(true);
        _viewEmployee.EmployeeBindingSource.DataSource = _context.Employees.Local.ToBindingList();
    }
}