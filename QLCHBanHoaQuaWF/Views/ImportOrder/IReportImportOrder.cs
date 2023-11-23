using Microsoft.Reporting.WinForms;

namespace QLCHBanHoaQuaWF.Views.ImportOrder;

public interface IReportImportOrder
{
    public ReportViewer ReportViewer { get; }
    public event EventHandler LoadReport;
}