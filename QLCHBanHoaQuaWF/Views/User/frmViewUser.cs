using QLCHWF.CustomMessageBox;

namespace QLCHWF.Views.User
{
    public partial class frmViewUser : Form, IViewUser
    {
        public frmViewUser()
        {
            InitializeComponent();
        }

        public string SearchText
        {
            get { return txtSearch.Text; }
            set { txtSearch.Text = value; }
        }
        public BindingSource UserBindingSource
        {
            get { return userBindingSource; }
        }
        public event EventHandler? SearchUser;
        public event EventHandler? LoadUser;
        public event EventHandler? LockUser;
        public event EventHandler? UnlockUser;
        public event EventHandler ShowAddUser;
        public event EventHandler? ShowChangePassword;

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            ShowChangePassword?.Invoke(sender, e);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchUser?.Invoke(sender, e);
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadUser?.Invoke(sender, e);
        }

        private void frmViewUser_Load(object sender, EventArgs e)
        {
            LoadUser?.Invoke(sender, e);
        }

        private void btnLock_Click(object sender, EventArgs e)
        {
            if (MyMessageBox.Show("Bạn có chắc chắn muốn khóa tài khoản đã chọn", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            LockUser?.Invoke(sender, e);
        }

        private void btnUnlock_Click(object sender, EventArgs e)
        {
            if (MyMessageBox.Show("Bạn có chắc chắn muốn mở khóa tài khoản đã chọn", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            UnlockUser?.Invoke(sender, e);
        }

        public void ShowMessage(string message)
        {
            MyMessageBox.Show(message);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ShowAddUser?.Invoke(sender,e);
        }
    }
}
