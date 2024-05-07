using QLCHBanHoaQuaWF.Models;
using QLCHBanHoaQuaWF.Views.Statistics;
using System.Globalization;
using Guna.Charts.WinForms;

namespace QLCHBanHoaQuaWF.Presenters;

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

    private void LoadRevenueChart()
    {
        var days = (_viewStatistics.EndDate - _viewStatistics.StartDate).Days;
        var orderFullTime = (from sales in _context.SalesOrders
            where sales.OrderDate >= _viewStatistics.StartDate && sales.OrderDate <= _viewStatistics.EndDate
            group sales by sales.OrderDate
            into g
            select new
            {
                Key = g.Key,
                Value = g.Sum(x => x.TotalPrice)
            }).ToList();
        List<RevenueByDate> dataSource;
        //Nhóm theo giờ
        if (days <= 1)
        {
            dataSource = (from o in orderFullTime
                                       group o by o.Key.ToString("hh tt") into g
                                       select new RevenueByDate
                                       {
                                           Date = g.Key,
                                           TotalAmount = g.Sum(o => o.Value)
                                       }).ToList();
        }
        //nhóm theo ngày
        else if (days <= 30)
        {
            var orderFullTimeChange = orderFullTime.ConvertAll(x => new { Key = x.Key.ToString("dd MMM"), Value = x.Value });
            dataSource = (from o in orderFullTimeChange
                                       group o by o.Key into g
                                       select new RevenueByDate
                                       {
                                           Date = g.Key,
                                           TotalAmount = g.Sum(o => o.Value)
                                       }).ToList();
        }
        //nhóm theo tuần
        else if (days <= 92)
        {
            dataSource = (from o in orderFullTime
                                       group o by CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
                                         o.Key, CalendarWeekRule.FirstDay, DayOfWeek.Monday) into g
                                       select new RevenueByDate
                                       {
                                           Date = "Week" + g.Key.ToString(),
                                           TotalAmount = g.Sum(o => o.Value)
                                       }).ToList();
        }
        //nhóm theo tháng
        else if (days <= (365 * 2))
        {
            bool isYear = days <= 365;
            dataSource = (from o in orderFullTime
                                       group o by o.Key.ToString("MMM yyyy") into g
                                       select new RevenueByDate
                                       {
                                           Date = isYear ? g.Key.Substring(0, g.Key.IndexOf(" ")) : g.Key,
                                           TotalAmount = g.Sum(o => o.Value)
                                       }).ToList();
        }
        //nhóm theo năm
        else
        {
            dataSource = (from o in orderFullTime
                                       group o by o.Key.ToString("yyyy") into g
                                       select new RevenueByDate
                                       {
                                           Date = g.Key,
                                           TotalAmount = g.Sum(o => o.Value)
                                       }).ToList();
        }

        List<LPoint> lPoints = dataSource.ConvertAll(x =>
        {
            return new LPoint(x.Date,(double)x.TotalAmount);
        });
        _viewStatistics.RevenueDataset.DataPoints.Clear();
        _viewStatistics.RevenueDataset.DataPoints.AddRange(lPoints);
    }
}