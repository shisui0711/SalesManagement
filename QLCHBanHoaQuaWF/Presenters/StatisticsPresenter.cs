using QLCHWF.Models;
using QLCHWF.Views.Statistics;
using System.Globalization;
using Guna.Charts.WinForms;
using QLCHWF.IRepository;

namespace QLCHWF.Presenters;

public class StatisticsPresenter
{
    private readonly IViewStatistics _viewStatistics;
    private readonly IUnitOfWork _unitOfWork;
    private bool _isLoaded;
    public StatisticsPresenter(IViewStatistics viewStatistics,IUnitOfWork unitOfWork)
    {
        _viewStatistics = viewStatistics;
        _unitOfWork = unitOfWork;

        _viewStatistics.LoadStatistics +=  delegate { Load(); };
    }
    public void Load()
    {
         LoadCount();
        LoadTopEmployee();
        LoadTopCustomer();
        LoadTopProduct();
        LoadRevenueChart();
    }
    private  void LoadCount()
    {
        if (!_isLoaded)
        {
            _viewStatistics.CountCustomer = _unitOfWork.Customers.Count();
            _viewStatistics.CountEmployee = _unitOfWork.Employees.Count();
            _viewStatistics.CountProvider = _unitOfWork.Providers.Count();
            _viewStatistics.CountProduct = _unitOfWork.Products.Count();
            _isLoaded = true;
        }
        _viewStatistics.SalesOrdered = _unitOfWork.SalesOrders.Count(s =>
            s.OrderDate >= _viewStatistics.StartDate && s.OrderDate <= _viewStatistics.EndDate);
        _viewStatistics.ImportOrdered = _unitOfWork.ImportOrders
            .Count(i => i.OrderDate >= _viewStatistics.StartDate && i.OrderDate <= _viewStatistics.EndDate);
        _viewStatistics.Revenue =
            _unitOfWork.SalesOrders.GetRevenue(_viewStatistics.StartDate, _viewStatistics.EndDate);
        _viewStatistics.Budget = _unitOfWork.SalesOrders.GetBudget(_viewStatistics.StartDate, _viewStatistics.EndDate);
        _viewStatistics.Profit = _viewStatistics.Revenue - _viewStatistics.Budget;
        _viewStatistics.Profit = _viewStatistics.Profit >= 0 ? _viewStatistics.Profit : 0;
    }
    private void LoadTopEmployee()
    {
        _viewStatistics.TopEmployeeBindingSource.DataSource =
            _unitOfWork.Employees.GetTopEmployee(_viewStatistics.StartDate, _viewStatistics.EndDate);
    }

    private void LoadTopCustomer()
    {
        _viewStatistics.TopCustomerBindingSource.DataSource =
            _unitOfWork.Customers.GetTopCustomers(_viewStatistics.StartDate, _viewStatistics.EndDate);
    }

    private void LoadTopProduct()
    {
        var topProduct = _unitOfWork.Products.GetTopProduct(_viewStatistics.StartDate,_viewStatistics.EndDate);
        int count = topProduct.Count;
        if (count > 0)
        {
            if (count > 5)
            {
                topProduct = topProduct.Take(5).ToList();
            }

            _viewStatistics.ProductChart.DataSource = topProduct;
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
            var orderFullTimeChange = dateAndValues.ConvertAll(x => new { Key = x.Key.ToString("dd MMM"), x.Value });
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
                        isYear ? g.Key.Substring(0, g.Key.IndexOf(" ", StringComparison.Ordinal)) : g.Key,
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

        return StatisticsFilter(
            _unitOfWork.SalesOrders.GetRevenueData(_viewStatistics.StartDate, _viewStatistics.EndDate));
    }

    private List<KeyValuePair<string, decimal>> GetBudgetData()
    {
        return StatisticsFilter(
            _unitOfWork.SalesOrders.GetBudgetData(_viewStatistics.StartDate, _viewStatistics.EndDate));
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
        _viewStatistics.ProfitDataset.DataPoints.Clear();
        _viewStatistics.BudgetDataset.DataPoints.Clear();

        _viewStatistics.BudgetDataset.DataPoints.AddRange(budgetData);
        _viewStatistics.RevenueDataset.DataPoints.AddRange(revenueData);
        _viewStatistics.ProfitDataset.DataPoints.AddRange(profitData);
    }
}