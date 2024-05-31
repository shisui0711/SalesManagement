using QLCHWF.CustomMessageBox;
using System.Reflection;

namespace QLCHWF.Views.Customer
{
    public partial class frmUpdateCustomer : Form, IUpdateCustomer
    {
        public int CustomerID
        {
            get { return int.Parse(txtID.Text); }
            set { txtID.Text = value.ToString(); }
        }
        public string CustomerName
        {
            get { return txtCustomerName.Text; }
            set { txtCustomerName.Text = value; }
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
        public void Focus(string name)
        {
            var textBoxField = this.GetType().GetFields(BindingFlags.Instance | BindingFlags.NonPublic).Where(x => x.Name == "txt" + name).FirstOrDefault();
            if (textBoxField != null)
            {
                var textBox = (UserControl)textBoxField.GetValue(this)!;
                textBox.Focus();
            }
        }

        public event EventHandler? UpdateCustomer;
        public frmUpdateCustomer()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateCustomer?.Invoke(sender, e);
        }

        public void ShowMessage(string message)
        {
            MyMessageBox.Show(message);
        }
    }
}
