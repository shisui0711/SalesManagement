using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLCHWF.CustomMessageBox;

namespace QLCHWF.Views.User
{
    public partial class frmAddUser : Form,IAddUser
    {
        public frmAddUser()
        {
            InitializeComponent();
        }

        public string Email
        {
            get { return txtEmail.Text;}
            set { txtEmail.Text = value; }
        }
        public int EmployeeID { get{
            try
            {
                return int.Parse(cboEmployee.Tag?.ToString()!);
            }
            catch (Exception)
            {
                return 0;
            }}}
        public int RoleID { get{
            try
            {
                return int.Parse(cboRole.Tag?.ToString()!);
            }
            catch (Exception)
            {
                return 0;
            }} }
        public string Password
        {
            get { return txtPassword.Text;}
            set { txtPassword.Text = value; }
        }

        public string Repassword
        {
            get { return txtRepassword.Text;}
            set { txtRepassword.Text = value; }
        }

        public BindingSource EmployeeBindingSource => employeeBindingSource;
        public BindingSource RoleBindingSource => userRoleBindingSource;
        public event EventHandler? AddUser;
        public void ShowMessage(string message)
        {
            MyMessageBox.Show(message);
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddUser?.Invoke(sender,e);
        }
    }
}
