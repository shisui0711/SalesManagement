using QLCHWF.CustomMessageBox;

namespace QLCHWF.Views.UserRole
{
    public partial class frmViewUserRole : Form, IViewUserRole
    {
        public frmViewUserRole()
        {
            InitializeComponent();
        }

        public string SearchText
        {
            get { return txtSearch.Text; }
            set { txtSearch.Text = value; }
        }
        public BindingSource UserRoleBindingSource
        {
            get { return userRoleBindingSource; }
        }
        public event EventHandler? RemoveUserRole;
        public event EventHandler? LoadUserRole;
        public event EventHandler? SearchUserRole;
        public event EventHandler? ShowAddUserRole;
        public event EventHandler? ShowUpdateUserRole;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ShowAddUserRole?.Invoke(sender, e);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ShowUpdateUserRole?.Invoke(sender, e);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var dialogResult = MyMessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi đã chọn ?", "Thông báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Cancel)
            {
                return;
            }
            RemoveUserRole?.Invoke(sender, e);
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadUserRole?.Invoke(sender, e);
        }

        private void frmViewUserRole_Load(object sender, EventArgs e)
        {
            LoadUserRole?.Invoke(sender, e);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchUserRole?.Invoke(sender, e);
        }

        public void ShowMessage(string message)
        {
            MyMessageBox.Show(message);
        }
    }
}
