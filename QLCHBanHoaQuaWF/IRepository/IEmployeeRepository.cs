using QLCHWF.Models;

namespace QLCHWF.IRepository;

public interface IEmployeeRepository: IGenericRepository<Employee>
{
    public List<SalaryTable> GetSalesSalary(DateTime fromDate, DateTime toDate);
    public List<SalaryTable> GetImportSalary(DateTime fromDate, DateTime toDate);
    public Employee GetEmployeeWithSalesOrder(int id);
    public Employee GetEmployeeWithImportOrder(int id);
    public List<TopEmployee> GetTopEmployee(DateTime start, DateTime end);
}