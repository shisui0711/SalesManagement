using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCHBanHoaQuaWF.Views.Provider
{
    public partial class frmAddProvider : Form,IAddProvider
    {
        private string _message;
        public string Message
        {
            get { return _message;}
            set { _message = value;
                MessageBox.Show(_message, "Thông báo");
            }
        }
        public void Focus(string name)
        {
            var textBoxField = this.GetType().GetField("txt" + name);
            if (textBoxField != null && textBoxField.GetType().IsAssignableTo(typeof(UserControl)))
            {
                var textBox = (UserControl)textBoxField.GetValue(this);
                textBox.Focus();
            }
        }
        public string ProviderName
        {
            get { return txtProviderName.Text; }
            set { txtProviderName.Text = value; }
        }

        public string Email {
            get { return txtEmail.Text; }
            set { txtEmail.Text = value; }
        }
        public string Phone {
            get { return txtPhone.Text; }
            set { txtPhone.Text = value; }
        }
        public string Address { get; set; }
        public event EventHandler? AddProvider;
        public frmAddProvider()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddProvider?.Invoke(sender,e);
        }

        
    }
}
