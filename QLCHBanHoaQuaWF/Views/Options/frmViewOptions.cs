namespace QLCHWF.Views.Options
{
    public partial class frmViewOptions : Form, IViewOptions
    {
        public frmViewOptions()
        {
            InitializeComponent();
        }

        public event EventHandler? ShowAppInfo;

        private void btnAppInfo_Click(object sender, EventArgs e)
        {
            ShowAppInfo?.Invoke(sender, e);
        }

    }
}
