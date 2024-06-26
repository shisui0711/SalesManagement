﻿using QLCHWF.CustomMessageBox;
using System.Reflection;

namespace QLCHWF.Views.Employee
{
    public partial class frmUpdateEmployee : Form, IUpdateEmployee
    {
        public int EmployeeID
        {
            get { return int.Parse(txtEmployeeID.Text); }
            set { txtEmployeeID.Text = value.ToString(); }
        }
        public string EmployeeName
        {
            get { return txtEmployeeName.Text; }
            set { txtEmployeeName.Text = value; }
        }
        public string Email
        {
            get { return txtEmail.Text; }
            set { txtEmail.Text = value; }
        }
        public string Phone
        {
            get { return txtPhone.Text; }
            set { txtPhone.Text = value; }
        }
        public string Address
        {
            get { return txtAddress.Text; }
            set { txtAddress.Text = value; }
        }
        public decimal? Salary
        {
            get { try
                {
                    return decimal.Parse(txtSalary.Text);
                }
                catch (Exception e)
                {
                    return null;
                }
            }
            set { txtSalary.Text = value.ToString(); }
        }
        public event EventHandler? UpdateEmployee;

        public void Focus(string name)
        {
            var textBoxField = this.GetType().GetFields(BindingFlags.Instance | BindingFlags.NonPublic).Where(x => x.Name == "txt" + name).FirstOrDefault();
            if (textBoxField != null)
            {
                var textBox = (UserControl)textBoxField.GetValue(this)!;
                textBox.Focus();
            }
        }
        public frmUpdateEmployee()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateEmployee?.Invoke(sender, e);
        }

        public void ShowMessage(string message)
        {
            MyMessageBox.Show(message);
        }
    }
}
