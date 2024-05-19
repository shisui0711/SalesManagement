using System.Reflection;
using QLCHWF.CustomMessageBox;
using String = System.String;

namespace QLCHWF.Views.Customer
{
    public partial class frmAddCustomer : Form, IAddCustomer
    {
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
            var textBoxField = this.GetType().GetFields(BindingFlags.Instance | BindingFlags.NonPublic).Where(x=>x.Name == "txt"+name).FirstOrDefault();
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
            AddCustomer?.Invoke(sender, e);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ShowMessage(string message)
        {
            MyMessageBox.Show(message);
        }
    }
}
