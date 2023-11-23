namespace QLCHBanHoaQuaWF.Views
{
    public partial class frmMain : Form, IViewMain
    {
        public string User
        {
            get { return lblUser.Text; }
            set { lblUser.Text = value; }
        }
        public string Role
        {
            get { return lblRole.Text; }
            set { lblRole.Text = value; }
        }

        public TabControl NavigationBar
        {
            get { return tbcNav; }
        }
        public event EventHandler? LoadPages;
        public event EventHandler? Logout;
        private bool IsLogout;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadPages?.Invoke(sender, e);
            IsLogout = false;
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!IsLogout)
            {
                Application.Exit();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            IsLogout = true;
            this.Close();
        }


        private void timerAnimation_Tick(object sender, EventArgs e)
        {

        }
    }
}
