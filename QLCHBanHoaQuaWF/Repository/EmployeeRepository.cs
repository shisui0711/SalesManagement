using Microsoft.EntityFrameworkCore;
using QLCHWF.IRepository;
using QLCHWF.Models;

namespace QLCHWF.Repository;

public class EmployeeRepository : GenericRepository<Employee>,IEmployeeRepository
{
    private readonly MyAppContext _context;
    public EmployeeRepository(MyAppContext context) : base(context)
    {
        _context = context;
    }

    public List<SalaryTable> GetSalesSalary(DateTime fromDate, DateTime toDate)
    {
        return (from employee in _context.Employees
            join sales in _context.SalesOrders
                on employee.EmployeeID equals sales.EmployeeID
            where sales.OrderDate >= fromDate
                  && sales.OrderDate <= toDate && employee.Salary != null
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
                Salary = g.Key.Salary,
                TotalWorked = g.Count()
            }).ToList();
    }

    public List<SalaryTable> GetImportSalary(DateTime fromDate, DateTime toDate)
    {
       return (from employee in _context.Employees
           join import in _context.ImportOrders
               on employee.EmployeeID equals import.EmployeeID
           where import.OrderDate >=fromDate
                 && import.OrderDate <= toDate && employee.Salary != null
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
               Salary = (decimal?)g.Key.Salary,
               TotalWorked = g.Count()
           }).ToList();
    }

    public Employee GetEmployeeWithSalesOrder(int id)
    {
        return _context.Employees.Include(e => e.SalesOrders)
            .First(e => e.EmployeeID == id);
    }

    public Employee GetEmployeeWithImportOrder(int id)
    {
        return _context.Employees.Include(e => e.ImportOrders)
            .First(e => e.EmployeeID == id);
    }

    public List<TopEmployee> GetTopEmployee(DateTime start, DateTime end)
    {
        return (from e in _context.Employees
            join import in _context.ImportOrders
                on  e.EmployeeID equals import.EmployeeID
            where import.OrderDate >= start && import.OrderDate <= end
            group import by new { e.EmployeeID, e.EmployeeName }
            into g
            orderby g.Count() descending
            select new TopEmployee
            {
                EmployeeID = g.Key.EmployeeID,
                EmployeeName = g.Key.EmployeeName,
                TotalSold = g.Count()
            }).ToList();
    }
}