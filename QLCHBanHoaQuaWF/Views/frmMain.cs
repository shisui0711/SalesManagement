

using System.Reflection;

namespace QLCHWF.Views
{
    public partial class frmMain : Form, IViewMain
    {
        public string User { get; set; }
        public string Role { get; set; }
        public Panel BodyPanel
        {
            get { return pnlBody; }
        }
        public event EventHandler? ShowStatistics;
        public event EventHandler? ShowSalesOrder;
        public event EventHandler? ShowImportOrder;
        public event EventHandler? ShowCustomer;
        public event EventHandler? ShowProduct;
        public event EventHandler? ShowProvider;
        public event EventHandler? ShowEmployee;
        public event EventHandler? ShowUser;
        public event EventHandler? ShowUserRole;
        public event EventHandler? ShowOptions;
        private bool IsLogout;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            btnProduct.Checked = true;
            ShowProduct?.Invoke(sender,e);
            IsLogout = false;
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!IsLogout)
            {
                Application.Exit();
            }
        }


        private void timerAnimation_Tick(object sender, EventArgs e)
        {

        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            ShowStatistics?.Invoke(sender,e);
        }

        private void btnSalesOrder_Click(object sender, EventArgs e)
        {
            ShowSalesOrder?.Invoke(sender,e);
        }

        private void btnImportOrder_Click(object sender, EventArgs e)
        {
            ShowImportOrder?.Invoke(sender,e);
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            ShowCustomer?.Invoke(sender,e);
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            ShowProduct?.Invoke(sender,e);
        }

        private void btnProvider_Click(object sender, EventArgs e)
        {
            ShowProvider?.Invoke(sender,e);
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            ShowEmployee?.Invoke(sender,e);
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            ShowUser?.Invoke(sender,e);
        }

        private void btnUserRole_Click(object sender, EventArgs e)
        {
            ShowUserRole?.Invoke(sender,e);
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            ShowOptions?.Invoke(sender,e);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            IsLogout = true;
            this.Close();
        }

        public void ChangeVisible(string controlName,bool value)
        {
            var type = GetType().GetField(controlName, BindingFlags.Instance | BindingFlags.NonPublic);
            if (type == null)
            {
                return;
            }

            var control = (Control)type.GetValue(this)!;
            control.Visible = value;
        }
    }
}
