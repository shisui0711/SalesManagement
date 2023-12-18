namespace QLCHBanHoaQuaWF.Views.SalesOrder
{
    public partial class frmViewDetailSales : Form, IDetailSalesOrder
    {
        public frmViewDetailSales()
        {
            InitializeComponent();
        }

        public BindingSource DetailOrderBindingSource
        {
            get { return detailSalesOrderBindingSource; }
        }
    }
}
