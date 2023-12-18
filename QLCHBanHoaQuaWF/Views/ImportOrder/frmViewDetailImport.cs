namespace QLCHBanHoaQuaWF.Views.ImportOrder
{
    public partial class frmViewDetailImport : Form,IDetailImportOrder
    {
        public frmViewDetailImport()
        {
            InitializeComponent();
        }

        public BindingSource DetailOrderBindingSource
        {
            get { return detailImportOrderBindingSource; }
        }
    }
}
