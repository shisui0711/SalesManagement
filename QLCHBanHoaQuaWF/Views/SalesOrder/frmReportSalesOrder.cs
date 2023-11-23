using Microsoft.Reporting.WinForms;

namespace QLCHBanHoaQuaWF.Views.SalesOrder
{
    public partial class frmReportSalesOrder : Form, IReportSalesOrder
    {
        public frmReportSalesOrder()
        {
            InitializeComponent();
        }

        private void frmReportSalesOrder_Load(object sender, EventArgs e)
        {
            LoadReport?.Invoke(sender, e);
        }

        public ReportViewer ReportViewer
        {
            get { return rpvSalesOrder; }
        }
        public event EventHandler? LoadReport;
    }
}
