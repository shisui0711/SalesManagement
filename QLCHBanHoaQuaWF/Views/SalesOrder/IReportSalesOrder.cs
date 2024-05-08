using Microsoft.Reporting.WinForms;

namespace QLCHWF.Views.SalesOrder;

public interface IReportSalesOrder
{
    public ReportViewer ReportViewer { get; }
    public event EventHandler LoadReport;
}