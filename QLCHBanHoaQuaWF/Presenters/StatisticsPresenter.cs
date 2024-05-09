using QLCHWF.Models;
using QLCHWF.Views.Statistics;
using System.Globalization;
using Guna.Charts.WinForms;

namespace QLCHWF.Presenters;

public class StatisticsPresenter
{
    private readonly IViewStatistics _viewStatistics;
    private readonly MyAppContext _context;
    public StatisticsPresenter(IViewStatistics viewStatistics,MyAppContext context)
    {
        _viewStatistics = viewStatistics;
        _context = context;

        _viewStatistics.LoadStatistics += delegate { Load(); };
    }
    public void Load()
    {
        LoadCount();
        LoadTopEmployee();
        LoadTopCustomer();
        LoadTopProduct();
        LoadRevenueChart();
    }

    private void LoadCount()
    {
        _viewStatistics.CountCustomer = _context.Customers.ToList().Count();
        _viewStatistics.CountEmployee = _context.Employees.ToList().Count();
        _viewStatistics.CountProvider = _context.Providers.ToList().Count();
        _viewStatistics.CountProduct = _context.Products.ToList().Count();
        List<SalesOrder> salesOrders = _context.SalesOrders.Where(s =>
            s.OrderDate >= _viewStatistics.StartDate && s.OrderDate <= _viewStatistics.EndDate).ToList();
        List<ImportOrder> importOrders = _context.ImportOrders
            .Where(i => i.OrderDate >= _viewStatistics.StartDate && i.OrderDate <= _viewStatistics.EndDate).ToList();
        _viewStatistics.SalesOrdered = salesOrders.Count();
        _viewStatistics.ImportOrdered = importOrders.Count();
        _viewStatistics.Revenue = salesOrders.Sum(x => x.TotalPrice);
        _viewStatistics.Profit = _viewStatistics.Revenue - importOrders.Sum(x => x.TotalPrice);
        _viewStatistics.Profit = _viewStatistics.Profit >= 0 ? _viewStatistics.Profit : 0;
    }
    private void LoadTopEmployee()
    {
        var topEmployee = (from e in _context.Employees
            join import in _context.ImportOrders
                on e.EmployeeID equals import.Employee.EmployeeID
            where import.OrderDate >= _viewStatistics.StartDate && import.OrderDate <= _viewStatistics.EndDate
            group import by new { e.EmployeeID, e.EmployeeName }
            into g
            orderby g.Count() descending
            select new TopEmployee
            {
                EmployeeID = g.Key.EmployeeID,
                EmployeeName = g.Key.EmployeeName,
                TotalSold = g.Count()
            }).ToList();
        _viewStatistics.TopEmployeeBindingSource.DataSource = topEmployee;
    }

    private void LoadTopCustomer()
    {
        var topCustomer = (from c in _context.Customers
            join sales in _context.SalesOrders
                on c.CustomerID equals sales.CustomerID
            where sales.OrderDate >= _viewStatistics.StartDate && sales.OrderDate <= _viewStatistics.EndDate
            group sales by new { c.CustomerID, c.CustomerName }
            into g
            orderby g.Count() descending
            select new TopCustomer
            {
                CustomerID = g.Key.CustomerID,
                CustomerName = g.Key.CustomerName,
                TotalBought = g.Count()
            }).ToList();
        _viewStatistics.TopCustomerBindingSource.DataSource = topCustomer;
    }

    private void LoadTopProduct()
    {
        var topProduct = (from p in _context.Products
            join detail in _context.DetailSalesOrders on p.ProductID equals detail.ProductID
            join sales in _context.SalesOrders on detail.OrderID equals sales.OrderID
            where sales.OrderDate >= _viewStatistics.StartDate && sales.OrderDate <= _viewStatistics.EndDate
            group detail by new { p.ProductID, p.ProductName }
            into g
            orderby g.Sum(x => x.Quantity) descending
            select new
            {
                Name = g.Key.ProductName,
                TotalSold = g.Sum(x => x.Quantity)
            }).ToList();
        int count = topProduct.Count;
        if (count > 0)
        {
            if (count > 5)
            {
                topProduct = topProduct.Take(5).ToList();
            }

            _viewStatistics.ProductChart.DataSource = topProduct
                .ConvertAll(x => new KeyValuePair<string, int>(x.Name, x.TotalSold));
            _viewStatistics.ProductChart.Series[0].XValueMember = "Key";
            _viewStatistics.ProductChart.Series[0].YValueMembers = "Value";
            _viewStatistics.ProductChart.DataBind();
        }
    }

