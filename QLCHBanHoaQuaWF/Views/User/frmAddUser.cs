using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
                return int.Parse(cboEmployee.Tag.ToString());
            }
            catch (Exception e)
            {
                return 0;
            }}}
        public int RoleID { get{
            try
            {
                return int.Parse(cboRole.Tag.ToString());
            }
            catch (Exception e)
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
        public event EventHandler AddUser;
        public void ShowMessage(string message)
        {
            MyMessageBox.Show(message);
        }

        public void Focus(string name)
        {
            var textBoxField = this.GetType().GetField("txt" + name);
            if (textBoxField != null && textBoxField.GetType().IsAssignableTo(typeof(UserControl)))
            {
                var textBox = (UserControl)textBoxField.GetValue(this);
                textBox?.Focus();
            }
        }
    }
}
