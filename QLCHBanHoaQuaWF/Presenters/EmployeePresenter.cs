using AutoMapper;
using QLCHWF.Helpers;
using QLCHWF.IRepository;
using QLCHWF.Models;
using QLCHWF.Views;
using QLCHWF.Views.Employee;

namespace QLCHWF.Presenters;
public class EmployeePresenter : PaginationPresenter<Employee>
{
    private readonly IViewEmployee _viewEmployee;
    private readonly IAddEmployee _addEmployee;
    private readonly IUpdateEmployee _updateEmployee;
    private readonly IHistoryImport _historyImport;
    private readonly IHistorySales _historySales;
    private readonly IViewSalary _viewSalary;
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;


    public EmployeePresenter(IViewEmployee viewEmployee, IAddEmployee addEmployee, IUpdateEmployee updateEmployee,
        IHistoryImport historyImport, IHistorySales historySales, IViewSalary viewSalary, IMapper mapper,
        IUnitOfWork unitOfWork) : base(viewEmployee, unitOfWork.Employees, 20)
    {
        _viewEmployee = viewEmployee;
        _addEmployee = addEmployee;
        _updateEmployee = updateEmployee;
        _historyImport = historyImport;
        _historySales = historySales;
        _viewSalary = viewSalary;
        _mapper = mapper;
        _unitOfWork = unitOfWork;

        _viewEmployee.LoadEmployee += delegate
        {
            RenewItems();
        };
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
            List<SalaryTable> salesSalary =
                _unitOfWork.Employees.GetSalesSalary(_viewSalary.StartDate, _viewSalary.EndDate);
            List<SalaryTable> importSalary =
                _unitOfWork.Employees.GetImportSalary(_viewSalary.StartDate, _viewSalary.EndDate);
            List<SalaryTable> salaryTables = salesSalary.Concat(importSalary).ToList();
            _viewSalary.SalaryBindingSource.DataSource = salaryTables;
        }
        catch (Exception e)
        {
            _viewSalary.ShowMessage($"Lỗi: {e.Message}");
        }
    }
    void ShowSalaryTable()
    {
        Form form = (Form)_viewSalary;
        form.ShowDialog();
    }
    void SalesHistory()
    {
        if (_viewEmployee.EmployeeBindingSource.Current == null)
        {
            _viewEmployee.ShowMessage("Chưa bản ghi nào được chọn");
            return;
        }
        Employee? currentEmployee = (_viewEmployee.EmployeeBindingSource.Current as Employee);
        if (currentEmployee == null)
        {
            _viewEmployee.ShowMessage("Chưa nhân viên nào được chọn");
            return;
        }
        Employee employee = _unitOfWork.Employees.GetEmployeeWithSalesOrder(currentEmployee.EmployeeID);
        if (employee.SalesOrders.Count == 0)
        {
            _viewEmployee.ShowMessage("Nhân viên này chưa bán đơn hàng nào");
            return;
        }
        _historySales.SalesBindingSource.DataSource = employee.SalesOrders.ToList();
        Form form = (Form)_historySales;
        form.ShowDialog();

    }

    public void ImportHistory()
    {
        if (_viewEmployee.EmployeeBindingSource.Current == null)
        {
            _viewEmployee.ShowMessage(@"Chưa bản ghi nào được chọn");
            return;
        }
        Employee? currentEmployee = _viewEmployee.EmployeeBindingSource.Current as Employee;
        if (currentEmployee == null)
        {
            _viewEmployee.ShowMessage("Chưa nhân viên nào được chọn");
            return;
        }
        Employee employee = _unitOfWork.Employees.GetEmployeeWithImportOrder(currentEmployee.EmployeeID);
        if (employee.ImportOrders.Count == 0)
        {
            _viewEmployee.ShowMessage(@"Nhân viên này chưa nhập đơn hàng nào");
            return;
        }
        _historyImport.ImportBindingSource.DataSource = employee.ImportOrders.ToList();
        Form form = (Form)_historyImport;
        form.ShowDialog();
    }
    public void ShowAddForm()
    {
        if (AuthPresenter.User != null && AuthPresenter.User.UserRole.Permission.CanCreateEmployee == false)
        {
            _viewEmployee.ShowMessage(@"Bạn không có quyền này");
            return;
        }
        _addEmployee.Reset();
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
            _viewEmployee.ShowMessage(@"Bạn không có quyền này");
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
        _updateEmployee.Address = updated.Address ?? String.Empty;
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
    public void Add()
    {
        try
        {

            Employee employee = _mapper.Map<Employee>(_addEmployee);
            if (!ValidationHelper.IsValid(employee, _addEmployee))
            {
                return;
            }

            if (_unitOfWork.Employees.GetOne(x=>x.Email == _addEmployee.Email) != null)
            {
                _addEmployee.ShowMessage(@"Email đã tồn tại trên hệ thống");
                return;
            }

            _unitOfWork.Employees.Add(employee);
            UserPresenter.Register(employee.Email, "123456", 1);
            _viewEmployee.EmployeeBindingSource.EndEdit();
            _addEmployee.ShowMessage("Thêm thành công");
        }
        catch (Exception e)
        {
            _addEmployee.ShowMessage($"Lỗi: {e.Message}");
        }
    }

    public void Update()
    {
        try
        {
            Employee? employeeExist = _unitOfWork.Employees.GetById(_updateEmployee.EmployeeID);
            if (employeeExist == null)
            {
                _viewEmployee.ShowMessage("Không tìm thấy nhân viên cần cập nhật");
                return;
            }

            employeeExist = _mapper.Map<Employee>(_updateEmployee);
            if (!ValidationHelper.IsValid(employeeExist, _updateEmployee))
            {
                return;
            }

            _unitOfWork.Employees.Update(employeeExist, employeeExist.EmployeeID);
            _viewEmployee.EmployeeBindingSource.EndEdit();
            _updateEmployee.ShowMessage("Cập nhật thành công");
            RenewItems();
        }
        catch (Exception e)
        {
            _updateEmployee.ShowMessage($"Lỗi: {e.Message}");
        }
    }

    public void Remove()
    {
        try
        {
            var deleted = _viewEmployee.EmployeeBindingSource.Current as Employee;
            if (deleted == null)
            {
                return;
            }

            if (_unitOfWork.Employees.Remove(deleted))
            {
                _viewEmployee.EmployeeBindingSource.Remove(deleted);
                _viewEmployee.ShowMessage("Xóa thành công");
                RenewItems();
            }
            else
            {
                _viewEmployee.ShowMessage($"Xóa thất bại");
            }
        }
        catch (Exception e)
        {
            _viewEmployee.ShowMessage($"Lỗi: {e.Message}");
        }
    }

    public void Search()
    {
        try
        {
            switch (_viewEmployee.OptionIndex)
            {
                case 1:
                    SearchItems(x => x.EmployeeName.Contains(_viewEmployee.SearchText));
                    break;
                case 2:
                    SearchItems(x =>
                       x.Salary != null && x.Salary >= _viewEmployee.SalaryStart &&
                       x.Salary <= _viewEmployee.SalaryEnd);
                    break;
                case 3:
                    SearchItems(x => x.Email.Contains(_viewEmployee.SearchText));
                    break;
                case 4:
                   SearchItems(x => x.Phone.StartsWith(_viewEmployee.SearchText));
                    break;
                case 5:
                    SearchItems(x =>x.Address !=null && x.Address.Contains(_viewEmployee.SearchText));
                    break;
                
            }
        }
        catch (Exception e)
        {
            _viewEmployee.ShowMessage($"Lỗi: {e.Message}");
        }
    }


    protected override void Load(List<Employee> items)
    {
        _viewEmployee.EmployeeBindingSource.ResetBindings(true);
        _viewEmployee.EmployeeBindingSource.DataSource = items;
    }
}