    private List<KeyValuePair<string, decimal>> StatisticsFilter(List<KeyValuePair<DateTime, decimal>> dateAndValues)
    {
        var days = (_viewStatistics.EndDate - _viewStatistics.StartDate).Days;
        List<KeyValuePair<string, decimal>> data;
        //Nhóm theo giờ
        if (days <= 1)
        {
            data = (from o in dateAndValues
                    group o by o.Key.ToString("hh tt")
                into g
                    select new KeyValuePair<string, decimal>(g.Key, g.Sum(o => o.Value))).ToList();
        }
        //nhóm theo ngày
        else if (days <= 30)
        {
            var orderFullTimeChange = dateAndValues.ConvertAll(x => new { Key = x.Key.ToString("dd MMM"), Value = x.Value });
            data = (from o in orderFullTimeChange
                    group o by o.Key into g
                    select new KeyValuePair<string, decimal>(g.Key, g.Sum(o => o.Value))).ToList();
        }
        //nhóm theo tuần
        else if (days <= 92)
        {
            data = (from o in dateAndValues
                    group o by CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
                      o.Key, CalendarWeekRule.FirstDay, DayOfWeek.Monday) into g
                    select new KeyValuePair<string, decimal>("Week" + g.Key.ToString(), g.Sum(o => o.Value))).ToList();
        }
        //nhóm theo tháng
        else if (days <= (365 * 2))
        {
            bool isYear = days <= 365;
            data = (from o in dateAndValues
                    group o by o.Key.ToString("MMM yyyy") into g
                    select new KeyValuePair<string, decimal>(
                        isYear ? g.Key.Substring(0, g.Key.IndexOf(" ")) : g.Key,
                        g.Sum(o => o.Value)
                        )).ToList();
        }
        //nhóm theo năm
        else
        {
            data = (from o in dateAndValues
                    group o by o.Key.ToString("yyyy") into g
                    select new KeyValuePair<string, decimal>(
                        g.Key,
                        g.Sum(o => o.Value)
                        )).ToList();
        }

        return data;
    }
    private List<KeyValuePair<string,decimal>> GetRevenueData()
    {
        var orderFullTime = (from sales in _context.SalesOrders
                             where sales.OrderDate >= _viewStatistics.StartDate && sales.OrderDate <= _viewStatistics.EndDate
                             group sales by sales.OrderDate
            into g
                             select new KeyValuePair<DateTime,decimal>(
                                 g.Key,
                                 g.Sum(x => x.TotalPrice)
                                 )).ToList();
        return StatisticsFilter(orderFullTime);
    }

    private List<KeyValuePair<string, decimal>> GetBudgetData()
    {
        var days = (_viewStatistics.EndDate - _viewStatistics.StartDate).Days;
        var orderFullTime = (from import in _context.ImportOrders
                             where import.OrderDate >= _viewStatistics.StartDate && import.OrderDate <= _viewStatistics.EndDate
                             group import by import.OrderDate
            into g
                             select new KeyValuePair<DateTime,decimal>(
                                 g.Key,
                                 g.Sum(x => x.TotalPrice)
                                 )).ToList();
        return StatisticsFilter(orderFullTime);
    }

    private void LoadRevenueChart()
    {
        List<LPoint> budgetData = GetBudgetData().ConvertAll(x => new LPoint(x.Key, (double)x.Value));
        List<LPoint> revenueData = GetRevenueData().ConvertAll(x => new LPoint(x.Key,(double)x.Value));
        List<LPoint> profitData = new List<LPoint>();
        for (int i = 0; i < budgetData.Count; i++)
        {
            profitData.Add(new LPoint(
                budgetData[i].Label, 
                revenueData[i].Y - budgetData[i].Y > 0 ? revenueData[i].Y - budgetData[i].Y : 0
                ));
        }
        _viewStatistics.RevenueDataset.DataPoints.Clear();
        _viewStatistics.BudgetDataset.DataPoints.Clear();
        _viewStatistics.ProfitDataset.DataPoints.Clear();

        _viewStatistics.RevenueDataset.DataPoints.AddRange(revenueData);
        _viewStatistics.BudgetDataset.DataPoints.AddRange(budgetData);
        _viewStatistics.ProfitDataset.DataPoints.AddRange(profitData);
    }
}