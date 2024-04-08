namespace QLCHBanHoaQuaWF.Views
{
    public partial class frmLogin : Form, IViewLogin
    {
        private bool isHiden = true;
        public string Username
        {
            get { return txtUsername.Text; }
            set { txtUsername.Text = value; }
        }
        public string Password
        {
            get { return txtPassword.Text; }
            set { txtPassword.Text = value; }
        }
        public string Role
        {
            get
            {
                if (rdoQuanLy.Checked)
                {
                    return "Quản lý";
                }
                else if (rdoNhanVien.Checked)
                {
                    return "Nhân Viên";
                }
                else
                {
                    return null;
                }
            }
        }
        public event EventHandler LoginEvent;
        public frmLogin()
        {
            InitializeComponent();
        }
        private void txtPassword_IconRightClick(object sender, EventArgs e)
        {
            if (isHiden)
            {
                txtPassword.PasswordChar = '\0';
                txtPassword.IconRight = global::QLCHBanHoaQuaWF.Properties.Resources.hide;
                isHiden = false;
            }
            else
            {
                txtPassword.PasswordChar = '•';
                txtPassword.IconRight = global::QLCHBanHoaQuaWF.Properties.Resources.eye;
                isHiden = true;
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            rdoNhanVien.Checked = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginEvent?.Invoke(sender, e);
        }

    }
}
