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

        private void frmReportImportOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
            rpvImportOrder.AutoScrollPosition = new Point(0, 0);
        }

        private void rpvImportOrder_Scroll(object sender, ScrollEventArgs e)
        {
            Console.WriteLine("Scroll trigger");
        }
    }
}
