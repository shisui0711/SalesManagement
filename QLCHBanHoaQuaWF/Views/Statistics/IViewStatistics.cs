using System.Windows.Forms.DataVisualization.Charting;
using Guna.Charts.WinForms;
using QLCHWF.Models;

namespace QLCHWF.Views.Statistics;

public interface IViewStatistics
{
    public BindingSource TopCustomerBindingSource { get; }
    public BindingSource TopEmployeeBindingSource { get; }
    public GunaBarDataset RevenueDataset { get; }
    public GunaBarDataset BudgetDataset { get; }
    public GunaBarDataset ProfitDataset { get; }
    public Chart ProductChart{ get; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public int SalesOrdered { get; set; }
    public int ImportOrdered { get; set; }
    public decimal Revenue { get; set; }
    public decimal Profit { get; set; }
    public int CountEmployee { get; set; }
    public int CountCustomer { get; set; }
    public int CountProvider { get; set; }
    public int CountProduct { get; set; }
    public event EventHandler LoadStatistics;
}