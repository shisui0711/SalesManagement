using Microsoft.Reporting.WinForms;

namespace QLCHWF.Views.ImportOrder;

public interface IReportImportOrder
{
    public ReportViewer ReportViewer { get; }
    public event EventHandler LoadReport;
}