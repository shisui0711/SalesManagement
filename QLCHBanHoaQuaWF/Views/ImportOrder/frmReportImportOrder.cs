using Microsoft.Reporting.WinForms;

namespace QLCHWF.Views.ImportOrder
{
    public partial class frmReportImportOrder : Form, IReportImportOrder
    {
        public frmReportImportOrder()
        {
            InitializeComponent();
        }

        public ReportViewer ReportViewer
        {
            get { return rpvImportOrder; }
        }
        public event EventHandler? LoadReport;

        private void frmReportImportOrder_Load(object sender, EventArgs e)
        {
            LoadReport?.Invoke(sender, e);
        }
    }
}
