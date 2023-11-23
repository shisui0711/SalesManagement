using Microsoft.Reporting.WinForms;

namespace QLCHBanHoaQuaWF.Views.SalesOrder;

public interface IReportSalesOrder
{
    public ReportViewer ReportViewer { get; }
    public event EventHandler LoadReport;
}