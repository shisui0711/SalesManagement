using QLCHWF.CustomMessageBox;
using System.Reflection;

namespace QLCHWF.Views.UserRole
{
    public partial class frmUpdateUserRole : Form, IUpdateUserRole
    {
        public frmUpdateUserRole()
        {
            InitializeComponent();
        }

        public int RoleID
        {
            get { return int.Parse(txtRoleID.Text); }
            set { txtRoleID.Text = value.ToString(); }
        }
        public string RoleName
        {
            get { return txtRoleName.Text; }
            set { txtRoleName.Text = value; }
        }
        public string Description
        {
            get { return txtDescription.Text; }
            set { txtDescription.Text = value; }
        }
        public CheckedListBox PermissionSelected
        {
            get { return clbPermission; }
        }
        public event EventHandler? LoadPermission;
        public event EventHandler? UpdateUserRole;

        private void frmUpdateUserRole_Load(object sender, EventArgs e)
        {
            LoadPermission?.Invoke(sender, e);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            UpdateUserRole?.Invoke(sender, e);
        }

        public void Focus(string name)
        {
            var textBoxField = this.GetType().GetFields(BindingFlags.Instance | BindingFlags.NonPublic).Where(x => x.Name == "txt" + name).FirstOrDefault();
            if (textBoxField != null)
            {
                var textBox = (UserControl)textBoxField.GetValue(this)!;
                textBox.Focus();
            }
        }

        public void ShowMessage(string message)
        {
            MyMessageBox.Show(message);
        }
    }
}
