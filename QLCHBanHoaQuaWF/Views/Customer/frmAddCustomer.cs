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
using Guna.UI2.WinForms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using String = System.String;

namespace QLCHBanHoaQuaWF.Views.Customer
{
    public partial class frmAddCustomer : Form,IAddCustomer
    {
        public string CustomerName
        {
            get { return txtCustomerName.Text;}
            set { txtCustomerName.Text = value; }
        }
        public string Email
        {
            get { return txtEmail.Text;}
            set { txtEmail.Text = value; }
        }
        public string Phone {
            get { return txtPhone.Text; }
            set { txtPhone.Text = value; }
        }
        public string Address {
            get { return txtAddress.Text; }
            set { txtAddress.Text = value; }
        }

        public string Message
        {
            get { return _message;}
            set { _message = value;
                MessageBox.Show(_message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private string _message;
        public void Focus(string name)
        {
            var textBoxField = this.GetType().GetField("txt" + name);
            if (textBoxField != null)
            {
                var textBox = (UserControl)textBoxField.GetValue(this);
                textBox.Focus();
            }
        }

        public void Reset()
        {
           var fieldTypes = this.GetType().GetFields(BindingFlags.Instance | BindingFlags.NonPublic)
                .Where(f => f.Name.StartsWith("txt"));
           foreach (var fieldType in fieldTypes)
           {
               UserControl control = (UserControl)fieldType.GetValue(this);
               control.Text = String.Empty;
           }
        }

        public event EventHandler AddCustomer;
        public frmAddCustomer()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddCustomer?.Invoke(sender,e);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
