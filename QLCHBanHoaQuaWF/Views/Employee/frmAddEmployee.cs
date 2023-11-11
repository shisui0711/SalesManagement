using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCHBanHoaQuaWF.Views.Employee
{
    public partial class frmAddEmployee : Form, IAddEmployee
    {
        public string Message
        {
            get { return _message; }
            set
            {
                _message = value;
                MessageBox.Show(_message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private string _message;
        public string EmployeeName
        {
            get { return txtEmployeeName.Text;}
            set { txtEmployeeName.Text = value; }
        }
        public string Email {
            get { return txtEmail.Text; }
            set { txtAddress.Text = value; }
        }
        public string Phone {
            get { return txtPhone.Text; }
            set { txtPhone.Text = value; }
        }
        public string Address {
            get { return txtAddress.Text; }
            set { txtAddress.Text = value; }
        }
        public decimal Salary
        {
            get { return decimal.Parse(txtSalary.Text); }
            set { txtSalary.Text = value.ToString(); }
        }
        public event EventHandler AddEmployee;

        public void Focus(string name)
        {
            var textBoxField = this.GetType().GetField("txt" + name);
            if (textBoxField != null)
            {
                var textBox = (UserControl)textBoxField.GetValue(this);
                textBox.Focus();
            }
        }
        public frmAddEmployee()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddEmployee?.Invoke(sender,e);
        }
    }
}
